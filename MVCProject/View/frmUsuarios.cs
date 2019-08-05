using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVCProject.Adicionar;
using MVCProject.Edit;

namespace MVCProject.View
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }
        public MVCProject.SistemaBibliotecaDataSet.UsuariosRow usuarioRow;

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDataSet.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.CustomQuery(this.sistemaBibliotecaDataSet.Usuarios);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAddUsu newUsu = new frmAddUsu();
            newUsu.ShowDialog();
            this.usuariosTableAdapter.Insert(
                newUsu.usuRow.Nome,
                newUsu.usuRow.Login,
                newUsu.usuRow.Senha,
                newUsu.usuRow.Email,
                true,
                1,
                1,
                DateTime.Now,
                DateTime.Now
                );
            this.usuariosTableAdapter.CustomQuery(this.sistemaBibliotecaDataSet.Usuarios);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var usuSelect = ((System.Data.DataRowView)
                this.dataGridView1.Rows[e.RowIndex].DataBoundItem).Row
                as MVCProject.SistemaBibliotecaDataSet.UsuariosRow;

            switch (e.ColumnIndex)
            {
                case 0:
                    {
                        this.usuariosTableAdapter.DeleteQuery(usuSelect.Id);
                    }
                    break;
                case 1:
                    {
                        EditUsuario newUser = new EditUsuario();
                        newUser.usuRow = usuSelect;
                        newUser.ShowDialog();
                        this.usuariosTableAdapter.Update(newUser.usuRow);
                    }
                    break;
            }

            this.usuariosTableAdapter.CustomQuery(sistemaBibliotecaDataSet.Usuarios);
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
