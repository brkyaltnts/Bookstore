using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bookstore.Business.Abstract;
using Bookstore.Business.DependencyResolvers.Ninject;
using DevExpress.XtraGrid.Views.Tile;

namespace Bookstore.WindowsFormsUI.Forms.Type
{
    public partial class frmTypeList : Form
    {
        public frmTypeList()
        {
            InitializeComponent();
            _typeService = InstanceFactory.GetInstance<ITypeService>();
        }

        private ITypeService _typeService;
        private void frmTypeList_Load(object sender, EventArgs e)
        {
            GetType();
        }
        void GetType()
        {
            gridType.DataSource = _typeService.GetAll();

            gridType.Columns[0].Visible = false;
            gridType.Columns[1].HeaderText = "Tür Adı";
        }

        private int _typeId;
        private void gridType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = gridType.CurrentRow;
            _typeId = int.Parse(row.Cells[0].Value.ToString());
            txtTypeName.Text = row.Cells[1].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (gridType.CurrentRow != null)
            {
                DialogResult dialog = MessageBox.Show("Tür Güncellensin Mi?", "Uyarı!", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    _typeService.Update(new Entities.Concrete.Type
                    {
                        Id = _typeId,
                        TypeName = txtTypeName.Text
                    });
                    MessageBox.Show("Tür Başarıyla Güncellendi!", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetType();
                }
                else
                {
                    MessageBox.Show("Tür Güncellenmedi!", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridType.CurrentRow != null)
            {
                DialogResult dialog = MessageBox.Show("Tür Silinsin Mi?", "Uyarı!", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    _typeService.Delete(new Entities.Concrete.Type
                    {
                        Id = _typeId
                    });
                    MessageBox.Show("Tür Başarıyla Silindi!", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetType();
                }
                else
                {
                    MessageBox.Show("Tür Silinmedi!", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
