﻿namespace GestionComercio
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtFitro = new System.Windows.Forms.TextBox();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.LinkLabel();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.BotonFiltrar = new System.Windows.Forms.Button();
            this.textBoxFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.labelFiltro = new System.Windows.Forms.Label();
            this.ComboBoxCriterio = new System.Windows.Forms.ComboBox();
            this.labelCriterio = new System.Windows.Forms.Label();
            this.ComboBoxCampo = new System.Windows.Forms.ComboBox();
            this.labelCampo = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAgregarMarca = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAgregarCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnVerDetalle = new System.Windows.Forms.Button();
            this.pnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAgregar.Location = new System.Drawing.Point(12, 184);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(80, 60);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnModificar.Location = new System.Drawing.Point(12, 273);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(80, 60);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnEliminar.Location = new System.Drawing.Point(12, 363);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(80, 60);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtFitro
            // 
            this.txtFitro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFitro.Location = new System.Drawing.Point(112, 92);
            this.txtFitro.Name = "txtFitro";
            this.txtFitro.Size = new System.Drawing.Size(743, 20);
            this.txtFitro.TabIndex = 5;
            this.txtFitro.TextChanged += new System.EventHandler(this.txtFitro_TextChanged);
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTitulo.BackColor = System.Drawing.Color.LightSlateGray;
            this.pnlTitulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlTitulo.Controls.Add(this.lblTitulo);
            this.pnlTitulo.Location = new System.Drawing.Point(0, 27);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(1085, 50);
            this.pnlTitulo.TabIndex = 6;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.LinkColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(112, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(260, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.TabStop = true;
            this.lblTitulo.Text = "Gestion de Comercio";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(112, 141);
            this.dgvArticulos.MinimumSize = new System.Drawing.Size(743, 369);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersVisible = false;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(743, 369);
            this.dgvArticulos.TabIndex = 9;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxArticulo.Location = new System.Drawing.Point(861, 141);
            this.pbxArticulo.MinimumSize = new System.Drawing.Size(212, 197);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(212, 197);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 10;
            this.pbxArticulo.TabStop = false;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Location = new System.Drawing.Point(29, 90);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(63, 20);
            this.lblFiltro.TabIndex = 11;
            this.lblFiltro.Text = "Buscar:";
            // 
            // BotonFiltrar
            // 
            this.BotonFiltrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BotonFiltrar.Location = new System.Drawing.Point(673, 534);
            this.BotonFiltrar.Name = "BotonFiltrar";
            this.BotonFiltrar.Size = new System.Drawing.Size(75, 23);
            this.BotonFiltrar.TabIndex = 35;
            this.BotonFiltrar.Text = "Buscar";
            this.BotonFiltrar.UseVisualStyleBackColor = true;
            this.BotonFiltrar.Click += new System.EventHandler(this.BotonFiltrar_Click);
            // 
            // textBoxFiltroAvanzado
            // 
            this.textBoxFiltroAvanzado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxFiltroAvanzado.Location = new System.Drawing.Point(558, 537);
            this.textBoxFiltroAvanzado.Name = "textBoxFiltroAvanzado";
            this.textBoxFiltroAvanzado.Size = new System.Drawing.Size(100, 20);
            this.textBoxFiltroAvanzado.TabIndex = 34;
            // 
            // labelFiltro
            // 
            this.labelFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelFiltro.AutoSize = true;
            this.labelFiltro.Location = new System.Drawing.Point(517, 539);
            this.labelFiltro.Name = "labelFiltro";
            this.labelFiltro.Size = new System.Drawing.Size(29, 13);
            this.labelFiltro.TabIndex = 33;
            this.labelFiltro.Text = "Filtro";
            // 
            // ComboBoxCriterio
            // 
            this.ComboBoxCriterio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ComboBoxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxCriterio.FormattingEnabled = true;
            this.ComboBoxCriterio.Location = new System.Drawing.Point(374, 536);
            this.ComboBoxCriterio.Name = "ComboBoxCriterio";
            this.ComboBoxCriterio.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxCriterio.TabIndex = 32;
            // 
            // labelCriterio
            // 
            this.labelCriterio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCriterio.AutoSize = true;
            this.labelCriterio.Location = new System.Drawing.Point(333, 539);
            this.labelCriterio.Name = "labelCriterio";
            this.labelCriterio.Size = new System.Drawing.Size(39, 13);
            this.labelCriterio.TabIndex = 31;
            this.labelCriterio.Text = "Criterio";
            // 
            // ComboBoxCampo
            // 
            this.ComboBoxCampo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ComboBoxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxCampo.FormattingEnabled = true;
            this.ComboBoxCampo.Location = new System.Drawing.Point(203, 537);
            this.ComboBoxCampo.Name = "ComboBoxCampo";
            this.ComboBoxCampo.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxCampo.TabIndex = 30;
            this.ComboBoxCampo.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCampo_SelectedIndexChanged);
            // 
            // labelCampo
            // 
            this.labelCampo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCampo.AutoSize = true;
            this.labelCampo.Location = new System.Drawing.Point(150, 540);
            this.labelCampo.Name = "labelCampo";
            this.labelCampo.Size = new System.Drawing.Size(40, 13);
            this.labelCampo.TabIndex = 29;
            this.labelCampo.Text = "Campo";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msArchivo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1085, 24);
            this.menuStrip1.TabIndex = 36;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msArchivo
            // 
            this.msArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAgregarMarca,
            this.tsmAgregarCategoria});
            this.msArchivo.Name = "msArchivo";
            this.msArchivo.Size = new System.Drawing.Size(84, 20);
            this.msArchivo.Text = "Propiedades";
            // 
            // tsmAgregarMarca
            // 
            this.tsmAgregarMarca.Name = "tsmAgregarMarca";
            this.tsmAgregarMarca.Size = new System.Drawing.Size(227, 22);
            this.tsmAgregarMarca.Text = "Agregar marca de articulo";
            this.tsmAgregarMarca.Click += new System.EventHandler(this.tsmAgregarMarca_Click);
            // 
            // tsmAgregarCategoria
            // 
            this.tsmAgregarCategoria.Name = "tsmAgregarCategoria";
            this.tsmAgregarCategoria.Size = new System.Drawing.Size(227, 22);
            this.tsmAgregarCategoria.Text = "Agregar categoria de articulo";
            this.tsmAgregarCategoria.Click += new System.EventHandler(this.tsmAgregarCategoria_Click);
            // 
            // BtnVerDetalle
            // 
            this.BtnVerDetalle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnVerDetalle.Location = new System.Drawing.Point(935, 344);
            this.BtnVerDetalle.Name = "BtnVerDetalle";
            this.BtnVerDetalle.Size = new System.Drawing.Size(80, 27);
            this.BtnVerDetalle.TabIndex = 37;
            this.BtnVerDetalle.Text = "ver detale";
            this.BtnVerDetalle.UseVisualStyleBackColor = true;
            this.BtnVerDetalle.Click += new System.EventHandler(this.BtnVerDetalle_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1085, 581);
            this.Controls.Add(this.BtnVerDetalle);
            this.Controls.Add(this.BotonFiltrar);
            this.Controls.Add(this.textBoxFiltroAvanzado);
            this.Controls.Add(this.labelFiltro);
            this.Controls.Add(this.ComboBoxCriterio);
            this.Controls.Add(this.labelCriterio);
            this.Controls.Add(this.ComboBoxCampo);
            this.Controls.Add(this.labelCampo);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.txtFitro);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(1101, 620);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtFitro;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.LinkLabel lblTitulo;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Button BotonFiltrar;
        private System.Windows.Forms.TextBox textBoxFiltroAvanzado;
        private System.Windows.Forms.Label labelFiltro;
        private System.Windows.Forms.ComboBox ComboBoxCriterio;
        private System.Windows.Forms.Label labelCriterio;
        private System.Windows.Forms.ComboBox ComboBoxCampo;
        private System.Windows.Forms.Label labelCampo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msArchivo;
        private System.Windows.Forms.ToolStripMenuItem tsmAgregarMarca;
        private System.Windows.Forms.ToolStripMenuItem tsmAgregarCategoria;
        private System.Windows.Forms.Button BtnVerDetalle;
    }
}

