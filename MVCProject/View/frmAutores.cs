﻿using MVCProject.Adicionar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.View
{
    public partial class frmAutores : Form
    {
        public frmAutores()
        {
            InitializeComponent();
        }
        public MVCProject.SistemaBibliotecaDataSet.AutoresRow autoresRow;
        private void FrmAutores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sistemaBibliotecaDataSet.Autores' table. You can move, or remove it, as needed.
            this.autoresTableAdapter.Fill(this.sistemaBibliotecaDataSet.Autores);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmAddAutor newAutor = new frmAddAutor();
            newAutor.ShowDialog();
            this.autoresTableAdapter.Insert(
                newAutor.autorRow.Nome,
                newAutor.autorRow.Descricao
                );
            this.autoresTableAdapter.Fill(this.sistemaBibliotecaDataSet.Autores);
        }
    }
}
