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
using System.Diagnostics;

namespace Codeplex.DBedarf.WSUS.Workgroup.ClientSettingManager
{
    /// <summary>
    /// The Manager to Read/Write WSUS Settings on the Client
    /// </summary>
    public class WSUSSettingManager
    {
        #region SubTypes

        /// <summary>
        /// Commands for the wuauctl util
        /// </summary>
        public enum eWUAUCtlCmd
        {
            /// <summary>
            ///  zeigt den Einstellungsdialog "Automatische Updates" an
            /// </summary>
            ShowSettingsDialog,
            /// <summary>
            /// öffnet die Microsoft Update Webseite bzw. Windows Update in der Systemsteuerung
            /// </summary>
            ShowWindowsUpdate,
            /// <summary>
            ///  Symbols im Systray
            /// </summary>
            DemoUI,
            /// <summary>
            /// sendet bericht zu updates an wsus
            /// </summary>
            reportnow,
            /// <summary>
            /// prüft sofort auf autoupdates
            /// </summary>
            detectnow,
            /// <summary>
            /// löscht anmeldecookie
            /// </summary>
            resetauthorization
        }

        #endregion

        #region Constructors
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
        #endregion

        #region RegAccess
        private const string HKLM_WU = @"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\windows\WindowsUpdate";
        private const string HKLM_WUAU = @"HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Microsoft\windows\WindowsUpdate\AU";

        /// <summary>
        /// Reg Folders for WSUS Settings
        /// </summary>
        protected enum eWURegKeys
        {
            /// <summary>
            /// 
            /// </summary>
            HKLM_WU,
            /// <summary>
            /// 
            /// </summary>
            HKLM_WUAU
        }


        /// <summary>
        /// get value from reg as string
        /// </summary>
        /// <param name="folder">The reg folder</param>
        /// <param name="Name">value name</param>
        /// <returns></returns>
        protected string RegGetValue(eWURegKeys folder, string Name)
        {
            return RegGetValue(folder, Name, "").ToString();
        }

        /// <summary>
        /// get value from reg
        /// </summary>
        /// <param name="folder">The reg folder</param>
        /// <param name="Name">value name</param>
        /// <param name="Default">default value</param>
        /// <returns></returns>
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
            //if(Microsoft.Win32.Registry.get
            object retVal = Microsoft.Win32.Registry.GetValue(key, Name, Default);
            if (retVal == null) retVal = Default;
            return retVal;
        }

        /// <summary>
        /// set the value in reg
        /// </summary>
        /// <param name="folder">Reg Folder</param>
        /// <param name="Name">value name</param>
        /// <param name="Value">The value</param>
        protected void RegSetValue(eWURegKeys folder, string Name, string Value)
        {
            RegSetValue(folder, Name, Value, Microsoft.Win32.RegistryValueKind.String);
        }

        /// <summary>
        /// set the value in reg
        /// </summary>
        /// <param name="folder">Reg Folder</param>
        /// <param name="Name">value name</param>
        /// <param name="Value">The value</param>
        /// <param name="ValueKind">Kind of the value.</param>
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
        protected static void backupAllRegKeyValues(System.IO.StringWriter sw, Microsoft.Win32.RegistryKey reg)
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
        /// <summary>
        /// Gets or sets the WSUS server and Enables AutoUpdates.
        /// </summary>
        /// <value>The WSUS server.</value>
        public string WSUSServer
        {
            get
            {
                return RegGetValue(eWURegKeys.HKLM_WU, "WUServer");
            }
            set
            {
                if (_AllowWrite)
                {
                    if (String.IsNullOrEmpty(value)) value = "";
                    if (value.StartsWith("http://", StringComparison.CurrentCultureIgnoreCase) == false)
                    {
                        value = getWSUS_URL(value);
                    }
                    //aktivation AutoUpdates
                    RegSetValue(eWURegKeys.HKLM_WUAU, "NoAutoUpdate", 0, Microsoft.Win32.RegistryValueKind.DWord);
                    //set wu Server akttive or inactive
                    RegSetValue(eWURegKeys.HKLM_WUAU, "UseWUServer", (String.IsNullOrEmpty(value) ? 0 : 1), Microsoft.Win32.RegistryValueKind.DWord);
                    //now set server
                    RegSetValue(eWURegKeys.HKLM_WU, "WUServer", value);
                }
            }
        }

        /// <summary>
        /// Gets or sets the WSUS state server.
        /// </summary>
        /// <value>The WSUS state server.</value>
        public string WSUSStateServer
        {
            get
            {
                return RegGetValue(eWURegKeys.HKLM_WU, "WUStatusServer");
            }
            set
            {
                if (String.IsNullOrEmpty(value)) value = "";
                if (value.StartsWith("http://", StringComparison.CurrentCultureIgnoreCase) == false)
                {
                    value = getWSUS_URL(value);
                }
                if (_AllowWrite) RegSetValue(eWURegKeys.HKLM_WU, "WUStatusServer", value);
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [enable group settings].
        /// </summary>
        /// <value><c>true</c> if [enable group settings]; otherwise, <c>false</c>.</value>
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

        /// <summary>
        /// Gets or sets the name of the computergroup.
        /// </summary>
        /// <value>The name of the computergroup.</value>
        public string ComputergroupName
        {
            get
            {
                return RegGetValue(eWURegKeys.HKLM_WU, "TargetGroup");
            }
            set
            {
                if (_AllowWrite) RegSetValue(eWURegKeys.HKLM_WU, "TargetGroup", value);
            }
        }

        /// <summary>
        /// Gets or sets a value indicating that the [auto update detection] interval is enabled or not.
        /// </summary>
        /// <remarks>Setting "DetectionFrequencyEnabled" </remarks>
        /// <value><c>true</c> if [auto update detection]; otherwise, <c>false</c>.</value>
        public bool AutoUpdateDetection
        {
            get
            {
                return (Convert.ToInt64(RegGetValue(eWURegKeys.HKLM_WUAU, "DetectionFrequencyEnabled", 0)) == 1);
            }
            set
            {
                if (_AllowWrite) RegSetValue(eWURegKeys.HKLM_WUAU, "DetectionFrequencyEnabled", (value ? 1 : 0), Microsoft.Win32.RegistryValueKind.DWord);
            }
        }

        /// <summary>
        /// Gets or sets the auto update interval.
        /// </summary>
        /// <value>The auto update interval.</value>
        public int AutoUpdateInterval
        {
            get
            {
                return Convert.ToInt32(RegGetValue(eWURegKeys.HKLM_WUAU, "DetectionFrequencyEnabled", 0));
            }
            set
            {
                if (_AllowWrite) RegSetValue(eWURegKeys.HKLM_WUAU, "DetectionFrequencyEnabled", value, Microsoft.Win32.RegistryValueKind.DWord);
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [reboot delay enabled].
        /// </summary>
        /// <value><c>true</c> if [reboot delay enabled]; otherwise, <c>false</c>.</value>
        public bool RebootDelayEnabled
        {
            get
            {
                return (Convert.ToInt64(RegGetValue(eWURegKeys.HKLM_WUAU, "RebootRelaunchTimeoutEnabled", 0)) == 1);
            }
            set
            {
                if (_AllowWrite) RegSetValue(eWURegKeys.HKLM_WUAU, "RebootRelaunchTimeoutEnabled", (value ? 1 : 0), Microsoft.Win32.RegistryValueKind.DWord);
            }
        }

        /// <summary>
        /// Gets or sets the reboot delay time in minutes.
        /// </summary>
        /// <value>The reboot delay time.</value>
        public int RebootDelayTime
        {
            get
            {
                return Convert.ToInt32(RegGetValue(eWURegKeys.HKLM_WUAU, "RebootRelaunchTimeout", 0));
            }
            set
            {
                if (_AllowWrite) RegSetValue(eWURegKeys.HKLM_WUAU, "RebootRelaunchTimeout", value, Microsoft.Win32.RegistryValueKind.DWord);
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [auto install minor updates].
        /// </summary>
        /// <value>
        /// 	<c>true</c> if [auto install minor updates]; otherwise, <c>false</c>.
        /// </value>
        public bool AutoInstallMinorUpdates
        {
            get
            {
                return (Convert.ToInt64(RegGetValue(eWURegKeys.HKLM_WUAU, "AutoInstallMinorUpdates", 0)) == 1);
            }
            set
            {
                if (_AllowWrite) RegSetValue(eWURegKeys.HKLM_WUAU, "AutoInstallMinorUpdates", (value ? 1 : 0), Microsoft.Win32.RegistryValueKind.DWord);
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [allow reboot if user logged on].
        /// </summary>
        /// <value>
        /// 	<c>true</c> if [allow reboot if user logged on]; otherwise, <c>false</c>.
        /// </value>
        public bool AllowRebootIfUserLoggedOn
        {
            get
            {
                return (Convert.ToInt64(RegGetValue(eWURegKeys.HKLM_WUAU, "NoAutoRebootWithLoggedOnUsers", 0)) == 0);
            }
            set
            {
                if (_AllowWrite) RegSetValue(eWURegKeys.HKLM_WUAU, "NoAutoRebootWithLoggedOnUsers", (value ? 0 : 1), Microsoft.Win32.RegistryValueKind.DWord);
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [allow non admin install].
        /// </summary>
        /// <value>
        /// 	<c>true</c> if [allow non admin install]; otherwise, <c>false</c>.
        /// </value>
        public bool AllowNonAdminInstall
        {
            get
            {
                return (Convert.ToInt64(RegGetValue(eWURegKeys.HKLM_WU, "ElevateNonAdmins", 0)) == 1);
            }
            set
            {
                if (_AllowWrite) RegSetValue(eWURegKeys.HKLM_WU, "ElevateNonAdmins", (value ? 1 : 0), Microsoft.Win32.RegistryValueKind.DWord);
            }
        }

        /// <summary>
        /// Gets or sets the scheduled install time.
        /// </summary>
        /// <value>The scheduled install time.</value>
        public int ScheduledInstallTime
        {
            get
            {
                return Convert.ToInt32(RegGetValue(eWURegKeys.HKLM_WUAU, "ScheduledInstallTime", 0));
            }
            set
            {
                if (value < 0 || value > 23) throw new ArgumentOutOfRangeException("must be 0 to 23 as hour of day");
                if (_AllowWrite) RegSetValue(eWURegKeys.HKLM_WUAU, "ScheduledInstallTime", value, Microsoft.Win32.RegistryValueKind.DWord);
            }
        }

        /// <summary>
        /// Gets or sets the scheduled install day.
        /// </summary>
        /// <remarks> 0|1|2|3|4|5|6|7
        /// 0 = täglich
        /// 1-7 = Nummer des Wochentags beginnend bei Sonntag
        /// </remarks>
        /// <value>The scheduled install day.</value>
        public int ScheduledInstallDay
        {
            get
            {
                return Convert.ToInt32(RegGetValue(eWURegKeys.HKLM_WUAU, "ScheduledInstallDay", 0));
            }
            set
            {
                if (value < 0 || value > 7) throw new ArgumentOutOfRangeException("must be 0 for every day or 1-6 for su, mo, tu, we, th, fr, sa");
                if (_AllowWrite) RegSetValue(eWURegKeys.HKLM_WUAU, "ScheduledInstallDay", value, Microsoft.Win32.RegistryValueKind.DWord);
            }
        }

        #endregion

        #region Helper

        /// <summary>
        /// Get the default WSUS URL
        /// </summary>
        /// <param name="servername">The servername.</param>
        /// <returns>http://servername:port</returns>
        private static string getWSUS_URL(string servername)
        {
            return string.Format("http://{0}:8530", servername);
        }

        /// <summary>
        /// Gets the name of the reg key.
        /// </summary>
        /// <param name="RegFolder">The reg folder.</param>
        /// <returns>Name as String</returns>
        private static string getRegKeyName(eWURegKeys RegFolder)
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
        ///  Removes the HKLM an the [] from the KeyName
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>Name without HKLM_</returns>
        private static string removeHKnn_FromRegKey(string key)
        {
            key = key.Replace("HKEY_LOCAL_MACHINE\\", "");
            key = key.Replace("HKEY_CURRENT_USER\\", "");
            key = key.Replace("HKEY_CLASSES_ROOT\\", "");
            return key;
        }

        #endregion

        #region Functions

        #endregion

        #region Static Functions

        /// <summary>
        /// Save the current Reg-Settings to a Reg-Export - File
        /// </summary>
        /// <param name="filename">Filename to write it</param>
        /// <exception cref="Exception">any Exception are forwarded</exception>
        public static void BackupCurrentSettings(string filename)
        {
            System.IO.StringWriter sw = new System.IO.StringWriter();

            //Write the RegFile Header
            sw.WriteLine("Windows Registry Editor Version 5.00");
            sw.WriteLine("");

            string currentKey = getRegKeyName(eWURegKeys.HKLM_WU);
            Microsoft.Win32.RegistryKey reg = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(removeHKnn_FromRegKey(currentKey), true);
            if (reg == null)
            {
                //Write the Delete - Command
                sw.WriteLine("[-{0}]", currentKey);
            }
            else
            {
                sw.WriteLine("[{0}]", currentKey);
                backupAllRegKeyValues(sw, reg);
                sw.WriteLine();

                currentKey = getRegKeyName(eWURegKeys.HKLM_WUAU);
                reg = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(removeHKnn_FromRegKey(currentKey), true);
                if (reg == null)
                {
                    //Write the Delete - Command
                    sw.WriteLine("[-{0}]", currentKey);
                }
                else
                {
                    sw.WriteLine("[{0}]", currentKey);
                    backupAllRegKeyValues(sw, reg);
                }
            }
            System.IO.File.WriteAllText(filename, sw.ToString(), System.Text.ASCIIEncoding.Default);
        }

        /// <summary>
        /// name of the windows update service
        /// </summary>
        private const string WUSERVICENAME = "wuauserv";

        /// <summary>
        /// Restarts the windows update service.
        /// </summary>
        public static void ServiceRestart()
        {
            ServiceStop(true);
            ServiceStart(true);
        }

        /// <summary>
        /// start the update services
        /// </summary>
        public static void ServiceStart()
        {
            ServiceStart(false);
        }

        /// <summary>
        /// Services the start.
        /// </summary>
        /// <param name="WaitForStarting">if set to <c>true</c> [wait for starting].</param>
        public static void ServiceStart(bool WaitForStarting)
        {
            System.ServiceProcess.ServiceController sc = new System.ServiceProcess.ServiceController(WUSERVICENAME);
            if (sc == null) throw new Exception("service \"" + WUSERVICENAME + "\" not found");

            if (    
                sc.Status != System.ServiceProcess.ServiceControllerStatus.Running
                &&
                sc.Status != System.ServiceProcess.ServiceControllerStatus.StartPending
                )
            {
                sc.Start();
            }
            if(WaitForStarting) sc.WaitForStatus(System.ServiceProcess.ServiceControllerStatus.Running, new TimeSpan(0,0,10));
        }

        /// <summary>
        ///  stop the update services
        /// </summary>
        public static void ServiceStop()
        {
            ServiceStop(false);
        }

        /// <summary>
        /// Services the stop.
        /// </summary>
        /// <param name="WaitForStopping">if set to <c>true</c> [wait for stopping].</param>
        public static void ServiceStop(bool WaitForStopping)
        {
            System.ServiceProcess.ServiceController sc = new System.ServiceProcess.ServiceController(WUSERVICENAME);
            if (sc == null) throw new Exception("service \"" + WUSERVICENAME + "\" not found");

            if (
                sc.Status != System.ServiceProcess.ServiceControllerStatus.Stopped
                &&
                sc.Status != System.ServiceProcess.ServiceControllerStatus.StopPending
                )
            {
                sc.Stop();
            }
            if(WaitForStopping) sc.WaitForStatus(System.ServiceProcess.ServiceControllerStatus.Stopped, new TimeSpan(0,0,10));
        }

        /// <summary>
        /// Removes the WSUS-Settings.
        /// </summary>
        public static void RemoveWSUS()
        {
            Microsoft.Win32.Registry.LocalMachine.DeleteSubKeyTree(removeHKnn_FromRegKey(HKLM_WU));
            System.Diagnostics.EventLog.WriteEntry("WSUSSettingManager", "RemoveWSUS", EventLogEntryType.Information);
        }

        /// <summary>
        /// Starts the WUAUCTL Util.
        /// </summary>
        /// <param name="cmd">The command to execute</param>
        /// <returns></returns>
        public static bool StartWUAUCtl(eWUAUCtlCmd cmd)
        {
            try
            {
                System.Diagnostics.Process.Start("wuauclt.exe", "/" + cmd.ToString());
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.StackTrace);
                return false;
            }
            return true;
        }

        #endregion

    }
}
