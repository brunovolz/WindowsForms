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
    public partial class frmAddGeneroc : Form
    {
        public frmAddGeneroc()
        {
            InitializeComponent();
        }
        public Genero generoRow;
        private void Button1_Click(object sender, EventArgs e)
        {
            generoRow = new Genero
            {
                Tipo = textBox1.Text,
                Descricao = textBox2.Text
            };
            this.Close();
        }
    }
}
