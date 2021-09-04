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

namespace Bookstore.WindowsFormsUI.Forms.Book
{
    public partial class frmBookAdd : Form
    {
        public frmBookAdd()
        {
            InitializeComponent();
            _authorService = InstanceFactory.GetInstance<IAuthorService>();
            _publisherService = InstanceFactory.GetInstance<IPublisherService>();
            _typeService = InstanceFactory.GetInstance<ITypeService>();
            _bookService = InstanceFactory.GetInstance<IBookService>();
        }

        private IAuthorService _authorService;
        private IPublisherService _publisherService;
        private ITypeService _typeService;
        private IBookService _bookService;

        private void frmBookAdd_Load(object sender, EventArgs e)
        {
            GetAuthor();
            GetPublisher();
            GetType();
        }

        void GetAuthor()
        {
            cmbAuthor.DataSource = _authorService.GetAll();
            cmbAuthor.ValueMember = "Id";
            cmbAuthor.DisplayMember = "AuthorName";
        }

        void GetPublisher()
        {
            cmbPublisher.DataSource = _publisherService.GetAll();
            cmbPublisher.ValueMember = "Id";
            cmbPublisher.DisplayMember = "PublisherName";
        }

        void GetType()
        {
            cmbType.DataSource = _typeService.GetAll();
            cmbType.ValueMember = "Id";
            cmbType.DisplayMember = "TypeName";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _bookService.Add(new Entities.Concrete.Book
            {
                AuthorId = Convert.ToInt32(cmbAuthor.SelectedValue),
                PublisherId = Convert.ToInt32(cmbPublisher.SelectedValue),
                TypeId = Convert.ToInt32(cmbType.SelectedValue),
                ISBN = txtISBN.Text,
                BookName = txtBookName.Text,
                Edition = txtEdition.Text,
                Page = txtPage.Text,
                CoverType = cmbCoverType.Text,
                //StockAmount = Convert.ToInt32(txtStockAmount.Text),
                Price = Convert.ToDecimal(txtPrice.Text),
                Summary = txtSummary.Text
            });
            MessageBox.Show("Kitap Başarıyla Kayıt Edildi!", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
