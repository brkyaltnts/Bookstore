
namespace Bookstore.WindowsFormsUI.Forms.Type
{
    partial class frmTypeList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTypeList));
            this.gcAuthorInfo = new DevExpress.XtraEditors.GroupControl();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.txtTypeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridType = new System.Windows.Forms.DataGridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.gcAuthorInfo)).BeginInit();
            this.gcAuthorInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridType)).BeginInit();
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
            this.gcAuthorInfo.Controls.Add(this.txtTypeName);
            this.gcAuthorInfo.Controls.Add(this.label1);
            this.gcAuthorInfo.Location = new System.Drawing.Point(964, 12);
            this.gcAuthorInfo.Name = "gcAuthorInfo";
            this.gcAuthorInfo.Size = new System.Drawing.Size(374, 576);
            this.gcAuthorInfo.TabIndex = 9;
            this.gcAuthorInfo.Text = "Tür Bilgisi";
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Location = new System.Drawing.Point(140, 526);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(107, 36);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Sil";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.ImageOptions.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(253, 526);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(107, 36);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtTypeName
            // 
            this.txtTypeName.Font = new System.Drawing.Font("Tahoma", 12F);
            this.txtTypeName.Location = new System.Drawing.Point(94, 83);
            this.txtTypeName.Name = "txtTypeName";
            this.txtTypeName.Size = new System.Drawing.Size(266, 27);
            this.txtTypeName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label1.Location = new System.Drawing.Point(5, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tür Adı :";
            // 
            // gridType
            // 
            this.gridType.AllowUserToAddRows = false;
            this.gridType.AllowUserToDeleteRows = false;
            this.gridType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridType.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gridType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridType.Location = new System.Drawing.Point(2, 23);
            this.gridType.MultiSelect = false;
            this.gridType.Name = "gridType";
            this.gridType.ReadOnly = true;
            this.gridType.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gridType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridType.Size = new System.Drawing.Size(942, 551);
            this.gridType.TabIndex = 7;
            this.gridType.TabStop = false;
            this.gridType.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridType_CellClick);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridType);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(946, 576);
            this.groupControl1.TabIndex = 10;
            this.groupControl1.Text = "Tür Listesi";
            // 
            // frmTypeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 600);
            this.Controls.Add(this.gcAuthorInfo);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTypeList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tür Listesi";
            this.Load += new System.EventHandler(this.frmTypeList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gcAuthorInfo)).EndInit();
            this.gcAuthorInfo.ResumeLayout(false);
            this.gcAuthorInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gcAuthorInfo;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private System.Windows.Forms.TextBox txtTypeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridType;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}