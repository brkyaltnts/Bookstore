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

namespace Bookstore.WindowsFormsUI.Publisher
{
    public partial class frmPublisherAdd : Form
    {
        public frmPublisherAdd()
        {
            InitializeComponent();
            _publisherService = InstanceFactory.GetInstance<IPublisherService>();
        }

        private IPublisherService _publisherService;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _publisherService.Add(new Entities.Concrete.Publisher
            {
                PublisherName = txtPublisherName.Text,
                Phone = txtPhone.Text,
                Fax = txtFax.Text,
                Email = txtEmail.Text,
                Website = txtWebsite.Text,
                Address = txtAddress.Text
            });
            MessageBox.Show("Yayınevi Başarıyla Kayıt Edildi!", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
