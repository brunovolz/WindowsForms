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
    public partial class frmAddUsu : Form
    {
        public frmAddUsu()
        {
            InitializeComponent();
        }
        public UsuarioClass usuRow;

        private void Button1_Click(object sender, EventArgs e)
        {
            usuRow = new UsuarioClass
            {
                Nome = textBox1.Text,
                Login = textBox3.Text,
                Senha = textBox4.Text,
                Email = textBox2.Text
            };

            this.Close();
        }
    }
}
