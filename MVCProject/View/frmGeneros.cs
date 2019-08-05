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
    public partial class frmGeneros : Form
    {
        public frmGeneros()
        {
            InitializeComponent();
        }
        public MVCProject.SistemaBibliotecaDataSet.GenerosRow generoRow;

        private void FrmGeneros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDataSet.Generos' table. You can move, or remove it, as needed.
            this.generosTableAdapter.Fill(this.sistemaBibliotecaDataSet.Generos);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDataSet.LivroAutor' table. You can move, or remove it, as needed.
            this.livroAutorTableAdapter.Fill(this.sistemaBibliotecaDataSet.LivroAutor);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAddGeneroc newGenero = new frmAddGeneroc();
            newGenero.ShowDialog();
            this.generosTableAdapter.Insert(
                newGenero.generoRow.Tipo,
                newGenero.generoRow.Descricao
                );
            this.generosTableAdapter.Fill(this.sistemaBibliotecaDataSet.Generos);
        }
    }
}
