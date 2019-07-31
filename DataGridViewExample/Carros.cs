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
    public partial class Carros : Form
    {
        public Carros()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Carros' table. You can move, or remove it, as needed.
            this.carrosTableAdapter1.Fill(this.querysInnerJoinDataSet1.Carros);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Marcas frmMarcas = new Marcas();
            frmMarcas.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Usuarios frmUsuarios = new Usuarios();
            frmUsuarios.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Vendas frmVendas = new Vendas();
            frmVendas.ShowDialog();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Quick watch no sender para achar o endereço da var;
            //((System.Windows.Forms.DataGridViewRow)
            //(new System.Linq.SystemCore_Enumerable(((System.Windows.Forms.DataGridView)sender).Rows).Items[0])).DataBoundItem
            var CarSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as DataGridViewExample.QuerysInnerJoinDataSet1.CarrosRow;

            //Permite deletar o Ativo(no caso dar Update = 0);
            this.carrosTableAdapter.DeleteQuery(CarSelect.Id);
            dataGridView1.Refresh();
            this.carrosTableAdapter.CustomQuery(querysInnerJoinDataSet1.Carros);
        }
    }
}