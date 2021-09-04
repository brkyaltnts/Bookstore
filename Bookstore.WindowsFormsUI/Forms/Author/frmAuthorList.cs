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
    public partial class frmAuthorList : Form
    {
        public frmAuthorList()
        {
            InitializeComponent();
            _authorService = InstanceFactory.GetInstance<IAuthorService>();
        }

        private IAuthorService _authorService;
        private void frmAuthorList_Load(object sender, EventArgs e)
        {
            GetAuthor();
        }

        private void GetAuthor()
        {
            gridAuthor.DataSource = _authorService.GetAll();
            gridAuthor.Columns[0].Visible = false;

            gridAuthor.Columns[1].HeaderText = "Yazar Adı";
            gridAuthor.Columns[2].HeaderText = "Biyografi";

        }

        private int _authorId;
        private void gridAuthor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = gridAuthor.CurrentRow;
            _authorId = int.Parse(row.Cells[0].Value.ToString());
            txtAuthorName.Text = row.Cells[1].Value.ToString();
            txtBiography.Text = row.Cells[2].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (gridAuthor.CurrentRow != null)
            {
                DialogResult dialog = MessageBox.Show("Yazar Güncellensin Mi?", "Uyarı!", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    _authorService.Update(new Entities.Concrete.Author
                    {
                        Id = _authorId,
                        AuthorName = txtAuthorName.Text,
                        Biography = txtBiography.Text
                    });
                    MessageBox.Show("Yazar Başarıyla Güncellendi!", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetAuthor();
                }
                else
                {
                    MessageBox.Show("Yazar Güncellenmedi!", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridAuthor.CurrentRow != null)
            {
                DialogResult dialog = MessageBox.Show("Yazar Silinsin Mi?", "Uyarı!", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    _authorService.Delete(new Entities.Concrete.Author
                    {
                        Id = _authorId
                    });
                    MessageBox.Show("Yazar Başarıyla Silindi!", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetAuthor();
                }
                else
                {
                    MessageBox.Show("Yazar Silinmedi", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetAuthor();
        }
    }
}
