using DataGridViewExample.Edicao;
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
    public partial class Marcas : Form
    {
        public Marcas()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        { 
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Marcas' table. You can move, or remove it, as needed.
            this.marcasTableAdapter.CustomQuery(this.querysInnerJoinDataSet1.Marcas);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var marcasSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as DataGridViewExample.QuerysInnerJoinDataSet1.MarcasRow;

            switch (e.ColumnIndex)
            {
                //Coluna deletar
                case 0:
                    {//Permite deletar o Ativo(no caso dar Update = 0);
                        this.marcasTableAdapter.DeleteQuery(marcasSelect.Id);
                    }
                    break;
                case 1:
                    {
                        frmEdicaoMarcas editMarca = new frmEdicaoMarcas();
                        editMarca.MarcasRow = marcasSelect;
                        editMarca.ShowDialog();

                        // Esse não precisa criar query, pois ele da update em tudo.
                        this.marcasTableAdapter.Update(editMarca.MarcasRow);
                    }
                    break;

            }

            this.marcasTableAdapter.CustomQuery(querysInnerJoinDataSet1.Marcas);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MarcasInativas lixoMarcas = new MarcasInativas();
            lixoMarcas.ShowDialog();
        }
    }
}
