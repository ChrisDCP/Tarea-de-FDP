namespace CapaPresentacion.COMPRAS
{
    partial class frmcompras
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
            this.group1 = new System.Windows.Forms.GroupBox();
            this.lbcodigo = new System.Windows.Forms.Label();
            this.datFecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbproveedor = new System.Windows.Forms.ComboBox();
            this.group2 = new System.Windows.Forms.GroupBox();
            this.btagregar = new System.Windows.Forms.Button();
            this.lbsubtotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtunidadMedida = new System.Windows.Forms.TextBox();
            this.txtcantidad = new System.Windows.Forms.NumericUpDown();
            this.txtprecio = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.txtidProducto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbproducto = new System.Windows.Forms.ComboBox();
            this.group3 = new System.Windows.Forms.GroupBox();
            this.gridview = new System.Windows.Forms.DataGridView();
            this.id_producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.lbtotal = new System.Windows.Forms.Label();
            this.btsalir = new System.Windows.Forms.Button();
            this.btnuevo = new System.Windows.Forms.Button();
            this.btguardar = new System.Windows.Forms.Button();
            this.group1.SuspendLayout();
            this.group2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtprecio)).BeginInit();
            this.group3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // group1
            // 
            this.group1.BackColor = System.Drawing.Color.White;
            this.group1.Controls.Add(this.lbcodigo);
            this.group1.Controls.Add(this.datFecha);
            this.group1.Controls.Add(this.label3);
            this.group1.Controls.Add(this.label2);
            this.group1.Controls.Add(this.label1);
            this.group1.Controls.Add(this.cbproveedor);
            this.group1.Location = new System.Drawing.Point(12, 21);
            this.group1.Name = "group1";
            this.group1.Size = new System.Drawing.Size(714, 93);
            this.group1.TabIndex = 1;
            this.group1.TabStop = false;
            this.group1.Text = "Datos de la Compra";
            // 
            // lbcodigo
            // 
            this.lbcodigo.ForeColor = System.Drawing.Color.Red;
            this.lbcodigo.Location = new System.Drawing.Point(6, 51);
            this.lbcodigo.Name = "lbcodigo";
            this.lbcodigo.Size = new System.Drawing.Size(136, 25);
            this.lbcodigo.TabIndex = 7;
            this.lbcodigo.Text = "0000000";
            this.lbcodigo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // datFecha
            // 
            this.datFecha.Enabled = false;
            this.datFecha.Location = new System.Drawing.Point(471, 50);
            this.datFecha.Name = "datFecha";
            this.datFecha.Size = new System.Drawing.Size(221, 26);
            this.datFecha.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(517, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha Compra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Proveedor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nº Compra";
            // 
            // cbproveedor
            // 
            this.cbproveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbproveedor.FormattingEnabled = true;
            this.cbproveedor.Location = new System.Drawing.Point(145, 48);
            this.cbproveedor.Name = "cbproveedor";
            this.cbproveedor.Size = new System.Drawing.Size(289, 28);
            this.cbproveedor.TabIndex = 2;
            this.cbproveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbproveedor_KeyPress);
            // 
            // group2
            // 
            this.group2.BackColor = System.Drawing.Color.White;
            this.group2.Controls.Add(this.btagregar);
            this.group2.Controls.Add(this.lbsubtotal);
            this.group2.Controls.Add(this.label9);
            this.group2.Controls.Add(thkr.txtunidadMedid�);            this.gro�p2.Controls.Add(this.txtcantidad	;
            th�s.group2.Controls.Add(this.txtprecio);
            t(is.group2.Controls.Add(this.label10);
            vh)s.group2.Controls.Add(4his.txtidProducto);
            this.group2.Controls.Add(this.da�el8)+-
            this.group2.Controls.Add(this.labal6);
            this.grnup2.ControLs*Add(this.l`bel5);
            t(is.group2.Controls.Add(this.label7);
0           tHis.group�.Contro�s.Add(this.cbproducto);
            this.group2.Locatinn = new System.Drawing.Poant(12,�929);
        `   thkq.group2.Name = #group2";	
            this.group2.Size = new System.Lrawing.Size(711, 1�8);
            this.group2.TabIndex = 2;��           tl)s.croup2.TabStop =�fa�se3
            this.group2.Text`= "Datow del Prodtcto";
            // 
      �     // btagregar�            // 
        " $ this.btagregaz.Location = new System.Drawing.Point(572, 142);
            tjis.btewreoa2.Name = "btagregar";
 �          this.btagregar.Size = new System.Drawing.Size(96, 53);
            this.btagregar.TabIndex = 17;
            this.btagregar.Text = "Agregar";
            this.btagregar.UseVisualStyleBackColor = true;
            this.btagregar.Click += new System.EventHandler(this.btagregar_Click);
            // 
            // lbsubtotal
            // 
            this.lbsubtotal.ForeColor = System.Drawing.Color.Red;
            this.lbsubtotal.Location = new System.Drawing.Point(372, 128);
            this.lbsubtotal.Name = "lbsubtotal";
            this.lbsubtotal.Size = new System.Drawing.Size(147, 34);
            this.lbsubtotal.TabIndex = 16;
            this.lbsubtotal.Text = "C$ 00000,00";
            this.lbsubtotal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(401, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "SubTotal:";
            // 
            // txtunidadMedida
            // 
            this.txtunidadMedida.Location = new System.Drawing.Point(464, 62);
            this.txtunidadMedida.Name = "txtunidadMedida";
            this.txtunidadMedida.ReadOnly = true;
            this.txtunidadMedida.Size = new System.Drawing.Size(204, 26);
            this.txtunidadMedida.TabIndex = 15;
            // 
            // txtcantidad
            // 
            this.txtcantidad.DecimalPlaces = 2;
            this.txtcantidad.Enabled = false;
            this.txtcantidad.Location = new System.Drawing.Point(27, 125);
            this.txtcantidad.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(163, 26);
            this.txtcantidad.TabIndex = 14;
            this.txtcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtcantidad.ValueChanged += new System.EventHandler(this.txtprecio_ValueChanged);
            this.txtcantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantidad_KeyPress);
            // 
            // txtprecio
            // 
            this.txtprecio.DecimalPlaces = 2;
            this.txtprecio.Enabled = false;
            this.txtprecio.Location = new System.Drawing.Point(212, 128);
            this.txtprecio.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(140, 26);
            this.txtprecio.TabIndex = 14;
            this.txtprecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtprecio.ValueChanged += new System.EventHandler(this.txtprecio_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(505, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "UnidadMedida";
            // 
            // txtidProducto
            // 
            this.txtidProducto.Location = new System.Drawing.Point(27, 62);
            this.txtidProducto.Name = "txtidProducto";
            this.txtidProducto.ReadOnly = true;
            this.txtidProducto.Size = new System.Drawing.Size(163, 26);
            this.txtidProducto.TabIndex = 8;
            this.txtidProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "ID Producto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(223, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio Compra";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(291, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Nombre";
            // 
            // cbproducto
            // 
            this.cbproducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbproducto.FormattingEnabled = true;
            this.cbproducto.Location = new System.Drawing.Point(212, 62);
            this.cbproducto.Name = "cbproducto";
            this.cbproducto.Size = new System.Drawing.Size(226, 28);
            this.cbproducto.TabIndex = 0;
            this.cbproducto.SelectedIndexChanged += new System.EventHandler(this.cbproducto_SelectedIndexChanged);
            this.cbproducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbproducto_KeyPress);
            // 
            // group3
            // 
            this.group3.Controls.Add(this.gridview);
            this.group3.Location = new System.Drawing.Point(12, 325);
            this.group3.Name = "group3";
            this.group3.Size = new System.Drawing.Size(711, 220);
            this.group3.TabIndex = 3;
            this.group3.TabStop = false;
            this.group3.Text = "Detalle de la Compra";
            // 
            // gridview
            // 
            this.gridview.BackgroundColor = System.Drawing.Color.White;
            this.gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_producto,
            this.producto,
            this.cantidad,
            this.precio,
            this.subtotal});
            this.gridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridview.Location = new System.Drawing.Point(3, 22);
            this.gridview.Name = "gridview";
            this.gridview.RowHeadersWidth = 60;
            this.gridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridview.Size = new System.Drawing.Size(705, 195);
            this.gridview.TabIndex = 0;
            // 
            // id_producto
            // 
            this.id_producto.HeaderText = "Codigo";
            this.id_producto.Name = "id_producto";
            this.id_producto.ReadOnly = true;
            // 
            // producto
            // 
            this.producto.HeaderText = "Producto";
            this.producto.Name = "producto";
            this.producto.ReadOnly = true;
            this.producto.Width = 200;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            this.precio.Width = 120;
            // 
            // subtotal
            // 
            this.subtotal.HeaderText = "SubTotal";
            this.subtotal.Name = "subtotal";
            this.subtotal.ReadOnly = true;
            this.subtotal.Width = 120;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(303, 548);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(252, 20);
            this.label13.TabIndex = 4;
            this.label13.Text = "El costo total de la compra es:";
            // 
            // lbtotal
            // 
            this.lbtotal.ForeColor = System.Drawing.Color.Red;
            this.lbtotal.Location = new System.Drawing.Point(588, 548);
            this.lbtotal.Name = "lbtotal";
            this.lbtotal.Size = new System.Drawing.Size(132, 34);
            this.lbtotal.TabIndex = 17;
            this.lbtotal.Text = "00000,00";
            // 
            // btsalir
            // 
            this.btsalir.Location = new System.Drawing.Point(250, 584);
            this.btsalir.Name = "btsalir";
            this.btsalir.Size = new System.Drawing.Size(97, 37);
            this.btsalir.TabIndex = 21;
            this.btsalir.Text = "Salir";
            this.btsalir.UseVisualStyleBackColor = true;
            this.btsalir.Click += new System.EventHandler(this.btsalir_Click);
            // 
            // btnuevo
            // 
            this.btnuevo.Enabled = false;
            this.btnuevo.Location = new System.Drawing.Point(16, 584);
            this.btnuevo.Name = "btnuevo";
            this.btnuevo.Size = new System.Drawing.Size(97, 37);
            this.btnuevo.TabIndex = 20;
            this.btnuevo.Text = "Nuevo";
            this.btnuevo.UseVisualStyleBackColor = true;
            this.btnuevo.Click += new System.EventHandler(this.btnuevo_Click);
            // 
            // btguardar
            // 
            this.btguardar.Enabled = false;
            this.btguardar.Location = new System.Drawing.Point(133, 584);
            this.btguardar.Name = "btguardar";
            this.btguardar.Size = new System.Drawing.Size(97, 37);
            this.btguardar.TabIndex = 19;
            this.btguardar.Text = "Guardar";
            this.btguardar.UseVisualStyleBackColor = true;
            this.btguardar.Click += new System.EventHandler(this.btguardar_Click);
            // 
            // frmcompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(735, 634);
            this.Controls.Add(this.btsalir);
            this.Controls.Add(this.btnuevo);
            this.Controls.Add(this.btguardar);
            this.Controls.Add(this.lbtotal);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.group3);
            this.Controls.Add(this.group2);
            this.Controls.Add(this.group1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmcompras";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registros de Compras";
            this.Load += new System.EventHandler(this.frmcompras_Load);
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtprecio)).EndInit();
            this.group3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox group1;
        private System.Windows.Forms.Label lbcodigo;
        private System.Windows.Forms.DateTimePicker datFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbproveedor;
        private System.Windows.Forms.GroupBox group2;
        private System.Windows.Forms.Button btagregar;
        private System.Windows.Forms.Label lbsubtotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtunidadMedida;
        private System.Windows.Forms.NumericUpDown txtprecio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtidProducto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbproducto;
        private System.Windows.Forms.GroupBox group3;
        private System.Windows.Forms.DataGridView gridview;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbtotal;
        private System.Windows.Forms.Button btsalir;
        private System.Windows.Forms.Button btnuevo;
        private System.Windows.Forms.Button btguardar;
        private System.Windows.Forms.NumericUpDown txtcantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
    }
}