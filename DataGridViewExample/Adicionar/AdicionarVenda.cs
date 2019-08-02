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
    public partial class AdicionarVenda : Form
    {
        public AdicionarVenda()
        {
            InitializeComponent();
        }
        public VendasClass vendasRow;
        private void Button1_Click(object sender, EventArgs e)
        {
            //Converter valor em decimal
            decimal.TryParse(textBox1.Text, out decimal valor);

            vendasRow = new VendasClass
            {
                Carro = (int)comboBox1.SelectedValue,
                Quantidade = (int)numericUpDown1.Value,
                Valor = valor
            };

            this.Close();
        }

        private void AdicionarVenda_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Carros' table. You can move, or remove it, as needed.
            this.carrosTableAdapter.Fill(this.querysInnerJoinDataSet1.Carros);

        }
    }
}
