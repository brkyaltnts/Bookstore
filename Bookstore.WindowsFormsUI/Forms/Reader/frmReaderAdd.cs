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

namespace Bookstore.WindowsFormsUI.Forms.Reader
{
    public partial class frmReaderAdd : Form
    {
        public frmReaderAdd()
        {
            InitializeComponent();
            _readerService = InstanceFactory.GetInstance<IReaderService>();
        }

        private IReaderService _readerService;
        private void btnSave_Click(object sender, EventArgs e)
        {
            _readerService.Add(new Entities.Concrete.Reader
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Birthday = DateTime.Parse(txtBirthday.Text),
                Profession = txtProfession.Text,
                Phone = txtPhone.Text,
                Email = txtEmail.Text,
                Reference = txtReference.Text,
                Address = txtAddress.Text
            });
            //Referansı varsa Referans kişinin puanı arttırılacak....////
            MessageBox.Show("Okuyucu Başarıyla Kayıt Edildi!", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
