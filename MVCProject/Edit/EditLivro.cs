using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.Edit
{
    public partial class EditLivro : Form
    {
        public EditLivro()
        {
            InitializeComponent();
        }
        public MVCProject.SistemaBibliotecaDataSet.LivrosRow livrosRow;

        private void Button1_Click(object sender, EventArgs e)
        {
            livrosRow.Registro = (int)numericUpDown1.Value;
            livrosRow.Titulo = textBox2.Text;
            livrosRow.Isbn = textBox3.Text;
            livrosRow.Genero = (int)comboBox1.SelectedValue;
            livrosRow.Editora = (int)comboBox1.SelectedValue;
            livrosRow.Sinopse = textBox4.Text;
            livrosRow.Observacoes = textBox5.Text;

            this.Close();
        }

        private void EditLivro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDataSet.Generos' table. You can move, or remove it, as needed.
            this.generosTableAdapter.Fill(this.sistemaBibliotecaDataSet.Generos);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDataSet.Editoras' table. You can move, or remove it, as needed.
            this.editorasTableAdapter.Fill(this.sistemaBibliotecaDataSet.Editoras);

        }
    }
}
