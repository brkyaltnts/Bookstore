
namespace Bookstore.WindowsFormsUI.Author
{
    partial class frmAuthorList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAuthorList));
            this.gcAuthorInfo = new DevExpress.XtraEditors.GroupControl();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.txtBiography = new System.Windows.Forms.RichTextBox();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridAuthor = new System.Windows.Forms.DataGridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcAuthorInfo)).BeginInit();
            this.gcAuthorInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAuthor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcAuthorInfo
            // 
            this.gcAuthorInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gcAuthorInfo.Controls.Add(this.btnDelete);
            this.gcAuthorInfo.Controls.Add(this.btnUpdate);
            this.gcAuthorInfo.Controls.Add(this.txtBiography);
            this.gcAuthorInfo.Controls.Add(this.txtAuthorName);
            this.gcAuthorInfo.Controls.Add(this.label2);
            this.gcAuthorInfo.Controls.Add(this.label1);
            this.gcAuthorInfo.Location = new System.Drawing.Point(964, 12);
            this.gcAuthorInfo.Name = "gcAuthorInfo";
            this.gcAuthorInfo.Size = new System.Drawing.Size(374, 576);
            this.gcAuthorInfo.TabIndex = 1;
            this.gcAuthorInfo.Text = "Yazar Bilgisi";
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(140, 526);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 36);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Sil";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(253, 526);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(107, 36);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtBiography
            // 
            this.txtBiography.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtBiography.Location = new System.Drawing.Point(94, 133);
            this.txtBiography.Name = "txtBiography";
            this.txtBiography.Size = new System.Drawing.Size(266, 378);
            this.txtBiography.TabIndex = 2;
            this.txtBiography.Text = "";
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtAuthorName.Location = new System.Drawing.Point(94, 83);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(266, 27);
            this.txtAuthorName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label2.Location = new System.Drawing.Point(11, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Biyografi :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(5, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yazar Adı :";
            // 
            // gridAuthor
            // 
            this.gridAuthor.AllowUserToAddRows = false;
            this.gridAuthor.AllowUserToDeleteRows = false;
            this.gridAuthor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridAuthor.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridAuthor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridAuthor.Location = new System.Drawing.Point(2, 23);
            this.gridAuthor.MultiSelect = false;
            this.gridAuthor.Name = "gridAuthor";
            this.gridAuthor.ReadOnly = true;
            this.gridAuthor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gridAuthor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAuthor.Size = new System.Drawing.Size(942, 551);
            this.gridAuthor.TabIndex = 7;
            this.gridAuthor.TabStop = false;
            this.gridAuthor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridAuthor_CellClick);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridAuthor);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(946, 576);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "Yazar Listesi";
            // 
            // frmAuthorList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 600);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gcAuthorInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAuthorList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yazar Listesi";
            this.Load += new System.EventHandler(this.frmAuthorList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcAuthorInfo)).EndInit();
            this.gcAuthorInfo.ResumeLayout(false);
            this.gcAuthorInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAuthor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl gcAuthorInfo;
        private System.Windows.Forms.RichTextBox txtBiography;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private System.Windows.Forms.DataGridView gridAuthor;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}