using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bookstore.Entities.Concrete;
using Bookstore.WindowsFormsUI.Author;
using Bookstore.WindowsFormsUI.Forms;
using Bookstore.WindowsFormsUI.Forms.Book;
using Bookstore.WindowsFormsUI.Forms.Employee;
using Bookstore.WindowsFormsUI.Forms.Reader;
using Bookstore.WindowsFormsUI.Forms.Type;
using Bookstore.WindowsFormsUI.Publisher;
using DevExpress.XtraBars;
using Type = Bookstore.Entities.Concrete.Type;

namespace Bookstore.WindowsFormsUI
{
    public partial class frmHomePage : Form
    {
        public frmHomePage()
        {
            InitializeComponent();
        }

        private void btnAuthorList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MdiClose();
            Author.frmAuthorList authorList = new frmAuthorList();
            authorList.MdiParent = this;
            authorList.Show();
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        void MdiClose()
        {
            Form[] forms = this.MdiChildren;
            for (int k = 0; k < forms.Length; k++)
            {
                forms[k].Close();
            }
        }

        private void btnAuthorAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MdiClose();
            Author.frmAuthorAdd authorAdd = new frmAuthorAdd();
            authorAdd.MdiParent = this;
            authorAdd.Show();
        }

        private void btnMaximized_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnPublisherList_ItemClick(object sender, ItemClickEventArgs e)
        {
            MdiClose();
            Publisher.frmPublisherList publisherList = new frmPublisherList();
            publisherList.MdiParent = this;
            publisherList.Show();
        }

        private void btnPublisherAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            MdiClose();
            Publisher.frmPublisherAdd publisherAdd = new frmPublisherAdd();
            publisherAdd.MdiParent = this;
            publisherAdd.Show();
        }

        private void btnTypeList_ItemClick(object sender, ItemClickEventArgs e)
        {
            MdiClose();
            Forms.Type.frmTypeList typeList = new frmTypeList();
            typeList.MdiParent = this;
            typeList.Show();
        }

        private void btnTypeAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            MdiClose();
            Forms.Type.frmTypeAdd typeAdd = new frmTypeAdd();
            typeAdd.MdiParent = this;
            typeAdd.Show();
        }

        private void btnEmployeeList_ItemClick(object sender, ItemClickEventArgs e)
        {
            MdiClose();
            Forms.Employee.frmEmployeeList employeeList = new frmEmployeeList();
            employeeList.MdiParent = this;
            employeeList.Show();
        }

        private void btnEmployeeAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            MdiClose();
            Forms.Employee.frmEmployeeAdd employeeAdd = new frmEmployeeAdd();
            employeeAdd.MdiParent = this;
            employeeAdd.Show();
        }

        private void btnCalculator_ItemClick(object sender, ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void btnExcel_ItemClick(object sender, ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }

        private void btnWord_ItemClick(object sender, ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void btnReaderList_ItemClick(object sender, ItemClickEventArgs e)
        {
            MdiClose();
            Forms.Reader.frmReaderList readerList = new frmReaderList();
            readerList.MdiParent = this;
            readerList.Show();
        }

        private void btnReaderAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            MdiClose();
            Forms.Reader.frmReaderAdd readerAdd = new frmReaderAdd();
            readerAdd.MdiParent = this;
            readerAdd.Show();
        }

        private void btnBookAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            MdiClose();
            Forms.Book.frmBookAdd bookAdd = new frmBookAdd();
            bookAdd.MdiParent = this;
            bookAdd.Show();
        }

        private void btnBookSell_ItemClick(object sender, ItemClickEventArgs e)
        {
            MdiClose();
            Forms.frmBookSell bookSell = new frmBookSell();
            bookSell.MdiParent = this;
            bookSell.Show();
        }
    }
}
