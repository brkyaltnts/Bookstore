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
using Bookstore.Entities.Concrete;

namespace Bookstore.WindowsFormsUI.Forms
{
    public partial class frmBookSell : Form
    {
        public frmBookSell()
        {
            InitializeComponent();
            _bookService = InstanceFactory.GetInstance<IBookService>();
            _employeeService = InstanceFactory.GetInstance<IEmployeeService>();
            _readerService = InstanceFactory.GetInstance<IReaderService>();
            _saleService = InstanceFactory.GetInstance<ISaleService>();
        }

        private IBookService _bookService;
        private IEmployeeService _employeeService;
        private IReaderService _readerService;
        private ISaleService _saleService;
        private void frmBookSell_Load(object sender, EventArgs e)
        {
            GetBook();
            GetEmployee();
            GetReader();
            
        }

        private void ReaderControl()
        {
            if (chkControl.Checked)
            {
                txtFirstName.Enabled = true;
                txtLastName.Enabled = true;
                txtEmail.Enabled = true;
                txtPhone.Enabled = true;

                lblFirstName.Enabled = true;
                lblLastName.Enabled = true;
                lblEmail.Enabled = true;
                lblPhone.Enabled = true;

                lblReader.Enabled = false;
                cmbReader.Enabled = false;
            }
            else
            {
                txtFirstName.Enabled = false;
                txtLastName.Enabled = false;
                txtEmail.Enabled = false;
                txtPhone.Enabled = false;

                lblFirstName.Enabled = false;
                lblLastName.Enabled = false;
                lblEmail.Enabled = false;
                lblPhone.Enabled = false;

                lblReader.Enabled = true;
                cmbReader.Enabled = true;
            }
        }

        void GetBook()
        {
            cmbBook.DataSource = _bookService.GetAll();
            cmbBook.ValueMember = "Id";
            cmbBook.DisplayMember = "BookName";
        }

        void GetEmployee()
        {
            cmbEmployee.DataSource = _employeeService.GetAll();
            cmbEmployee.ValueMember = "Id";
            cmbEmployee.DisplayMember = "FirstName";
        }

        void GetReader()
        {
            cmbReader.DataSource = _readerService.GetAll();
            cmbReader.ValueMember = "Id";
            cmbReader.DisplayMember = "FirstName" + "LastName";
        }

        private void chkControl_CheckedChanged(object sender, EventArgs e)
        {
            ReaderControl();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (chkControl.Checked)
            {
                NotReader();
            }
            else
            {
                Reader();
            }
        }

        void Reader()
        {
            _saleService.Add(new Sale
            {
                BookId = Convert.ToInt32(cmbBook.SelectedValue),
                PersonId = Convert.ToInt32(cmbEmployee.SelectedValue),
                ReaderId = Convert.ToInt32(cmbReader.SelectedValue),
                SellDate = DateTime.Today
            });
            MessageBox.Show("Kitap Başarıyla Satılmıştır!", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        void NotReader()
        {
            _saleService.Add(new Sale
            {
                BookId = Convert.ToInt32(cmbBook.SelectedValue),
                PersonId = Convert.ToInt32(cmbEmployee.SelectedValue),
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Phone = txtPhone.Text,
                Email = txtEmail.Text,
                SellDate = DateTime.Today
            });
            MessageBox.Show("Kitap Başarıyla Satılmıştır!", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
