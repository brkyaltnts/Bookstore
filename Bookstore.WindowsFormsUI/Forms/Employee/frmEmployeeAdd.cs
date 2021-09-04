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

namespace Bookstore.WindowsFormsUI.Forms.Employee
{
    public partial class frmEmployeeAdd : Form
    {
        public frmEmployeeAdd()
        {
            InitializeComponent();
            _employeeService = InstanceFactory.GetInstance<IEmployeeService>();
        }

        private IEmployeeService _employeeService;
        private void btnSave_Click(object sender, EventArgs e)
        {
            _employeeService.Add(new Entities.Concrete.Employee
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Birthday = DateTime.Parse(txtBirthday.Text),
                Phone = txtPhone.Text,
                Email = txtEmail.Text,
                Address = txtAddress.Text
            });
            MessageBox.Show("Personel Başarıyla Kayıt Edildi!", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
