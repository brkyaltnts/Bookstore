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

namespace Bookstore.WindowsFormsUI.Author
{
    public partial class frmAuthorAdd : Form
    {
        public frmAuthorAdd()
        {
            InitializeComponent();
            _authorService = InstanceFactory.GetInstance<IAuthorService>();
        }

        private IAuthorService _authorService;
        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                _authorService.Add(new Entities.Concrete.Author
                {
                    AuthorName = txtAuthorName.Text,
                    Biography = txtBiography.Text
                });
                MessageBox.Show("Yazar Başarıyla Kayıt Edildi!","Bilgilendirme!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
