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
    public partial class EditLocacao : Form
    {
        public EditLocacao()
        {
            InitializeComponent();
        }
        public MVCProject.SistemaBibliotecaDataSet.LocacaoRow LocacaoRow;
        private void Button1_Click(object sender, EventArgs e)
        {
            LocacaoRow.Livro = (int)comboBox1.SelectedValue;
            LocacaoRow.Usuario = (int)comboBox2.SelectedValue;
            LocacaoRow.Tipo = (int)comboBox3.SelectedValue;
            LocacaoRow.Devolucao = dateTimePicker1.Value;
            this.Close();
        }

        private void EditLocacao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDataSet.Generos' table. You can move, or remove it, as needed.
            this.generosTableAdapter.Fill(this.sistemaBibliotecaDataSet.Generos);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDataSet.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.CustomQuery(this.sistemaBibliotecaDataSet.Usuarios);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDataSet.Livros' table. You can move, or remove it, as needed.
            this.livrosTableAdapter.CustomQuery(this.sistemaBibliotecaDataSet.Livros);
            // TODO: This line of code loads data into the 'sistemaBibliotecaDataSet.Locacao' table. You can move, or remove it, as needed.
            this.locacaoTableAdapter.CustomQuery(this.sistemaBibliotecaDataSet.Locacao);

        }
    }
}
