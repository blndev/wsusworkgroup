#region Copyright
// Copyright (C) 2009 Daniel Bedarf
//
// For further information visit: http://wsusworkgroup.codeplex.com/
//
// This program is free software; you can redistribute it and/or
// modify it under the terms of the GNU General Public License
// as published by the Free Software Foundation; either version 2
// of the License.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program; if not, If not, see <http://www.gnu.org/licenses/>.
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace Codeplex.DBedarf.WSUS.Workgroup.ClientSettingManager
{
    public class WSUSSettingManager
    {

        /// <summary>
        /// Create a new Class in ReadOnly - Mode
        /// </summary>
        public WSUSSettingManager()
        {
            _AllowWrite = false;
        }

        protected bool _AllowWrite;
        /// <summary>
        /// Create a new Class in specified Mode
        /// </summary>
        /// <param name="AllowWrite"><see cref="true"/>ReadWrite, <see cref="false"/>ReadOnly</param>
        public WSUSSettingManager(bool AllowWrite)
        {
            _AllowWrite = AllowWrite;
        }

        #region RegAccess
        private const string HKLM_WU = @"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\windows\WindowsUpdate";
        private const string HKLM_WUAU = @"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\windows\WindowsUpdate\AU";

        protected enum eWURegKeys
        {
            HKLM_WU,
            HKLM_WUAU
        }


        protected string RegGetValue(eWURegKeys folder, string Name)
        {
            return RegGetValue(folder, Name, "").ToString();
        }

        protected object RegGetValue(eWURegKeys folder, string Name, object Default)
        {
            string key = "";
            switch (folder)
            {
                case eWURegKeys.HKLM_WU:
                    key = HKLM_WU; break;
                case eWURegKeys.HKLM_WUAU:
                    key = HKLM_WUAU; break;
                default: throw new NotSupportedException();
            }
            return Microsoft.Win32.Registry.GetValue(key, Name, "");
        }

        protected void RegSetValue(eWURegKeys folder, string Name, string Value)
        {
            RegSetValue(folder, Name, Value, Microsoft.Win32.RegistryValueKind.String);
        }

        protected void RegSetValue(eWURegKeys folder, string Name, object Value, Microsoft.Win32.RegistryValueKind ValueKind)
        {
            if (!_AllowWrite) throw new Exception("Write is not allowed in this mode!");
            string key = "";
            switch (folder)
            {
                case eWURegKeys.HKLM_WU:
                    key = HKLM_WU; break;
                case eWURegKeys.HKLM_WUAU:
                    key = HKLM_WUAU; break;
                default: throw new NotSupportedException();
            }
            Microsoft.Win32.Registry.SetValue(key, Name, Value);
        }

        /// <summary>
        /// makes a backup of all values in this regkey to the stream
        /// </summary>
        /// <param name="sw">Stream to write in</param>
        /// <param name="reg">Key to get the Values</param>
        protected static void getAllRegKeyValues(System.IO.StringWriter sw, Microsoft.Win32.RegistryKey reg)
        {
            foreach (string valueName in reg.GetValueNames())
            {
                switch (reg.GetValueKind(valueName))
                {
                    case Microsoft.Win32.RegistryValueKind.DWord:
                        sw.WriteLine("\"{0}\"=dword:{1}", valueName, Convert.ToInt64(reg.GetValue(valueName, "")).ToString("00000000"));
                        break;
                    default:
                        sw.WriteLine("\"{0}\"=\"{1}\"", valueName, reg.GetValue(valueName, "").ToString());
                        break;
                }
            }

        }

        #endregion

        #region Props
        public string WSUSServer
        {
            get
            {
                return RegGetValue(eWURegKeys.HKLM_WU, "WUServer");
            }
            set
            {
                if (_AllowWrite) RegSetValue(eWURegKeys.HKLM_WU, "WUServer", value);
            }
        }

        public string WSUSStateServer
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public bool EnableGroupSettings
        {
            get
            {
                return (Convert.ToInt64(RegGetValue(eWURegKeys.HKLM_WU, "TargetGroupEnabled", 0)) == 1);
            }
            set
            {
                if (_AllowWrite) RegSetValue(eWURegKeys.HKLM_WU, "TargetGroupEnabled", (value ? 1 : 0), Microsoft.Win32.RegistryValueKind.DWord);
            }
        }

        public string ComputergroupName
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public bool AutoUpdateDetection
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int AutoUpdateInterval
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public bool RebootDelayEnabled
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public int RebootDelayTime
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public bool AutoInstallMinorUpdates
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public bool AllowRebootIfUserLoggedOn
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public bool AllowNonAdminInstall
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        #endregion

        #region Func
        /// <summary>
        /// Save the current Reg-Settings to a Reg-Export - File
        /// </summary>
        /// <param name="filename">Filename to write it</param>
        /// <exception cref="Exception">any Exception are forwarded</exception>
        public void BackupCurrentSettings(string filename)
        {
            System.IO.StringWriter sw = new System.IO.StringWriter();

            //Write the RegFile Header
            sw.WriteLine("Windows Registry Editor Version 5.00");
            sw.WriteLine("");

            string currentKey = getRegKeyName(eWURegKeys.HKLM_WU);
            Microsoft.Win32.RegistryKey reg = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(removeHK__FromRegKey(currentKey), true);
            if (reg == null)
            {
                //Write the Delete - Command
                sw.WriteLine("[-{0}]", currentKey);
            }
            else
            {
                sw.WriteLine("[{0}]", currentKey);
                getAllRegKeyValues(sw, reg);
                sw.WriteLine();

                currentKey = getRegKeyName(eWURegKeys.HKLM_WUAU);
                reg = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(removeHK__FromRegKey(currentKey), true);
                if (reg == null)
                {
                    //Write the Delete - Command
                    sw.WriteLine("[-{0}]", currentKey);
                }
                else
                {
                    sw.WriteLine("[{0}]", currentKey);
                    getAllRegKeyValues(sw, reg);
                }
            }
            System.IO.File.WriteAllText(filename, sw.ToString(), System.Text.ASCIIEncoding.Default);
        }

        #region Helper

        private string getRegKeyName(eWURegKeys RegFolder)
        {
            string key = "";
            switch (RegFolder)
            {
                case eWURegKeys.HKLM_WU:
                    key = HKLM_WU; break;
                case eWURegKeys.HKLM_WUAU:
                    key = HKLM_WUAU; break;
                default: throw new NotSupportedException();
            }
            return key;
        }

        /// <summary>
        /// Removes the HKLM an the [] from the KeyName
        /// </summary>
        /// <param name="RegKey"></param>
        /// <returns></returns>
        private string removeHK__FromRegKey(string key)
        {
            key = key.Replace("HKEY_LOCAL_MACHINE\\", "");
            key = key.Replace("HKEY_CURRENT_USER\\", "");
            key = key.Replace("HKEY_CLASSES_ROOT\\", "");
            return key;
        }

        #endregion

        public void RestartService()
        {
            //TODO impl.
            throw new Exception("The method or operation is not implemented.");
            System.ServiceProcess.ServiceController sc = new System.ServiceProcess.ServiceController("wuauserv");

        }


        public void RemoveWSUS()
        {
            //TODO impl.
            throw new Exception("The method or operation is not implemented.");
        }
        #endregion

    }
}
