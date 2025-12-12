/*
 * Creado por SharpDevelop.
 * Usuario: CC1_PC32
 * Fecha: 08/12/2025
 * Hora: 02:24 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Proyecto26
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.rdbDulce = new System.Windows.Forms.RadioButton();
			this.rdbSalado = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbProductos = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.Productos = new System.Windows.Forms.ColumnHeader();
			this.Precio = new System.Windows.Forms.ColumnHeader();
			this.Cantidad = new System.Windows.Forms.ColumnHeader();
			this.Total = new System.Windows.Forms.ColumnHeader();
			this.label6 = new System.Windows.Forms.Label();
			this.txtSubtotal = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtDescuento = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtImporte = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.btnBorrar = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.SaddleBrown;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(119, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(638, 51);
			this.label1.TabIndex = 0;
			this.label1.Text = "Pasteleria Espacial para ti";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(429, 122);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(425, 2);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(459, 122);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			// 
			// rdbDulce
			// 
			this.rdbDulce.BackColor = System.Drawing.Color.Linen;
			this.rdbDulce.Location = new System.Drawing.Point(358, 130);
			this.rdbDulce.Name = "rdbDulce";
			this.rdbDulce.Size = new System.Drawing.Size(54, 24);
			this.rdbDulce.TabIndex = 3;
			this.rdbDulce.TabStop = true;
			this.rdbDulce.Text = "Dulce";
			this.rdbDulce.UseVisualStyleBackColor = false;
			this.rdbDulce.CheckedChanged += new System.EventHandler(this.RdbDulceCheckedChanged);
			// 
			// rdbSalado
			// 
			this.rdbSalado.BackColor = System.Drawing.Color.Linen;
			this.rdbSalado.Location = new System.Drawing.Point(437, 130);
			this.rdbSalado.Name = "rdbSalado";
			this.rdbSalado.Size = new System.Drawing.Size(59, 24);
			this.rdbSalado.TabIndex = 4;
			this.rdbSalado.TabStop = true;
			this.rdbSalado.Text = "Salado";
			this.rdbSalado.UseVisualStyleBackColor = false;
			this.rdbSalado.CheckedChanged += new System.EventHandler(this.RdbSaladoCheckedChanged);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 166);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(162, 22);
			this.label2.TabIndex = 5;
			this.label2.Text = "Selecciona Producto: ";
			// 
			// cmbProductos
			// 
			this.cmbProductos.FormattingEnabled = true;
			this.cmbProductos.Location = new System.Drawing.Point(180, 165);
			this.cmbProductos.Name = "cmbProductos";
			this.cmbProductos.Size = new System.Drawing.Size(168, 21);
			this.cmbProductos.TabIndex = 7;
			this.cmbProductos.SelectedIndexChanged += new System.EventHandler(this.CmbProductosSelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(392, 168);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 23);
			this.label3.TabIndex = 8;
			this.label3.Text = "Precio";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(497, 168);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 23);
			this.label4.TabIndex = 9;
			this.label4.Text = "Cantidad";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(623, 168);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(40, 23);
			this.label5.TabIndex = 10;
			this.label5.Text = "Total";
			// 
			// txtPrecio
			// 
			this.txtPrecio.Location = new System.Drawing.Point(358, 189);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.ReadOnly = true;
			this.txtPrecio.Size = new System.Drawing.Size(100, 20);
			this.txtPrecio.TabIndex = 11;
			// 
			// txtCantidad
			// 
			this.txtCantidad.Location = new System.Drawing.Point(471, 189);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(100, 20);
			this.txtCantidad.TabIndex = 12;
			this.txtCantidad.TextChanged += new System.EventHandler(this.TxtCantidadTextChanged);
			// 
			// txtTotal
			// 
			this.txtTotal.Location = new System.Drawing.Point(589, 189);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.ReadOnly = true;
			this.txtTotal.Size = new System.Drawing.Size(100, 20);
			this.txtTotal.TabIndex = 13;
			// 
			// btnAgregar
			// 
			this.btnAgregar.BackColor = System.Drawing.Color.Peru;
			this.btnAgregar.Location = new System.Drawing.Point(713, 163);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(123, 23);
			this.btnAgregar.TabIndex = 14;
			this.btnAgregar.Text = "Agregar producto";
			this.btnAgregar.UseVisualStyleBackColor = false;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// btnEliminar
			// 
			this.btnEliminar.BackColor = System.Drawing.Color.Peru;
			this.btnEliminar.Location = new System.Drawing.Point(713, 192);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(123, 23);
			this.btnEliminar.TabIndex = 15;
			this.btnEliminar.Text = "Eliminar producto";
			this.btnEliminar.UseVisualStyleBackColor = false;
			this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.Productos,
			this.Precio,
			this.Cantidad,
			this.Total});
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.Location = new System.Drawing.Point(12, 215);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(357, 155);
			this.listView1.TabIndex = 16;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// Productos
			// 
			this.Productos.Text = "Productos";
			this.Productos.Width = 174;
			// 
			// Precio
			// 
			this.Precio.Text = "Precio";
			// 
			// Cantidad
			// 
			this.Cantidad.Text = "Cantidad";
			// 
			// Total
			// 
			this.Total.Text = "Total";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(375, 215);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 17;
			this.label6.Text = "Subtotal";
			// 
			// txtSubtotal
			// 
			this.txtSubtotal.Location = new System.Drawing.Point(375, 228);
			this.txtSubtotal.Name = "txtSubtotal";
			this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
			this.txtSubtotal.TabIndex = 18;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(375, 251);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 19;
			this.label7.Text = "Descuento";
			// 
			// txtDescuento
			// 
			this.txtDescuento.Location = new System.Drawing.Point(375, 267);
			this.txtDescuento.Name = "txtDescuento";
			this.txtDescuento.Size = new System.Drawing.Size(100, 20);
			this.txtDescuento.TabIndex = 20;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(375, 290);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 21;
			this.label8.Text = "Importe a pagar";
			// 
			// txtImporte
			// 
			this.txtImporte.Location = new System.Drawing.Point(375, 307);
			this.txtImporte.Name = "txtImporte";
			this.txtImporte.Size = new System.Drawing.Size(100, 20);
			this.txtImporte.TabIndex = 22;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Peru;
			this.button3.Location = new System.Drawing.Point(602, 268);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(115, 59);
			this.button3.TabIndex = 25;
			this.button3.Text = "Guardar";
			this.button3.UseVisualStyleBackColor = false;
			// 
			// btnBorrar
			// 
			this.btnBorrar.BackColor = System.Drawing.Color.Peru;
			this.btnBorrar.Location = new System.Drawing.Point(481, 267);
			this.btnBorrar.Name = "btnBorrar";
			this.btnBorrar.Size = new System.Drawing.Size(115, 59);
			this.btnBorrar.TabIndex = 26;
			this.btnBorrar.Text = "Borrar";
			this.btnBorrar.UseVisualStyleBackColor = false;
			this.btnBorrar.Click += new System.EventHandler(this.BtnBorrarClick);
			// 
			// btnSalir
			// 
			this.btnSalir.BackColor = System.Drawing.Color.Peru;
			this.btnSalir.Location = new System.Drawing.Point(723, 268);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(115, 59);
			this.btnSalir.TabIndex = 27;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PeachPuff;
			this.ClientSize = new System.Drawing.Size(875, 382);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnBorrar);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.txtImporte);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtDescuento);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.txtSubtotal);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.txtTotal);
			this.Controls.Add(this.txtCantidad);
			this.Controls.Add(this.txtPrecio);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cmbProductos);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.rdbSalado);
			this.Controls.Add(this.rdbDulce);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.pictureBox2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainForm";
			this.Text = "Proyecto26";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.Button btnBorrar;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox txtImporte;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtDescuento;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtSubtotal;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ColumnHeader Total;
		private System.Windows.Forms.ColumnHeader Cantidad;
		private System.Windows.Forms.ColumnHeader Precio;
		private System.Windows.Forms.ColumnHeader Productos;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.TextBox txtTotal;
		private System.Windows.Forms.TextBox txtCantidad;
		private System.Windows.Forms.TextBox txtPrecio;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cmbProductos;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.RadioButton rdbSalado;
		private System.Windows.Forms.RadioButton rdbDulce;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSalir;
	}
}
