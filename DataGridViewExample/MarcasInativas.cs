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
    public partial class MarcasInativas : Form
    {
        public MarcasInativas()
        {
            InitializeComponent();
        }

        private void MarcasInativas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Marcas' table. You can move, or remove it, as needed.
            this.marcasTableAdapter.QueryInativos(this.querysInnerJoinDataSet1.Marcas);

        }
    }
}
