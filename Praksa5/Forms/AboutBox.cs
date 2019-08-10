using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praksa5
{
    partial class frmAboutBox : Form
    {
        public frmAboutBox()
        {
            InitializeComponent();
        }

        private void frmAboutBox_Load(object sender, EventArgs e)
        {
            frmMain mainForm = (frmMain)this.Owner;
            this.Text = String.Format("About {0}", Praksa5.Settings.AppTitle);
            this.labelProductName.Text = Praksa5.Settings.AppTitle;
            this.labelVersion.Text = String.Format("Version {0}", Praksa5.Settings.AppVersion);
            this.labelCopyright.Text = Praksa5.Settings.AppLicence;
            this.labelCompanyName.Text = Praksa5.Settings.AppAuthor;
            this.textBoxDescription.Text = Praksa5.Settings.AppDescription;
        }
    }
}
