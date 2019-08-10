namespace Praksa5
{
    partial class frmEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployee));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblEmployeeJMBG = new System.Windows.Forms.Label();
            this.txtJMBG = new System.Windows.Forms.TextBox();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtEmployeeSurname = new System.Windows.Forms.TextBox();
            this.lblEmployeeSurname = new System.Windows.Forms.Label();
            this.lblEmployeeParentName = new System.Windows.Forms.Label();
            this.txtEmployeeParentName = new System.Windows.Forms.TextBox();
            this.txtEmployeeAddress = new System.Windows.Forms.TextBox();
            this.lblEmployeeAddress = new System.Windows.Forms.Label();
            this.cbEmployeeCity = new System.Windows.Forms.ComboBox();
            this.txtEmployeeEmail = new System.Windows.Forms.TextBox();
            this.lblEmployeeCity = new System.Windows.Forms.Label();
            this.lblEmployeeEmail = new System.Windows.Forms.Label();
            this.btnEmployeeSave = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.lblEmployeeJMBG, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtJMBG, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblEmployeeName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtEmployeeName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtEmployeeSurname, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblEmployeeSurname, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblEmployeeParentName, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtEmployeeParentName, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtEmployeeAddress, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblEmployeeAddress, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cbEmployeeCity, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtEmployeeEmail, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblEmployeeCity, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblEmployeeEmail, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.btnEmployeeSave, 1, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(525, 321);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblEmployeeJMBG
            // 
            this.lblEmployeeJMBG.AutoSize = true;
            this.lblEmployeeJMBG.Location = new System.Drawing.Point(3, 0);
            this.lblEmployeeJMBG.Name = "lblEmployeeJMBG";
            this.lblEmployeeJMBG.Size = new System.Drawing.Size(36, 13);
            this.lblEmployeeJMBG.TabIndex = 1;
            this.lblEmployeeJMBG.Text = "JMBG";
            // 
            // txtJMBG
            // 
            this.txtJMBG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtJMBG.Location = new System.Drawing.Point(160, 3);
            this.txtJMBG.Name = "txtJMBG";
            this.txtJMBG.Size = new System.Drawing.Size(362, 20);
            this.txtJMBG.TabIndex = 2;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Location = new System.Drawing.Point(3, 26);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(35, 13);
            this.lblEmployeeName.TabIndex = 3;
            this.lblEmployeeName.Text = "Name";
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmployeeName.Location = new System.Drawing.Point(160, 29);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(362, 20);
            this.txtEmployeeName.TabIndex = 4;
            // 
            // txtEmployeeSurname
            // 
            this.txtEmployeeSurname.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmployeeSurname.Location = new System.Drawing.Point(160, 55);
            this.txtEmployeeSurname.Name = "txtEmployeeSurname";
            this.txtEmployeeSurname.Size = new System.Drawing.Size(362, 20);
            this.txtEmployeeSurname.TabIndex = 5;
            // 
            // lblEmployeeSurname
            // 
            this.lblEmployeeSurname.AutoSize = true;
            this.lblEmployeeSurname.Location = new System.Drawing.Point(3, 52);
            this.lblEmployeeSurname.Name = "lblEmployeeSurname";
            this.lblEmployeeSurname.Size = new System.Drawing.Size(49, 13);
            this.lblEmployeeSurname.TabIndex = 6;
            this.lblEmployeeSurname.Text = "Surname";
            // 
            // lblEmployeeParentName
            // 
            this.lblEmployeeParentName.AutoSize = true;
            this.lblEmployeeParentName.Location = new System.Drawing.Point(3, 78);
            this.lblEmployeeParentName.Name = "lblEmployeeParentName";
            this.lblEmployeeParentName.Size = new System.Drawing.Size(69, 13);
            this.lblEmployeeParentName.TabIndex = 7;
            this.lblEmployeeParentName.Text = "Parent Name";
            // 
            // txtEmployeeParentName
            // 
            this.txtEmployeeParentName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmployeeParentName.Location = new System.Drawing.Point(160, 81);
            this.txtEmployeeParentName.Name = "txtEmployeeParentName";
            this.txtEmployeeParentName.Size = new System.Drawing.Size(362, 20);
            this.txtEmployeeParentName.TabIndex = 8;
            // 
            // txtEmployeeAddress
            // 
            this.txtEmployeeAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmployeeAddress.Location = new System.Drawing.Point(160, 107);
            this.txtEmployeeAddress.Name = "txtEmployeeAddress";
            this.txtEmployeeAddress.Size = new System.Drawing.Size(362, 20);
            this.txtEmployeeAddress.TabIndex = 9;
            // 
            // lblEmployeeAddress
            // 
            this.lblEmployeeAddress.AutoSize = true;
            this.lblEmployeeAddress.Location = new System.Drawing.Point(3, 104);
            this.lblEmployeeAddress.Name = "lblEmployeeAddress";
            this.lblEmployeeAddress.Size = new System.Drawing.Size(45, 13);
            this.lblEmployeeAddress.TabIndex = 10;
            this.lblEmployeeAddress.Text = "Address";
            // 
            // cbEmployeeCity
            // 
            this.cbEmployeeCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEmployeeCity.FormattingEnabled = true;
            this.cbEmployeeCity.Location = new System.Drawing.Point(160, 133);
            this.cbEmployeeCity.Name = "cbEmployeeCity";
            this.cbEmployeeCity.Size = new System.Drawing.Size(362, 21);
            this.cbEmployeeCity.TabIndex = 11;
            // 
            // txtEmployeeEmail
            // 
            this.txtEmployeeEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmployeeEmail.Location = new System.Drawing.Point(160, 160);
            this.txtEmployeeEmail.Name = "txtEmployeeEmail";
            this.txtEmployeeEmail.Size = new System.Drawing.Size(362, 20);
            this.txtEmployeeEmail.TabIndex = 12;
            // 
            // lblEmployeeCity
            // 
            this.lblEmployeeCity.AutoSize = true;
            this.lblEmployeeCity.Location = new System.Drawing.Point(3, 130);
            this.lblEmployeeCity.Name = "lblEmployeeCity";
            this.lblEmployeeCity.Size = new System.Drawing.Size(24, 13);
            this.lblEmployeeCity.TabIndex = 13;
            this.lblEmployeeCity.Text = "City";
            // 
            // lblEmployeeEmail
            // 
            this.lblEmployeeEmail.AutoSize = true;
            this.lblEmployeeEmail.Location = new System.Drawing.Point(3, 157);
            this.lblEmployeeEmail.Name = "lblEmployeeEmail";
            this.lblEmployeeEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmployeeEmail.TabIndex = 14;
            this.lblEmployeeEmail.Text = "Email";
            // 
            // btnEmployeeSave
            // 
            this.btnEmployeeSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEmployeeSave.AutoSize = true;
            this.btnEmployeeSave.Location = new System.Drawing.Point(435, 295);
            this.btnEmployeeSave.Name = "btnEmployeeSave";
            this.btnEmployeeSave.Size = new System.Drawing.Size(87, 23);
            this.btnEmployeeSave.TabIndex = 15;
            this.btnEmployeeSave.Text = "Save Changes";
            this.btnEmployeeSave.UseVisualStyleBackColor = true;
            this.btnEmployeeSave.Click += new System.EventHandler(this.btnEmployeeSave_Click);
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 345);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.frmEmployee_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblEmployeeJMBG;
        private System.Windows.Forms.TextBox txtJMBG;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeSurname;
        private System.Windows.Forms.Label lblEmployeeSurname;
        private System.Windows.Forms.Label lblEmployeeParentName;
        private System.Windows.Forms.TextBox txtEmployeeParentName;
        private System.Windows.Forms.TextBox txtEmployeeAddress;
        private System.Windows.Forms.Label lblEmployeeAddress;
        private System.Windows.Forms.ComboBox cbEmployeeCity;
        private System.Windows.Forms.TextBox txtEmployeeEmail;
        private System.Windows.Forms.Label lblEmployeeCity;
        private System.Windows.Forms.Label lblEmployeeEmail;
        private System.Windows.Forms.Button btnEmployeeSave;
    }
}