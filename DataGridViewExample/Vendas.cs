using DataGridViewExample.Adicionar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample
{
    public partial class Vendas : Form
    {
        public Vendas()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Vendas' table. You can move, or remove it, as needed.
            this.vendasTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Vendas);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AdicionarVenda AddVenda = new AdicionarVenda();
            AddVenda.ShowDialog();

            if(AddVenda.vendasRow?.Carro > 0
                && AddVenda.vendasRow?.Valor > 0)
            this.vendasTableAdapter.Insert(
                AddVenda.vendasRow.Carro,
                AddVenda.vendasRow.Quantidade,
                AddVenda.vendasRow.Valor,
                true,
                1,
                1,
                DateTime.Now,
                DateTime.Now
                );
            this.vendasTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Vendas);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var vendasSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as DataGridViewExample.QuerysInnerJoinDataSet1.VendasRow;

            this.vendasTableAdapter.DeleteQuery(vendasSelect.Id);
            dataGridView1.Refresh();
            this.vendasTableAdapter.CustomQuery(querysInnerJoinDataSet1.Vendas);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
           VendasInativos lixoVendas = new VendasInativos();
            lixoVendas.ShowDialog();
        }
    }
}
