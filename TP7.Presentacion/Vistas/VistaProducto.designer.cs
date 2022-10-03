namespace TP7
{
    partial class VistaProducto
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaProducto));
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.RichTextBox();
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCostoSinIva = new System.Windows.Forms.RichTextBox();
            this.txtPorcentaje = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCostoConIva = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrecioFinal = new System.Windows.Forms.RichTextBox();
            this.txtMargenGanancia = new System.Windows.Forms.RichTextBox();
            this.txtCantidad = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.botonLimpiar = new System.Windows.Forms.Button();
            this.botonGuardar = new System.Windows.Forms.Button();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.botonSalir = new System.Windows.Forms.Button();
            this.comboEstado = new System.Windows.Forms.ComboBox();
            this.bsProducto = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "Codigo", true));
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(198, 24);
            this.txtCodigo.Multiline = false;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(230, 24);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.Text = "";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtDescripcion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "Descripcion", true));
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(198, 67);
            this.txtDescripcion.Multiline = false;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(230, 24);
            this.txtDescripcion.TabIndex = 2;
            this.txtDescripcion.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Costo sin IVA";
            // 
            // txtCostoSinIva
            // 
            this.txtCostoSinIva.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCostoSinIva.CausesValidation = false;
            this.txtCostoSinIva.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "CostoSinIva", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "$", "N2"));
            this.txtCostoSinIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoSinIva.Location = new System.Drawing.Point(200, 149);
            this.txtCostoSinIva.Multiline = false;
            this.txtCostoSinIva.Name = "txtCostoSinIva";
            this.txtCostoSinIva.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCostoSinIva.Size = new System.Drawing.Size(230, 24);
            this.txtCostoSinIva.TabIndex = 5;
            this.txtCostoSinIva.Text = "";
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPorcentaje.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "PorcentajeIva", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "%", "N2"));
            this.txtPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorcentaje.Location = new System.Drawing.Point(198, 114);
            this.txtPorcentaje.Multiline = false;
            this.txtPorcentaje.Name = "txtPorcentaje";
            this.txtPorcentaje.Size = new System.Drawing.Size(230, 24);
            this.txtPorcentaje.TabIndex = 7;
            this.txtPorcentaje.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Porcentaje IVA";
            // 
            // txtCostoConIva
            // 
            this.txtCostoConIva.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCostoConIva.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "CostoConIva", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "$", "C2"));
            this.txtCostoConIva.Enabled = false;
            this.txtCostoConIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostoConIva.ForeColor = System.Drawing.Color.Maroon;
            this.txtCostoConIva.Location = new System.Drawing.Point(200, 186);
            this.txtCostoConIva.Multiline = false;
            this.txtCostoConIva.Name = "txtCostoConIva";
            this.txtCostoConIva.ReadOnly = true;
            this.txtCostoConIva.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCostoConIva.Size = new System.Drawing.Size(230, 24);
            this.txtCostoConIva.TabIndex = 9;
            this.txtCostoConIva.TabStop = false;
            this.txtCostoConIva.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Costo con IVA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "Margen de Ganancia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(89, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 24);
            this.label8.TabIndex = 11;
            this.label8.Text = "Precio Final";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(131, 342);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 24);
            this.label9.TabIndex = 12;
            this.label9.Text = "Estado";
            // 
            // txtPrecioFinal
            // 
            this.txtPrecioFinal.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtPrecioFinal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "PrecioFinalVenta", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "$", "C2"));
            this.txtPrecioFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioFinal.Location = new System.Drawing.Point(198, 273);
            this.txtPrecioFinal.Multiline = false;
            this.txtPrecioFinal.Name = "txtPrecioFinal";
            this.txtPrecioFinal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPrecioFinal.Size = new System.Drawing.Size(230, 24);
            this.txtPrecioFinal.TabIndex = 14;
            this.txtPrecioFinal.Text = "";
            // 
            // txtMargenGanancia
            // 
            this.txtMargenGanancia.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtMargenGanancia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "MargenGanancia", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "%%"));
            this.txtMargenGanancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMargenGanancia.Location = new System.Drawing.Point(198, 231);
            this.txtMargenGanancia.Multiline = false;
            this.txtMargenGanancia.Name = "txtMargenGanancia";
            this.txtMargenGanancia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMargenGanancia.Size = new System.Drawing.Size(230, 24);
            this.txtMargenGanancia.TabIndex = 13;
            this.txtMargenGanancia.Text = "";
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCantidad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "Existencia", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, null, "N0"));
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(198, 309);
            this.txtCantidad.Multiline = false;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCantidad.Size = new System.Drawing.Size(230, 24);
            this.txtCantidad.TabIndex = 18;
            this.txtCantidad.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(115, 309);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 24);
            this.label10.TabIndex = 17;
            this.label10.Text = "Cantidad";
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.Location = new System.Drawing.Point(326, 372);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(102, 23);
            this.botonLimpiar.TabIndex = 19;
            this.botonLimpiar.Text = "LIMPIAR";
            this.botonLimpiar.UseVisualStyleBackColor = true;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // botonGuardar
            // 
            this.botonGuardar.Location = new System.Drawing.Point(200, 372);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(105, 23);
            this.botonGuardar.TabIndex = 20;
            this.botonGuardar.Text = "GUARDAR";
            this.botonGuardar.UseVisualStyleBackColor = true;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // botonBuscar
            // 
            this.botonBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonBuscar.Location = new System.Drawing.Point(453, 24);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(112, 23);
            this.botonBuscar.TabIndex = 22;
            this.botonBuscar.Text = "BUSCAR";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // botonSalir
            // 
            this.botonSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.botonSalir.Location = new System.Drawing.Point(502, 410);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(75, 23);
            this.botonSalir.TabIndex = 24;
            this.botonSalir.TabStop = false;
            this.botonSalir.Text = "SALIR";
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // comboEstado
            // 
            this.comboEstado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducto, "Estado", true));
            this.comboEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.Location = new System.Drawing.Point(198, 345);
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(230, 21);
            this.comboEstado.TabIndex = 25;
            // 
            // bsProducto
            // 
            VistaProducto vistaProducto = this;
            vistaProducto.bsProducto.DataSource = typeof(TP7.Dominio.Producto);
            // 
            // VistaProducto
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(589, 445);
            this.Controls.Add(this.comboEstado);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.botonBuscar);
            this.Controls.Add(this.botonGuardar);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPrecioFinal);
            this.Controls.Add(this.txtMargenGanancia);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCostoConIva);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPorcentaje);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCostoSinIva);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "VistaProducto";
            this.Text = "Alta y Modificacion de Productos";
            this.Load += new System.EventHandler(this.VistaProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       // private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtCodigo;
        private System.Windows.Forms.RichTextBox txtDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtCostoSinIva;
        private System.Windows.Forms.RichTextBox txtPorcentaje;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox txtCostoConIva;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox txtPrecioFinal;
        private System.Windows.Forms.RichTextBox txtMargenGanancia;
        private System.Windows.Forms.RichTextBox txtCantidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button botonLimpiar;
        private System.Windows.Forms.Button botonGuardar;
        private System.Windows.Forms.Button botonBuscar;
        public System.Windows.Forms.BindingSource bsProducto;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.ComboBox comboEstado;
    }
}

