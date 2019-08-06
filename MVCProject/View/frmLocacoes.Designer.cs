namespace MVCProject.View
{
    partial class frmLocacoes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.deletarDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.editarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.livroDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.livroTituloDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generosTipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioNomeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devolucaoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativoDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.usuIncDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuAltDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datIncDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datAltDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locacaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaBibliotecaDataSet = new MVCProject.SistemaBibliotecaDataSet();
            this.Deletar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.livroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.devolucaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ativoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.usuIncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuAltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datIncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datAltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deletarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.livroTituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.livroDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioNomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locacaoTableAdapter = new MVCProject.SistemaBibliotecaDataSetTableAdapters.LocacaoTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locacaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBibliotecaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deletarDataGridViewTextBoxColumn1,
            this.editarDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn2,
            this.livroDataGridViewTextBoxColumn2,
            this.livroTituloDataGridViewTextBoxColumn1,
            this.generosTipoDataGridViewTextBoxColumn,
            this.usuarioNomeDataGridViewTextBoxColumn1,
            this.usuarioDataGridViewTextBoxColumn2,
            this.tipoDataGridViewTextBoxColumn1,
            this.devolucaoDataGridViewTextBoxColumn1,
            this.ativoDataGridViewCheckBoxColumn1,
            this.usuIncDataGridViewTextBoxColumn1,
            this.usuAltDataGridViewTextBoxColumn1,
            this.datIncDataGridViewTextBoxColumn1,
            this.datAltDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.locacaoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-2, -3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(925, 173);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // deletarDataGridViewTextBoxColumn1
            // 
            this.deletarDataGridViewTextBoxColumn1.DataPropertyName = "Deletar";
            this.deletarDataGridViewTextBoxColumn1.HeaderText = "Deletar";
            this.deletarDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.deletarDataGridViewTextBoxColumn1.Name = "deletarDataGridViewTextBoxColumn1";
            this.deletarDataGridViewTextBoxColumn1.ReadOnly = true;
            this.deletarDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.deletarDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.deletarDataGridViewTextBoxColumn1.Width = 125;
            // 
            // editarDataGridViewTextBoxColumn
            // 
            this.editarDataGridViewTextBoxColumn.DataPropertyName = "Editar";
            this.editarDataGridViewTextBoxColumn.HeaderText = "Editar";
            this.editarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.editarDataGridViewTextBoxColumn.Name = "editarDataGridViewTextBoxColumn";
            this.editarDataGridViewTextBoxColumn.ReadOnly = true;
            this.editarDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.editarDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.editarDataGridViewTextBoxColumn.Width = 125;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            this.idDataGridViewTextBoxColumn2.Width = 125;
            // 
            // livroDataGridViewTextBoxColumn2
            // 
            this.livroDataGridViewTextBoxColumn2.DataPropertyName = "Livro";
            this.livroDataGridViewTextBoxColumn2.HeaderText = "Livro";
            this.livroDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.livroDataGridViewTextBoxColumn2.Name = "livroDataGridViewTextBoxColumn2";
            this.livroDataGridViewTextBoxColumn2.ReadOnly = true;
            this.livroDataGridViewTextBoxColumn2.Visible = false;
            this.livroDataGridViewTextBoxColumn2.Width = 125;
            // 
            // livroTituloDataGridViewTextBoxColumn1
            // 
            this.livroTituloDataGridViewTextBoxColumn1.DataPropertyName = "Livro.Titulo";
            this.livroTituloDataGridViewTextBoxColumn1.HeaderText = "Livro.Titulo";
            this.livroTituloDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.livroTituloDataGridViewTextBoxColumn1.Name = "livroTituloDataGridViewTextBoxColumn1";
            this.livroTituloDataGridViewTextBoxColumn1.ReadOnly = true;
            this.livroTituloDataGridViewTextBoxColumn1.Width = 125;
            // 
            // generosTipoDataGridViewTextBoxColumn
            // 
            this.generosTipoDataGridViewTextBoxColumn.DataPropertyName = "Generos.Tipo";
            this.generosTipoDataGridViewTextBoxColumn.HeaderText = "Generos.Tipo";
            this.generosTipoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.generosTipoDataGridViewTextBoxColumn.Name = "generosTipoDataGridViewTextBoxColumn";
            this.generosTipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.generosTipoDataGridViewTextBoxColumn.Width = 125;
            // 
            // usuarioNomeDataGridViewTextBoxColumn1
            // 
            this.usuarioNomeDataGridViewTextBoxColumn1.DataPropertyName = "Usuario.Nome";
            this.usuarioNomeDataGridViewTextBoxColumn1.HeaderText = "Usuario.Nome";
            this.usuarioNomeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.usuarioNomeDataGridViewTextBoxColumn1.Name = "usuarioNomeDataGridViewTextBoxColumn1";
            this.usuarioNomeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.usuarioNomeDataGridViewTextBoxColumn1.Width = 125;
            // 
            // usuarioDataGridViewTextBoxColumn2
            // 
            this.usuarioDataGridViewTextBoxColumn2.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn2.HeaderText = "Usuario";
            this.usuarioDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.usuarioDataGridViewTextBoxColumn2.Name = "usuarioDataGridViewTextBoxColumn2";
            this.usuarioDataGridViewTextBoxColumn2.ReadOnly = true;
            this.usuarioDataGridViewTextBoxColumn2.Visible = false;
            this.usuarioDataGridViewTextBoxColumn2.Width = 125;
            // 
            // tipoDataGridViewTextBoxColumn1
            // 
            this.tipoDataGridViewTextBoxColumn1.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn1.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.tipoDataGridViewTextBoxColumn1.Name = "tipoDataGridViewTextBoxColumn1";
            this.tipoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.tipoDataGridViewTextBoxColumn1.Visible = false;
            this.tipoDataGridViewTextBoxColumn1.Width = 125;
            // 
            // devolucaoDataGridViewTextBoxColumn1
            // 
            this.devolucaoDataGridViewTextBoxColumn1.DataPropertyName = "Devolucao";
            this.devolucaoDataGridViewTextBoxColumn1.HeaderText = "Devolucao";
            this.devolucaoDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.devolucaoDataGridViewTextBoxColumn1.Name = "devolucaoDataGridViewTextBoxColumn1";
            this.devolucaoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.devolucaoDataGridViewTextBoxColumn1.Width = 125;
            // 
            // ativoDataGridViewCheckBoxColumn1
            // 
            this.ativoDataGridViewCheckBoxColumn1.DataPropertyName = "Ativo";
            this.ativoDataGridViewCheckBoxColumn1.HeaderText = "Ativo";
            this.ativoDataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.ativoDataGridViewCheckBoxColumn1.Name = "ativoDataGridViewCheckBoxColumn1";
            this.ativoDataGridViewCheckBoxColumn1.ReadOnly = true;
            this.ativoDataGridViewCheckBoxColumn1.Width = 125;
            // 
            // usuIncDataGridViewTextBoxColumn1
            // 
            this.usuIncDataGridViewTextBoxColumn1.DataPropertyName = "UsuInc";
            this.usuIncDataGridViewTextBoxColumn1.HeaderText = "UsuInc";
            this.usuIncDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.usuIncDataGridViewTextBoxColumn1.Name = "usuIncDataGridViewTextBoxColumn1";
            this.usuIncDataGridViewTextBoxColumn1.ReadOnly = true;
            this.usuIncDataGridViewTextBoxColumn1.Width = 125;
            // 
            // usuAltDataGridViewTextBoxColumn1
            // 
            this.usuAltDataGridViewTextBoxColumn1.DataPropertyName = "UsuAlt";
            this.usuAltDataGridViewTextBoxColumn1.HeaderText = "UsuAlt";
            this.usuAltDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.usuAltDataGridViewTextBoxColumn1.Name = "usuAltDataGridViewTextBoxColumn1";
            this.usuAltDataGridViewTextBoxColumn1.ReadOnly = true;
            this.usuAltDataGridViewTextBoxColumn1.Width = 125;
            // 
            // datIncDataGridViewTextBoxColumn1
            // 
            this.datIncDataGridViewTextBoxColumn1.DataPropertyName = "DatInc";
            this.datIncDataGridViewTextBoxColumn1.HeaderText = "DatInc";
            this.datIncDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.datIncDataGridViewTextBoxColumn1.Name = "datIncDataGridViewTextBoxColumn1";
            this.datIncDataGridViewTextBoxColumn1.ReadOnly = true;
            this.datIncDataGridViewTextBoxColumn1.Width = 125;
            // 
            // datAltDataGridViewTextBoxColumn1
            // 
            this.datAltDataGridViewTextBoxColumn1.DataPropertyName = "DatAlt";
            this.datAltDataGridViewTextBoxColumn1.HeaderText = "DatAlt";
            this.datAltDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.datAltDataGridViewTextBoxColumn1.Name = "datAltDataGridViewTextBoxColumn1";
            this.datAltDataGridViewTextBoxColumn1.ReadOnly = true;
            this.datAltDataGridViewTextBoxColumn1.Width = 125;
            // 
            // locacaoBindingSource
            // 
            this.locacaoBindingSource.DataMember = "Locacao";
            this.locacaoBindingSource.DataSource = this.sistemaBibliotecaDataSet;
            // 
            // sistemaBibliotecaDataSet
            // 
            this.sistemaBibliotecaDataSet.DataSetName = "SistemaBibliotecaDataSet";
            this.sistemaBibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Deletar
            // 
            this.Deletar.DataPropertyName = "Deletar";
            this.Deletar.HeaderText = "Deletar";
            this.Deletar.MinimumWidth = 6;
            this.Deletar.Name = "Deletar";
            this.Deletar.ReadOnly = true;
            this.Deletar.Width = 125;
            // 
            // Editar
            // 
            this.Editar.DataPropertyName = "Id";
            this.Editar.HeaderText = "Editar";
            this.Editar.MinimumWidth = 6;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Width = 125;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // livroDataGridViewTextBoxColumn
            // 
            this.livroDataGridViewTextBoxColumn.DataPropertyName = "Livro";
            this.livroDataGridViewTextBoxColumn.HeaderText = "Livro";
            this.livroDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.livroDataGridViewTextBoxColumn.Name = "livroDataGridViewTextBoxColumn";
            this.livroDataGridViewTextBoxColumn.ReadOnly = true;
            this.livroDataGridViewTextBoxColumn.Width = 125;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.usuarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoDataGridViewTextBoxColumn.Width = 125;
            // 
            // devolucaoDataGridViewTextBoxColumn
            // 
            this.devolucaoDataGridViewTextBoxColumn.DataPropertyName = "Devolucao";
            this.devolucaoDataGridViewTextBoxColumn.HeaderText = "Devolucao";
            this.devolucaoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.devolucaoDataGridViewTextBoxColumn.Name = "devolucaoDataGridViewTextBoxColumn";
            this.devolucaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.devolucaoDataGridViewTextBoxColumn.Width = 125;
            // 
            // ativoDataGridViewCheckBoxColumn
            // 
            this.ativoDataGridViewCheckBoxColumn.DataPropertyName = "Ativo";
            this.ativoDataGridViewCheckBoxColumn.HeaderText = "Ativo";
            this.ativoDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.ativoDataGridViewCheckBoxColumn.Name = "ativoDataGridViewCheckBoxColumn";
            this.ativoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.ativoDataGridViewCheckBoxColumn.Width = 125;
            // 
            // usuIncDataGridViewTextBoxColumn
            // 
            this.usuIncDataGridViewTextBoxColumn.DataPropertyName = "UsuInc";
            this.usuIncDataGridViewTextBoxColumn.HeaderText = "UsuInc";
            this.usuIncDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usuIncDataGridViewTextBoxColumn.Name = "usuIncDataGridViewTextBoxColumn";
            this.usuIncDataGridViewTextBoxColumn.ReadOnly = true;
            this.usuIncDataGridViewTextBoxColumn.Width = 125;
            // 
            // usuAltDataGridViewTextBoxColumn
            // 
            this.usuAltDataGridViewTextBoxColumn.DataPropertyName = "UsuAlt";
            this.usuAltDataGridViewTextBoxColumn.HeaderText = "UsuAlt";
            this.usuAltDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usuAltDataGridViewTextBoxColumn.Name = "usuAltDataGridViewTextBoxColumn";
            this.usuAltDataGridViewTextBoxColumn.ReadOnly = true;
            this.usuAltDataGridViewTextBoxColumn.Width = 125;
            // 
            // datIncDataGridViewTextBoxColumn
            // 
            this.datIncDataGridViewTextBoxColumn.DataPropertyName = "DatInc";
            this.datIncDataGridViewTextBoxColumn.HeaderText = "DatInc";
            this.datIncDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datIncDataGridViewTextBoxColumn.Name = "datIncDataGridViewTextBoxColumn";
            this.datIncDataGridViewTextBoxColumn.ReadOnly = true;
            this.datIncDataGridViewTextBoxColumn.Width = 125;
            // 
            // datAltDataGridViewTextBoxColumn
            // 
            this.datAltDataGridViewTextBoxColumn.DataPropertyName = "DatAlt";
            this.datAltDataGridViewTextBoxColumn.HeaderText = "DatAlt";
            this.datAltDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.datAltDataGridViewTextBoxColumn.Name = "datAltDataGridViewTextBoxColumn";
            this.datAltDataGridViewTextBoxColumn.ReadOnly = true;
            this.datAltDataGridViewTextBoxColumn.Width = 125;
            // 
            // deletarDataGridViewTextBoxColumn
            // 
            this.deletarDataGridViewTextBoxColumn.DataPropertyName = "Deletar";
            this.deletarDataGridViewTextBoxColumn.HeaderText = "Deletar";
            this.deletarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deletarDataGridViewTextBoxColumn.Name = "deletarDataGridViewTextBoxColumn";
            this.deletarDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.deletarDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.deletarDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.DataPropertyName = "Editar";
            this.dataGridViewButtonColumn1.HeaderText = "Editar";
            this.dataGridViewButtonColumn1.MinimumWidth = 6;
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Width = 125;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.Width = 125;
            // 
            // livroTituloDataGridViewTextBoxColumn
            // 
            this.livroTituloDataGridViewTextBoxColumn.DataPropertyName = "Livro.Titulo";
            this.livroTituloDataGridViewTextBoxColumn.HeaderText = "Livro.Titulo";
            this.livroTituloDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.livroTituloDataGridViewTextBoxColumn.Name = "livroTituloDataGridViewTextBoxColumn";
            this.livroTituloDataGridViewTextBoxColumn.Width = 125;
            // 
            // livroDataGridViewTextBoxColumn1
            // 
            this.livroDataGridViewTextBoxColumn1.DataPropertyName = "Livro";
            this.livroDataGridViewTextBoxColumn1.HeaderText = "Livro";
            this.livroDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.livroDataGridViewTextBoxColumn1.Name = "livroDataGridViewTextBoxColumn1";
            this.livroDataGridViewTextBoxColumn1.Visible = false;
            this.livroDataGridViewTextBoxColumn1.Width = 125;
            // 
            // usuarioNomeDataGridViewTextBoxColumn
            // 
            this.usuarioNomeDataGridViewTextBoxColumn.DataPropertyName = "Usuario.Nome";
            this.usuarioNomeDataGridViewTextBoxColumn.HeaderText = "Usuario.Nome";
            this.usuarioNomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usuarioNomeDataGridViewTextBoxColumn.Name = "usuarioNomeDataGridViewTextBoxColumn";
            this.usuarioNomeDataGridViewTextBoxColumn.Width = 125;
            // 
            // usuarioDataGridViewTextBoxColumn1
            // 
            this.usuarioDataGridViewTextBoxColumn1.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn1.HeaderText = "Usuario";
            this.usuarioDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.usuarioDataGridViewTextBoxColumn1.Name = "usuarioDataGridViewTextBoxColumn1";
            this.usuarioDataGridViewTextBoxColumn1.Visible = false;
            this.usuarioDataGridViewTextBoxColumn1.Width = 125;
            // 
            // locacaoTableAdapter
            // 
            this.locacaoTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::MVCProject.Properties.Resources.TOMELIROLA1;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(594, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(318, 106);
            this.button2.TabIndex = 5;
            this.button2.Text = "Adicionar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button1_Click);
            // 
            // frmLocacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.BackgroundImage = global::MVCProject.Properties.Resources.maxresdefault;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(924, 492);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmLocacoes";
            this.Text = "Locações";
            this.Load += new System.EventHandler(this.FrmLocacoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locacaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaBibliotecaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn Deletar;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn livroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn devolucaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ativoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuIncDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuAltDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datIncDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datAltDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn deletarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn livroTituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn livroDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioNomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn1;
        private SistemaBibliotecaDataSet sistemaBibliotecaDataSet;
        private System.Windows.Forms.BindingSource locacaoBindingSource;
        private SistemaBibliotecaDataSetTableAdapters.LocacaoTableAdapter locacaoTableAdapter;
        private System.Windows.Forms.DataGridViewButtonColumn deletarDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewButtonColumn editarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn livroDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn livroTituloDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn generosTipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioNomeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn devolucaoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ativoDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuIncDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuAltDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn datIncDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn datAltDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button button2;
    }
}