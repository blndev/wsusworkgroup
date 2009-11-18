using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Codeplex.DBedarf.WSUS.Workgroup.ClientSettingManager
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void CheckRequiredField(TextBox txt)
        {
            if (string.IsNullOrEmpty(txt.Text))
            {
                errorProviderOK.SetError(txt, "");
                errorProviderNet.SetError(txt, "");
                errorProviderRed.SetError(txt, "Required");
            }
            else
            {
                errorProviderRed.SetError(txt, "");
                errorProviderOK.SetError(txt, "OK");
            }
        }

        private void HandleError(Exception ex)
        {
            MessageBox.Show(ex.Message, "A problem occurred", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            System.Version ver = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            this.Text = String.Format("{0} V{1}.{2} Build:{4} Rev:{3}", Application.ProductName, ver.Major, ver.Minor, ver.Revision, ver.Build);
        }

        private void txtWSUSServer_TextChanged(object sender, EventArgs e)
        {
            int offset = txtWSUSStateServer.Text.Length;
            if (offset > 0) offset = 1;

            if (txtWSUSServer.Text.Contains(txtWSUSStateServer.Text.Substring(0, txtWSUSStateServer.Text.Length - offset))) txtWSUSStateServer.Text = txtWSUSServer.Text;
            CheckRequiredField(txtWSUSServer);
            CheckRequiredField(txtWSUSStateServer);
        }

        private void chkEnableGroup_CheckStateChanged(object sender, EventArgs e)
        {
            txtGroupName.ReadOnly = !chkEnableGroup.Checked;
            if (txtGroupName.ReadOnly) CheckRequiredField(txtGroupName);
            else errorProviderRed.SetError(txtGroupName, "");
        }

        private void txtGroupName_TextChanged(object sender, EventArgs e)
        {
            CheckRequiredField(txtGroupName);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog();
        }

        private void txtWSUSLogServer_TextChanged(object sender, EventArgs e)
        {
            CheckRequiredField(txtWSUSStateServer);
        }

        private void mnuExportToRegFile_Click(object sender, EventArgs e)
        {
            //TODO: implementieren
        }

        private void cmdRestoreSettings_Click(object sender, EventArgs e)
        {
            //TODO: implementieren
        }

        private void cmdWriteSettings_Click(object sender, EventArgs e)
        {
            //TODO: implementieren
            if (MessageBox.Show("Are you sure you want to enable the WSUS settings?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (saveRegFile_Dialog.ShowDialog() == DialogResult.OK)
                    {
                        WSUSSettingManager man = new WSUSSettingManager();
                        man.BackupCurrentSettings(saveRegFile_Dialog.FileName);

                        man.WSUSServer = txtWSUSServer.Text;
                        man.WSUSStateServer = txtWSUSStateServer.Text;
                        man.EnableGroupSettings = chkEnableGroup.Checked;
                        man.ComputergroupName = txtGroupName.Text;
                        man.AutoUpdateDetection = chkEnableUpdateInterval.Checked;
                        man.AutoUpdateInterval = (int)numUpdateInterval.Value;
                        man.RebootDelayEnabled = chkEnableRebootDelay.Checked;
                        man.RebootDelayTime = (int)numRebootDelayTime.Value;
                        man.AutoInstallMinorUpdates = chkAutoInstallMinor.Checked;
                        man.AllowRebootIfUserLoggedOn = !chkNoRebootWithUser.Checked;
                        man.AllowNonAdminInstall = chkNonAdminInstall.Checked;
                        
                        man.RestartService();

                    }//end if safefile
                }//end try
                catch (Exception ex)
                {
                    HandleError(ex);
                }

            }//end if really?
        }

        private void licenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                HandleError(ex);
            }
        }


    }
}