using CadAlunos.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadAlunos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<Classe> Cadastro = new List<Classe>();
        private void Button1_Click(object sender, EventArgs e)
        {
            Formuario FormCad = new Formuario();
            FormCad.ShowDialog();
            Cadastro.Add(FormCad.newCad);

            this.Close();
        }
    }
}
