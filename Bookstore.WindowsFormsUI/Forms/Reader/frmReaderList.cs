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
    public partial class frmReaderList : Form
    {
        public frmReaderList()
        {
            InitializeComponent();
            _readerService = InstanceFactory.GetInstance<IReaderService>();
        }

        private IReaderService _readerService;
        private void frmReaderList_Load(object sender, EventArgs e)
        {
            GetReader();
        }

        void GetReader()
        {
            gridReader.DataSource = _readerService.GetAll();
        }
    }
}
