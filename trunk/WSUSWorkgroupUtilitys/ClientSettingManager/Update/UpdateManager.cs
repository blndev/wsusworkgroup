using System;
using System.Collections.Generic;
using System.Text;

namespace Codeplex.DBedarf.WSUS.Workgroup.ClientSettingManager.Update
{

    /// <summary>
    /// Update Checker for Codeplex - Hosting
    /// </summary>
    class UpdateManager
    {

        private const string URL = "http://wsusworkgroup.codeplex.com/wikipage?title=AutoUpdateInfo";

        public bool IsUpdateAvailable(Version CurrentVersion, out UpdateInfo udi)
        {
            bool hasUpdate = false;
            udi = new UpdateInfo();
            udi.Clear();
            try
            {
                string ver = CurrentVersion.Major.ToString("000000");
                ver += CurrentVersion.Minor.ToString("000000");
                ver += CurrentVersion.Build.ToString("000000");
                ver += CurrentVersion.Revision.ToString("000000");

                System.Net.WebClient wc = new System.Net.WebClient();
                string updatePage = wc.DownloadString(URL);

                string udiHeader = System.Text.RegularExpressions.Regex.Match(updatePage, "#-#-#-#-#-#-#-#-#(?<ui>.*)#-#-#-#-#-#-#-#-#", System.Text.RegularExpressions.RegexOptions.Singleline).Groups["ui"].Value;
                string udiHistory = System.Text.RegularExpressions.Regex.Match(updatePage, "#/#/#/#/#/#/#/#/#(?<hi>.*)#/#/#/#/#/#/#/#/#", System.Text.RegularExpressions.RegexOptions.Singleline).Groups["hi"].Value;

                Dictionary<string, string> kvpData = new Dictionary<string, string>();
                foreach (string data in udiHeader.ToLower().Split(new string[] { "<br />" }, StringSplitOptions.RemoveEmptyEntries))
                {
                    kvpData.Add(data.Substring(0, data.IndexOf("=")), data.Substring(data.IndexOf("=") + 1));
                }

                if (kvpData.ContainsKey("message"))
                    udi.Message = kvpData["message"].Replace("\\n", "\n");

                if (kvpData.ContainsKey("title"))
                    udi.Titel = kvpData["title"];

                if (kvpData.ContainsKey("version"))
                    udi.Version = new Version(kvpData["version"]);

                if (kvpData.ContainsKey("url"))
                    udi.URL = kvpData["url"];
                else
                    udi.URL = URL;

                udi.HTMLHistory = udiHistory;
                hasUpdate = (udi.Version > CurrentVersion);

            }
            catch (Exception ex)
            {
                System.Diagnostics.Trace.WriteLine(ex.ToString());
                throw new Exception("Error while checking for new updates.", ex);
            }
            return hasUpdate;
        }

        public bool CanHandleUpdates
        {
            get { return false; }
        }

        public void DoUpdate()
        {
            throw new NotSupportedException();
        }

        //Sample for check
        /*
        private void Useraction_CheckUpdates(object sender, RoutedEventArgs e)
        {
            Update.IUpdater updater = new Update.Codeplex();
            Update.UpdateInfo udi;
            Version v = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            if (updater.IsUpdateAvailable(v, out udi))
            {
                if ( MessageBox.Show(
                    string.Format(
                        "An update with Title {3} is available for this application.\n\n   Current Version:\t{0}\n   New Version:\t{1}\nDetails:\n{2}\n\nDo you like to open the Update Site?",
                        v,
                        udi.Version,
                        udi.Message,
                        udi.Titel
                        ), 
                    "Update available", 
                    MessageBoxButton.YesNo, 
                    MessageBoxImage.Information)==MessageBoxResult.Yes )
                {
                    try
                    {
                        System.Diagnostics.Process.Start(udi.URL);
                    }
                    catch (Exception ex)
                    {
                        HandleError(ex);
                    }
                }
            }
          
         */
    }
}
