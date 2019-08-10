namespace Praksa5
{
    partial class frmMailSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMailSettings));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSMTPHost = new System.Windows.Forms.TextBox();
            this.txtEmailUsername = new System.Windows.Forms.TextBox();
            this.txtEmailPassword = new System.Windows.Forms.TextBox();
            this.chkMailSSL = new System.Windows.Forms.CheckBox();
            this.btnMailSettingsSave = new System.Windows.Forms.Button();
            this.txtSMTPPort = new System.Windows.Forms.MaskedTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtSMTPHost, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtEmailUsername, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtEmailPassword, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.chkMailSSL, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnMailSettingsSave, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtSMTPPort, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(364, 197);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SMTP Host";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SMTP Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email Password";
            // 
            // txtSMTPHost
            // 
            this.txtSMTPHost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSMTPHost.Location = new System.Drawing.Point(119, 3);
            this.txtSMTPHost.Name = "txtSMTPHost";
            this.txtSMTPHost.Size = new System.Drawing.Size(242, 20);
            this.txtSMTPHost.TabIndex = 4;
            // 
            // txtEmailUsername
            // 
            this.txtEmailUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmailUsername.Location = new System.Drawing.Point(119, 55);
            this.txtEmailUsername.Name = "txtEmailUsername";
            this.txtEmailUsername.Size = new System.Drawing.Size(242, 20);
            this.txtEmailUsername.TabIndex = 6;
            // 
            // txtEmailPassword
            // 
            this.txtEmailPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmailPassword.Location = new System.Drawing.Point(119, 81);
            this.txtEmailPassword.Name = "txtEmailPassword";
            this.txtEmailPassword.Size = new System.Drawing.Size(242, 20);
            this.txtEmailPassword.TabIndex = 7;
            // 
            // chkMailSSL
            // 
            this.chkMailSSL.AutoSize = true;
            this.chkMailSSL.Checked = true;
            this.chkMailSSL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMailSSL.Location = new System.Drawing.Point(119, 107);
            this.chkMailSSL.Name = "chkMailSSL";
            this.chkMailSSL.Size = new System.Drawing.Size(46, 17);
            this.chkMailSSL.TabIndex = 8;
            this.chkMailSSL.Text = "SSL";
            this.chkMailSSL.UseVisualStyleBackColor = true;
            // 
            // btnMailSettingsSave
            // 
            this.btnMailSettingsSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMailSettingsSave.Location = new System.Drawing.Point(286, 171);
            this.btnMailSettingsSave.Name = "btnMailSettingsSave";
            this.btnMailSettingsSave.Size = new System.Drawing.Size(75, 23);
            this.btnMailSettingsSave.TabIndex = 9;
            this.btnMailSettingsSave.Text = "Save";
            this.btnMailSettingsSave.UseVisualStyleBackColor = true;
            this.btnMailSettingsSave.Click += new System.EventHandler(this.btnMailSettingsSave_Click);
            // 
            // txtSMTPPort
            // 
            this.txtSMTPPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSMTPPort.Location = new System.Drawing.Point(119, 29);
            this.txtSMTPPort.Mask = "00000";
            this.txtSMTPPort.Name = "txtSMTPPort";
            this.txtSMTPPort.Size = new System.Drawing.Size(242, 20);
            this.txtSMTPPort.TabIndex = 10;
            this.txtSMTPPort.ValidatingType = typeof(int);
            // 
            // frmMailSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 233);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMailSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mail Settings";
            this.Load += new System.EventHandler(this.frmMailSettings_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSMTPHost;
        private System.Windows.Forms.TextBox txtEmailUsername;
        private System.Windows.Forms.TextBox txtEmailPassword;
        private System.Windows.Forms.CheckBox chkMailSSL;
        private System.Windows.Forms.Button btnMailSettingsSave;
        private System.Windows.Forms.MaskedTextBox txtSMTPPort;
    }
}