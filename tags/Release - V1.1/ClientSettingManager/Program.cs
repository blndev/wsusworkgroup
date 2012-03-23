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

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Deployment.Application;
using System.Threading;

namespace Codeplex.DBedarf.WSUS.Workgroup.ClientSettingManager
{
    static class Program
    {

        /// <summary>
        /// Mains this instance.
        /// </summary>
        [STAThread]
        static void Main()
        {
            checkForUpdatesAsync();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }

        private static void checkForUpdatesAsync()
        {
            Thread t = new Thread(new ThreadStart(checkForUpdates));
            t.Start();
        }
        private static void checkForUpdates()
        {
            try
            {
                if(Properties.Settings.Default.CheckForUpdates==false) return;
                if (ApplicationDeployment.IsNetworkDeployed == false)
                {
                    DayOfWeek dow = DateTime.Now.DayOfWeek;
                    if (dow == DayOfWeek.Monday || dow == DayOfWeek.Wednesday || dow == DayOfWeek.Friday)
                    {
                        Update.UpdateManager udm = new Update.UpdateManager();
                        Update.UpdateInfo udi = new Update.UpdateInfo();
                        if (udm.IsUpdateAvailable(System.Reflection.Assembly.GetExecutingAssembly().GetName().Version, out udi))
                        {
                            if(MessageBox.Show(string.Format("New Version: {0}\n{1} \n\nDo you like to open the download page?",udi.Version, udi.Message),"update available", MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
                            {
                                    System.Diagnostics.Process.Start(udi.URL);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        }
    }
}