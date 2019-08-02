using DataGridViewExample.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample.Adicionar
{
    public partial class AdicionarMarca : Form
    {
        public AdicionarMarca()
        {
            InitializeComponent();
        }
        public  MarcaClass marcaRow;

        private void Button1_Click(object sender, EventArgs e)
        {
            marcaRow = new MarcaClass
            {
                Nome = textBox01.Text 
            };
            this.Close();
        }
    }
}
