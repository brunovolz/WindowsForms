﻿using MVCProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCProject.Adicionar
{
    public partial class frmAddEditora : Form
    {
        public frmAddEditora()
        {
            InitializeComponent();
        }
        public Editora editoraRow;
        private void Button1_Click(object sender, EventArgs e)
        {
            editoraRow = new Editora
            {
                Nome = textBox1.Text,
                Descricao = textBox2.Text
            };
            this.Close();
        }
    }
}
