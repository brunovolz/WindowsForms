using CadastroDeMusicas.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroDeMusicas
{
    public partial class TelaDeCadastro : Form
    {
        public TelaDeCadastro()
        {
            InitializeComponent();
        }
        public Musica novaMusica = new Musica();

        private void Button1_Click(object sender, EventArgs e)
        {
            novaMusica.Nome = tbxNome.Text;
            novaMusica.Quantidade = (int)nrQuant.Value;
            novaMusica.Valor = double.Parse(tbxValor.Text);

            this.Close();
        }
    }
}
