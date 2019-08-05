using MVCProject.Adicionar;
using MVCProject.Edit;
using MVCProject.Model;
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
    public partial class frmLocacoes : Form
    {
        public frmLocacoes()
        {
            InitializeComponent();
        }
        public MVCProject.SistemaBibliotecaDataSet.LocacaoRow locaRow;
        private void FrmLocacoes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDataSet.Locacao' table. You can move, or remove it, as needed.
            this.locacaoTableAdapter.CustomQuery(this.sistemaBibliotecaDataSet.Locacao);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAddLocacao newLocacao = new frmAddLocacao();
            newLocacao.ShowDialog();
            this.locacaoTableAdapter.Insert(
                newLocacao.locacaoRow.Livro,
                newLocacao.locacaoRow.Usuario,
                newLocacao.locacaoRow.Tipo,
                newLocacao.locacaoRow.Devolucao,
                true,
                1,
                1,
                DateTime.Now,
                DateTime.Now
                );
            this.locacaoTableAdapter.CustomQuery(this.sistemaBibliotecaDataSet.Locacao);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var locacaoSelect = ((System.Data.DataRowView)
                            this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                            as MVCProject.SistemaBibliotecaDataSet.LocacaoRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        this.locacaoTableAdapter.DeleteQuery(locacaoSelect.Id);
                    }
                    break;
                case 1:
                    {
                        EditLocacao newLocacao = new EditLocacao();
                        newLocacao.LocacaoRow = locacaoSelect;
                        newLocacao.ShowDialog();
                        this.locacaoTableAdapter.Update(newLocacao.LocacaoRow);
                    }
                    break;
            }

            this.locacaoTableAdapter.CustomQuery(sistemaBibliotecaDataSet.Locacao);
        }
    }
}
