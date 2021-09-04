
namespace Bookstore.WindowsFormsUI.Publisher
{
    partial class frmPublisherList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPublisherList));
            this.gcAuthorInfo = new DevExpress.XtraEditors.GroupControl();
            this.txtAddress = new System.Windows.Forms.RichTextBox();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.txtWebsite = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtPublisherName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridPublisher = new System.Windows.Forms.DataGridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcAuthorInfo)).BeginInit();
            this.gcAuthorInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPublisher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcAuthorInfo
            // 
            this.gcAuthorInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcAuthorInfo.Controls.Add(this.txtAddress);
            this.gcAuthorInfo.Controls.Add(this.btnDelete);
            this.gcAuthorInfo.Controls.Add(this.btnUpdate);
            this.gcAuthorInfo.Controls.Add(this.txtWebsite);
            this.gcAuthorInfo.Controls.Add(this.txtEmail);
            this.gcAuthorInfo.Controls.Add(this.txtFax);
            this.gcAuthorInfo.Controls.Add(this.txtPhone);
            this.gcAuthorInfo.Controls.Add(this.txtPublisherName);
            this.gcAuthorInfo.Controls.Add(this.label6);
            this.gcAuthorInfo.Controls.Add(this.label5);
            this.gcAuthorInfo.Controls.Add(this.label4);
            this.gcAuthorInfo.Controls.Add(this.label3);
            this.gcAuthorInfo.Controls.Add(this.label2);
            this.gcAuthorInfo.Controls.Add(this.label1);
            this.gcAuthorInfo.Location = new System.Drawing.Point(964, 12);
            this.gcAuthorInfo.Name = "gcAuthorInfo";
            this.gcAuthorInfo.Size = new System.Drawing.Size(374, 576);
            this.gcAuthorInfo.TabIndex = 4;
            this.gcAuthorInfo.Text = "Yayınevi Bilgisi";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtAddress.Location = new System.Drawing.Point(132, 298);
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
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(253, 526);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(107, 36);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtWebsite
            // 
            this.txtWebsite.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtWebsite.Location = new System.Drawing.Point(132, 251);
            this.txtWebsite.Name = "txtWebsite";
            this.txtWebsite.Size = new System.Drawing.Size(228, 27);
            this.txtWebsite.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtEmail.Location = new System.Drawing.Point(132, 209);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(228, 27);
            this.txtEmail.TabIndex = 4;
            // 
            // txtFax
            // 
            this.txtFax.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtFax.Location = new System.Drawing.Point(132, 167);
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(228, 27);
            this.txtFax.TabIndex = 3;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtPhone.Location = new System.Drawing.Point(132, 125);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(228, 27);
            this.txtPhone.TabIndex = 2;
            // 
            // txtPublisherName
            // 
            this.txtPublisherName.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtPublisherName.Location = new System.Drawing.Point(132, 83);
            this.txtPublisherName.Name = "txtPublisherName";
            this.txtPublisherName.Size = new System.Drawing.Size(228, 27);
            this.txtPublisherName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label6.Location = new System.Drawing.Point(52, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Adres :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label5.Location = new System.Drawing.Point(38, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Website :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label4.Location = new System.Drawing.Point(54, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Email :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label3.Location = new System.Drawing.Point(69, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fax :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(40, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Telefon :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(5, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yayınevi Adı :";
            // 
            // gridPublisher
            // 
            this.gridPublisher.AllowUserToAddRows = false;
            this.gridPublisher.AllowUserToDeleteRows = false;
            this.gridPublisher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPublisher.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridPublisher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridPublisher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPublisher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPublisher.Location = new System.Drawing.Point(2, 23);
            this.gridPublisher.MultiSelect = false;
            this.gridPublisher.Name = "gridPublisher";
            this.gridPublisher.ReadOnly = true;
            this.gridPublisher.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gridPublisher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPublisher.Size = new System.Drawing.Size(942, 551);
            this.gridPublisher.TabIndex = 5;
            this.gridPublisher.TabStop = false;
            this.gridPublisher.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPublisher_CellClick);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridPublisher);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(946, 576);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "Yayınevi Listesi";
            // 
            // frmPublisherList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 600);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gcAuthorInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPublisherList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yayınevi Listesi";
            this.Load += new System.EventHandler(this.frmPublisherList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcAuthorInfo)).EndInit();
            this.gcAuthorInfo.ResumeLayout(false);
            this.gcAuthorInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPublisher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcAuthorInfo;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private System.Windows.Forms.TextBox txtPublisherName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridPublisher;
        private System.Windows.Forms.RichTextBox txtAddress;
        private System.Windows.Forms.TextBox txtWebsite;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}