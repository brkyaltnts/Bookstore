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
    public partial class frmPublisherList : Form
    {
        public frmPublisherList()
        {
            InitializeComponent();
            _publisherService = InstanceFactory.GetInstance<IPublisherService>();
        }
        private IPublisherService _publisherService;
        private void frmPublisherList_Load(object sender, EventArgs e)
        {
            GetPublisher();
        }

        void GetPublisher()
        {
            gridPublisher.DataSource = _publisherService.GetAll();

            gridPublisher.Columns[0].Visible = false;

            gridPublisher.Columns[1].HeaderText = "Yayınevi Adı";
            gridPublisher.Columns[2].HeaderText = "Telefon";
            gridPublisher.Columns[3].HeaderText = "Fax";
            gridPublisher.Columns[4].HeaderText = "Email";
            gridPublisher.Columns[5].HeaderText = "Website";
            gridPublisher.Columns[6].HeaderText = "Adres";

        }

        private int _publisherId;
        private void gridPublisher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = gridPublisher.CurrentRow;
            _publisherId = int.Parse(row.Cells[0].Value.ToString());
            txtPublisherName.Text = row.Cells[1].Value.ToString();
            txtPhone.Text = row.Cells[2].Value.ToString();
            txtFax.Text = row.Cells[3].Value.ToString();
            txtEmail.Text = row.Cells[4].Value.ToString();
            txtWebsite.Text = row.Cells[5].Value.ToString();
            txtAddress.Text = row.Cells[6].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (gridPublisher.CurrentRow != null)
            {
                DialogResult dialog = MessageBox.Show("Yayınevi Güncellensin Mi?", "Uyarı!", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    _publisherService.Update(new Entities.Concrete.Publisher
                    {
                        Id = _publisherId,
                        PublisherName = txtPublisherName.Text,
                        Phone = txtPhone.Text,
                        Fax = txtFax.Text,
                        Email = txtEmail.Text,
                        Website = txtWebsite.Text,
                        Address = txtAddress.Text
                    });
                    MessageBox.Show("Yayınevi Başarıyla Güncellendi!", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetPublisher();
                }
                else
                {
                    MessageBox.Show("Yayınevi Güncellenmedi!", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridPublisher.CurrentRow != null)
            {
                DialogResult dialog = MessageBox.Show("Yayınevi Silinsin Mi?", "Uyarı!", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    _publisherService.Delete(new Entities.Concrete.Publisher
                    {
                        Id = _publisherId
                    });
                    MessageBox.Show("Yayınevi Başarıyla Silindi!", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetPublisher();
                }
                else
                {
                    MessageBox.Show("Yayınevi Silinmedi!", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
