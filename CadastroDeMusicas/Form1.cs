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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<Musica> music = new List<Musica>();

        private void Button1_Click(object sender, EventArgs e)
        {
            TelaDeCadastro formCad = new TelaDeCadastro();
            formCad.ShowDialog();
            music.Add(formCad.novaMusica);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
