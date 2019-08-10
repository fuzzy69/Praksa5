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
using System.Net.Mail;

namespace Praksa5
{
    public partial class frmSendMail : Form
    {
        public string mailTo;
        string attachmentFileName = null;
        MyConfigurationManager configurationManager;

        public frmSendMail()
        {
            InitializeComponent();
            configurationManager = new MyConfigurationManager();
        }

        private void btnAddAttachment_Click(object sender, EventArgs e)
        {
            var fileDialog = new OpenFileDialog();
            fileDialog.Title = "Add Mail Attachment";
            string attachmentFileName = Helpers.OpenFile("Add PDF Attachment", "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*");
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            try            {                string mailHost = configurationManager.GetKey("SMTPHost");                int mailPort = Int32.Parse(configurationManager.GetKey("SMTPPort"));                string userName = configurationManager.GetKey("EmailUsername");                string password = configurationManager.GetKey("EmailPassword");                var mail = new MailMessage();                var mailClient = new SmtpClient(mailHost, mailPort);
                mail.From = new MailAddress(txtMailFrom.Text);                string[] mails = txtMailTo.Text.Split(',');                foreach (var m in mails)
                {
                    mail.To.Add(m);                }                mail.Subject = txtMailSubject.Text;                mail.Body = txtMailMessage.Text;                if (attachmentFileName != null)
                {
                    mail.Attachments.Add(new Attachment(attachmentFileName));
                }                mailClient.Port = mailPort;                mailClient.Credentials = new System.Net.NetworkCredential(userName, password);                mailClient.EnableSsl = (configurationManager.GetKey("SMTPSSL") == "yes");                mailClient.Send(mail);                MessageBox.Show(String.Format("Successfully sent mail to {0}!", mailTo));                Close();            }            catch (Exception ex)            {                MessageBox.Show(String.Format("Failed to send e-mail, {0}", ex.Message));            }
        }

        private void frmSendMail_Load(object sender, EventArgs e)
        {
            txtMailTo.Text = mailTo;
        }
    }
}
