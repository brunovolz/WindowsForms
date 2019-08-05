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
    public partial class EditUsuario : Form
    {
        public EditUsuario()
        {
            InitializeComponent();
        }
        public MVCProject.SistemaBibliotecaDataSet.UsuariosRow usuRow;
        private void Button1_Click(object sender, EventArgs e)
        {
            usuRow.Nome = textBox1.Text;
            usuRow.Login = textBox2.Text;
            usuRow.Senha = textBox3.Text;
            usuRow.Email = textBox4.Text;

            this.Close();
        }

        private void EditUsuario_Load(object sender, EventArgs e)
        {
            
        }
    }
}
