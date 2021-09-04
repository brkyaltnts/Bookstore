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
    public partial class frmEmployeeList : Form
    {
        public frmEmployeeList()
        {
            InitializeComponent();
            _employeeService = InstanceFactory.GetInstance<IEmployeeService>();
        }

        private IEmployeeService _employeeService;
        private void frmEmployeeList_Load(object sender, EventArgs e)
        {
            GetEmployee();
        }

        void GetEmployee()
        {
            gridEmployee.DataSource = _employeeService.GetAll();

            gridEmployee.Columns[0].Visible = false;
            gridEmployee.Columns[1].HeaderText = "Adı";
            gridEmployee.Columns[2].HeaderText = "Soyadı";
            gridEmployee.Columns[3].HeaderText = "Doğum Tarihi";
            gridEmployee.Columns[4].HeaderText = "Telefon";
            gridEmployee.Columns[5].HeaderText = "Email";
            gridEmployee.Columns[6].HeaderText = "Adres";
        }

        private int _employeeId;
        private void gridEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = gridEmployee.CurrentRow;
            _employeeId = int.Parse(row.Cells[0].Value.ToString());
            txtFirstName.Text = row.Cells[1].Value.ToString();
            txtLastName.Text = row.Cells[2].Value.ToString();
            txtBirthday.Text = row.Cells[3].Value.ToString();
            txtPhone.Text = row.Cells[4].Value.ToString();
            txtEmail.Text = row.Cells[5].Value.ToString();
            txtAddress.Text = row.Cells[6].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (gridEmployee.CurrentRow != null)
            {
                DialogResult dialog = MessageBox.Show("Personel Güncellensin Mi?", "Uyarı!", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    _employeeService.Update(new Entities.Concrete.Employee
                    {
                        Id = _employeeId,
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        Birthday = DateTime.Parse(txtBirthday.Text),
                        Phone = txtPhone.Text,
                        Email = txtEmail.Text,
                        Address = txtAddress.Text
                    }); MessageBox.Show("Personel Başarıyla Güncellendi!", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetEmployee();
                }
                else
                {
                    MessageBox.Show("Personel Güncellenmedi!", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridEmployee.CurrentRow != null)
            {
                DialogResult dialog = MessageBox.Show("Personel Silinsin Mi?", "Uyarı!", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    _employeeService.Delete(new Entities.Concrete.Employee
                    {
                        Id = _employeeId,
                    }); MessageBox.Show("Personel Başarıyla Silindi!", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetEmployee();
                }
                else
                {
                    MessageBox.Show("Personel Silinmedi!", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
