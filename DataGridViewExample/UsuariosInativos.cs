﻿using System;
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
    public partial class UsuariosInativos : Form
    {
        public UsuariosInativos()
        {
            InitializeComponent();
        }

        private void UsuariosInativos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'querysInnerJoinDataSet1.Usuarios' table. You can move, or remove it, as needed.
            this.usuariosTableAdapter.CustomInativos(this.querysInnerJoinDataSet1.Usuarios);

        }
    }
}
