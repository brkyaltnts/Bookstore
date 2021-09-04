﻿
namespace Bookstore.WindowsFormsUI.Forms.Reader
{
    partial class frmReaderList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReaderList));
            this.txtBirthday = new System.Windows.Forms.TextBox();
            this.gcAuthorInfo = new DevExpress.XtraEditors.GroupControl();
            this.txtAddress = new System.Windows.Forms.RichTextBox();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.txtReference = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtProfession = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridReader = new System.Windows.Forms.DataGridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcAuthorInfo)).BeginInit();
            this.gcAuthorInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridReader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBirthday
            // 
            this.txtBirthday.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtBirthday.Location = new System.Drawing.Point(133, 121);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Size = new System.Drawing.Size(228, 27);
            this.txtBirthday.TabIndex = 3;
            // 
            // gcAuthorInfo
            // 
            this.gcAuthorInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcAuthorInfo.Controls.Add(this.txtBirthday);
            this.gcAuthorInfo.Controls.Add(this.txtAddress);
            this.gcAuthorInfo.Controls.Add(this.btnDelete);
            this.gcAuthorInfo.Controls.Add(this.btnUpdate);
            this.gcAuthorInfo.Controls.Add(this.txtReference);
            this.gcAuthorInfo.Controls.Add(this.txtEmail);
            this.gcAuthorInfo.Controls.Add(this.txtProfession);
            this.gcAuthorInfo.Controls.Add(this.txtPhone);
            this.gcAuthorInfo.Controls.Add(this.txtLastName);
            this.gcAuthorInfo.Controls.Add(this.txtFirstName);
            this.gcAuthorInfo.Controls.Add(this.label6);
            this.gcAuthorInfo.Controls.Add(this.label8);
            this.gcAuthorInfo.Controls.Add(this.label7);
            this.gcAuthorInfo.Controls.Add(this.label5);
            this.gcAuthorInfo.Controls.Add(this.label4);
            this.gcAuthorInfo.Controls.Add(this.label3);
            this.gcAuthorInfo.Controls.Add(this.label2);
            this.gcAuthorInfo.Controls.Add(this.label1);
            this.gcAuthorInfo.Location = new System.Drawing.Point(964, 12);
            this.gcAuthorInfo.Name = "gcAuthorInfo";
            this.gcAuthorInfo.Size = new System.Drawing.Size(374, 576);
            this.gcAuthorInfo.TabIndex = 9;
            this.gcAuthorInfo.Text = "Okuyucu Bilgisi";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtAddress.Location = new System.Drawing.Point(133, 293);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(228, 156);
            this.txtAddress.TabIndex = 6;
            this.txtAddress.Text = "";
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(140, 526);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 36);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Sil";
            // 
            // btnUpdate
            // 
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(253, 526);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(107, 36);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Güncelle";
            // 
            // txtReference
            // 
            this.txtReference.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtReference.Location = new System.Drawing.Point(133, 460);
            this.txtReference.Name = "txtReference";
            this.txtReference.ReadOnly = true;
            this.txtReference.Size = new System.Drawing.Size(228, 27);
            this.txtReference.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtEmail.Location = new System.Drawing.Point(133, 250);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(228, 27);
            this.txtEmail.TabIndex = 5;
            // 
            // txtProfession
            // 
            this.txtProfession.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtProfession.Location = new System.Drawing.Point(133, 164);
            this.txtProfession.Name = "txtProfession";
            this.txtProfession.Size = new System.Drawing.Size(228, 27);
            this.txtProfession.TabIndex = 4;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtPhone.Location = new System.Drawing.Point(133, 207);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(228, 27);
            this.txtPhone.TabIndex = 4;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtLastName.Location = new System.Drawing.Point(133, 78);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(228, 27);
            this.txtLastName.TabIndex = 2;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtFirstName.Location = new System.Drawing.Point(133, 35);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(228, 27);
            this.txtFirstName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label6.Location = new System.Drawing.Point(64, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Adres :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label8.Location = new System.Drawing.Point(44, 463);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 19);
            this.label8.TabIndex = 0;
            this.label8.Text = "Referans :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label7.Location = new System.Drawing.Point(58, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Meslek :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label5.Location = new System.Drawing.Point(66, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.Location = new System.Drawing.Point(52, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Telefon :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(7, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Doğum Tarihi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(58, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Soyadı :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(81, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı :";
            // 
            // gridReader
            // 
            this.gridReader.AllowUserToAddRows = false;
            this.gridReader.AllowUserToDeleteRows = false;
            this.gridReader.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridReader.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridReader.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridReader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridReader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridReader.Location = new System.Drawing.Point(2, 23);
            this.gridReader.MultiSelect = false;
            this.gridReader.Name = "gridReader";
            this.gridReader.ReadOnly = true;
            this.gridReader.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gridReader.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridReader.Size = new System.Drawing.Size(942, 551);
            this.gridReader.TabIndex = 5;
            this.gridReader.TabStop = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridReader);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(946, 576);
            this.groupControl1.TabIndex = 10;
            this.groupControl1.Text = "Okuyucu Listesi";
            // 
            // frmReaderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 600);
            this.Controls.Add(this.gcAuthorInfo);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReaderList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Okuyucu Listesi";
            this.Load += new System.EventHandler(this.frmReaderList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcAuthorInfo)).EndInit();
            this.gcAuthorInfo.ResumeLayout(false);
            this.gcAuthorInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridReader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBirthday;
        private DevExpress.XtraEditors.GroupControl gcAuthorInfo;
        private System.Windows.Forms.RichTextBox txtAddress;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridReader;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox txtReference;
        private System.Windows.Forms.TextBox txtProfession;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}