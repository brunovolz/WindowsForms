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
    public partial class frmAddLivro : Form
    {
        public frmAddLivro()
        {
            InitializeComponent();
        }
        public Livro livroRow;
        private void FrmAddLivro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDataSet.Editoras' table. You can move, or remove it, as needed.
            this.editorasTableAdapter.Fill(this.sistemaBibliotecaDataSet.Editoras);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDataSet.Generos' table. You can move, or remove it, as needed.
            this.generosTableAdapter.Fill(this.sistemaBibliotecaDataSet.Generos);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            livroRow = new Livro
            {
                Registro = (int)numericUpDown1.Value,
                Titulo = textBox2.Text,
                Isbn = textBox3.Text,
                Genero = (int)comboBox1.SelectedValue,
                Editora = (int)comboBox1.SelectedValue,
                Sinopse = textBox4.Text,
                Observacoes = textBox5.Text
            };
            this.Close();
        }
    }
}
