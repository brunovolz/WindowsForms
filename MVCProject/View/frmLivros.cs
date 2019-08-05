using MVCProject.Adicionar;
using MVCProject.Edit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View
{
    public partial class frmLivros : Form
    {
        public frmLivros()
        {
            InitializeComponent();
        }
        public MVCProject.SistemaBibliotecaDataSet.LivrosRow livroRow;
        private void FrmLivros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDataSet.Livros' table. You can move, or remove it, as needed.
            this.livrosTableAdapter.CustomQuery(this.sistemaBibliotecaDataSet.Livros);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAddLivro newLivro = new frmAddLivro();
            newLivro.ShowDialog();
            this.livrosTableAdapter.Insert(
                newLivro.livroRow.Registro,
                newLivro.livroRow.Titulo,
                newLivro.livroRow.Isbn,
                newLivro.livroRow.Genero,
                newLivro.livroRow.Editora,
                newLivro.livroRow.Sinopse,
                newLivro.livroRow.Observacoes,
                true,
                1,
                1,
                DateTime.Now,
                DateTime.Now
                );
            this.livrosTableAdapter.CustomQuery(this.sistemaBibliotecaDataSet.Livros);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var livroSelect = ((System.Data.DataRowView)
                            this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                            as MVCProject.SistemaBibliotecaDataSet.LivrosRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        this.livrosTableAdapter.DeleteQuery(livroSelect.Id);
                    }
                    break;
                case 1:
                    {
                        EditLivro newLivro = new EditLivro();
                        newLivro.livrosRow = livroSelect;
                        newLivro.ShowDialog();
                        this.livrosTableAdapter.Update(newLivro.livrosRow);
                    }
                    break;
            }

            this.livrosTableAdapter.CustomQuery(sistemaBibliotecaDataSet.Livros);
        }
    }
}
