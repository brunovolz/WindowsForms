using MVCProject.Adicionar;
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
    public partial class frmEditoras : Form
    {
        public frmEditoras()
        {
            InitializeComponent();
        }
        public MVCProject.SistemaBibliotecaDataSet.EditorasRow editoraRow;
        private void FrmEditoras_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDataSet.Editoras' table. You can move, or remove it, as needed.
            this.editorasTableAdapter.Fill(this.sistemaBibliotecaDataSet.Editoras);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAddEditora newEditora = new frmAddEditora();
            newEditora.ShowDialog();
            this.editorasTableAdapter.Insert(
                newEditora.editoraRow.Nome,
                newEditora.editoraRow.Descricao
                );
            this.editorasTableAdapter.Fill(this.sistemaBibliotecaDataSet.Editoras);
        }
    }
}
