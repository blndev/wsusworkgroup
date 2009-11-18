using System;
using System.Collections.Generic;
using System.Text;

namespace Codeplex.DBedarf.WSUS.Workgroup.ClientSettingManager
{
    class WSUSSettingManager
    {

        /// <summary>
        /// Save the current Reg-Settings to a Reg-Export - File
        /// </summary>
        /// <param name="filename">Filename to write it</param>
        /// <exception cref="Exception">any Exception are forwarded</exception>
        public void BackupCurrentSettings(string filename)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public string WSUSServer
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
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
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

        internal void RestartService()
        {
            throw new Exception("The method or operation is not implemented.");
            System.ServiceProcess.ServiceController sc = new System.ServiceProcess.ServiceController("wuauserv");

        }
    }
}
