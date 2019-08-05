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

namespace MVCProject.Adicionar
{
    public partial class frmAddLocacao : Form
    {
        public frmAddLocacao()
        {
            InitializeComponent();
        }

        public Locacao locacaoRow;
        private void FrmAddLocacao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDataSet.Generos' table. You can move, or remove it, as needed.
            this.generosTableAdapter.Fill(this.sistemaBibliotecaDataSet.Generos);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDataSet.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.CustomQuery(this.sistemaBibliotecaDataSet.Usuarios);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDataSet.Livros' table. You can move, or remove it, as needed.
            this.livrosTableAdapter.CustomQuery(this.sistemaBibliotecaDataSet.Livros);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            locacaoRow = new Locacao
            {
                Livro = (int)comboBox1.SelectedValue,
                Usuario = (int)comboBox2.SelectedValue,
                Tipo = (int)comboBox3.SelectedValue,
                Devolucao = dateTimePicker1.Value
            };
            this.Close();
        }
    }
}
