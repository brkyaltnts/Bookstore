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

namespace Bookstore.WindowsFormsUI.Forms.Type
{
    public partial class frmTypeAdd : Form
    {
        public frmTypeAdd()
        {
            InitializeComponent();
            _typeService = InstanceFactory.GetInstance<ITypeService>();
        }

        private ITypeService _typeService;
        private void btnSave_Click(object sender, EventArgs e)
        {
            _typeService.Add(new Entities.Concrete.Type
            {
               TypeName = txtTypeName.Text
            });
            MessageBox.Show("Tür Başarıyla Kayıt Edildi!", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
