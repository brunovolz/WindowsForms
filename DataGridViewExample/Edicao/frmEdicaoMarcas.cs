using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridViewExample.Edicao
{
    public partial class frmEdicaoMarcas : Form
    {
        public frmEdicaoMarcas()
        {
            InitializeComponent();
        }

        public DataGridViewExample.QuerysInnerJoinDataSet1.MarcasRow MarcasRow;

        private void FrmEdicaoMarcas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Marcas' table. You can move, or remove it, as needed.
            this.marcasTableAdapter.FillBy(this.querysInnerJoinDataSet1.Marcas);

            textBox1.Text = MarcasRow.Nome;

            this.Close();
        }

        private void FillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.marcasTableAdapter.FillBy(this.querysInnerJoinDataSet1.Marcas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            MarcasRow.Nome = textBox1.Text;

            this.Close();
        }

        private void FillBy1ToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("INSIRA UM NOME!!!!!!","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                textBox1.Focus();
            }
        }
    }
}
