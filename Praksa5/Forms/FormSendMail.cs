﻿using System;
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
            try
                mail.From = new MailAddress(txtMailFrom.Text);
                {
                    mail.To.Add(m);
                {
                    mail.Attachments.Add(new Attachment(attachmentFileName));
                }
        }

        private void frmSendMail_Load(object sender, EventArgs e)
        {
            txtMailTo.Text = mailTo;
        }
    }
}