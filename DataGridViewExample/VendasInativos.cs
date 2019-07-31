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
    public partial class VendasInativos : Form
    {
        public VendasInativos()
        {
            InitializeComponent();
        }

        private void VendasInativos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Vendas' table. You can move, or remove it, as needed.
            this.vendasTableAdapter.CustomInativos(this.querysInnerJoinDataSet1.Vendas);

        }
    }
}
