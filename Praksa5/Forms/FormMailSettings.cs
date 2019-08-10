using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;

namespace Praksa5
{
    public partial class frmMailSettings : Form
    {
        MyConfigurationManager configurationManager;

        public frmMailSettings()
        {
            InitializeComponent();
            configurationManager = new MyConfigurationManager();
        }

        private void frmMailSettings_Load(object sender, EventArgs e)
        {
            txtSMTPHost.Text = configurationManager.GetKey("SMTPHost");
            txtSMTPPort.Text = configurationManager.GetKey("SMTPPort");
            txtEmailUsername.Text = configurationManager.GetKey("EmailUsername");
            txtEmailPassword.Text = configurationManager.GetKey("EmailPassword");
            chkMailSSL.Checked = (configurationManager.GetKey("SMTPSSL") == "yes");
        }

        private void btnMailSettingsSave_Click(object sender, EventArgs e)
        {
            string ssl = (chkMailSSL.Checked) ? "yes" : "no";
            if (!configurationManager.SetKey("SMTPHost", txtSMTPHost.Text))
            {
                MessageBox.Show("Failed to save SMTP Host!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!configurationManager.SetKey("SMTPPort", txtSMTPPort.Text))
            {
                MessageBox.Show("Failed to save SMTP Host!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!configurationManager.SetKey("EmailUsername", txtEmailUsername.Text))
            {
                MessageBox.Show("Failed to save SMTP Host!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!configurationManager.SetKey("EmailPassword", txtEmailPassword.Text))
            {
                MessageBox.Show("Failed to save SMTP Host!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!configurationManager.SetKey("SMTPSSL", ssl))
            {
                MessageBox.Show("Failed to save SMTP Host!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Successfully saved mail settings!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
