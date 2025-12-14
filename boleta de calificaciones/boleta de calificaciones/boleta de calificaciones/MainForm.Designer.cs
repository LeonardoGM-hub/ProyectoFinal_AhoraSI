/*
 * Creado por SharpDevelop.
 * Usuario: asus
 * Fecha: 20/11/2025
 * Hora: 01:36 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace boleta_de_calificaciones
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
			this.gbGrado = new System.Windows.Forms.GroupBox();
			this.btnSalir = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnRegistrar = new System.Windows.Forms.Button();
			this.lblFecha = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.cbbMateria = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.cbbEspecialidad = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.cbbGrado = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txt3 = new System.Windows.Forms.TextBox();
			this.txt2 = new System.Windows.Forms.TextBox();
			this.txt1 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lvTabla = new System.Windows.Forms.ListView();
			this.Asignatura = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.label9 = new System.Windows.Forms.Label();
			this.lblPromedio = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.gbGrado.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// gbGrado
			// 
			this.gbGrado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.gbGrado.Controls.Add(this.btnSalir);
			this.gbGrado.Controls.Add(this.btnCancelar);
			this.gbGrado.Controls.Add(this.btnRegistrar);
			this.gbGrado.Controls.Add(this.lblFecha);
			this.gbGrado.Controls.Add(this.label8);
			this.gbGrado.Controls.Add(this.cbbMateria);
			this.gbGrado.Controls.Add(this.label7);
			this.gbGrado.Controls.Add(this.cbbEspecialidad);
			this.gbGrado.Controls.Add(this.label6);
			this.gbGrado.Controls.Add(this.cbbGrado);
			this.gbGrado.Controls.Add(this.label5);
			this.gbGrado.Controls.Add(this.txt3);
			this.gbGrado.Controls.Add(this.txt2);
			this.gbGrado.Controls.Add(this.txt1);
			this.gbGrado.Controls.Add(this.label4);
			this.gbGrado.Controls.Add(this.label3);
			this.gbGrado.Controls.Add(this.label2);
			this.gbGrado.Controls.Add(this.txtNombre);
			this.gbGrado.Controls.Add(this.label1);
			this.gbGrado.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbGrado.ForeColor = System.Drawing.SystemColors.Control;
			this.gbGrado.Location = new System.Drawing.Point(360, 11);
			this.gbGrado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.gbGrado.Name = "gbGrado";
			this.gbGrado.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.gbGrado.Size = new System.Drawing.Size(488, 257);
			this.gbGrado.TabIndex = 0;
			this.gbGrado.TabStop = false;
			this.gbGrado.Text = "Boleta de calificaciones";
			// 
			// btnSalir
			// 
			this.btnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnSalir.Location = new System.Drawing.Point(382, 202);
			this.btnSalir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 29);
			this.btnSalir.TabIndex = 20;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// btnCancelar
			// 
			this.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnCancelar.Location = new System.Drawing.Point(303, 202);
			this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(75, 29);
			this.btnCancelar.TabIndex = 19;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = true;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// btnRegistrar
			// 
			this.btnRegistrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnRegistrar.Location = new System.Drawing.Point(224, 202);
			this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnRegistrar.Name = "btnRegistrar";
			this.btnRegistrar.Size = new System.Drawing.Size(75, 29);
			this.btnRegistrar.TabIndex = 18;
			this.btnRegistrar.Text = "Registrar";
			this.btnRegistrar.UseVisualStyleBackColor = true;
			this.btnRegistrar.Click += new System.EventHandler(this.BtnRegistrarClick);
			// 
			// lblFecha
			// 
			this.lblFecha.Location = new System.Drawing.Point(224, 169);
			this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblFecha.Name = "lblFecha";
			this.lblFecha.Size = new System.Drawing.Size(102, 19);
			this.lblFecha.TabIndex = 15;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(224, 144);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(97, 19);
			this.label8.TabIndex = 14;
			this.label8.Text = "Fecha Actual:";
			// 
			// cbbMateria
			// 
			this.cbbMateria.FormattingEnabled = true;
			this.cbbMateria.Items.AddRange(new object[] {
									"Humanidades",
									"La Materia y sus Interacciones",
									"Lengua y comunicacion",
									"Ingles",
									"Pensamiento Matematico",
									"Modulo1",
									"Modulo2",
									"Formacion Socio Emocional"});
			this.cbbMateria.Location = new System.Drawing.Point(14, 165);
			this.cbbMateria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.cbbMateria.Name = "cbbMateria";
			this.cbbMateria.Size = new System.Drawing.Size(131, 30);
			this.cbbMateria.TabIndex = 13;
			this.cbbMateria.SelectedIndexChanged += new System.EventHandler(this.CbbMateriaSelectedIndexChanged);
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(14, 144);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(168, 19);
			this.label7.TabIndex = 12;
			this.label7.Text = "Asignatura:";
			// 
			// cbbEspecialidad
			// 
			this.cbbEspecialidad.FormattingEnabled = true;
			this.cbbEspecialidad.Items.AddRange(new object[] {
									"Programacion",
									"Soporte",
									"Administracion",
									"Mecanica",
									"Contavilidad",
									"Alimentos",
									"Civer Seguridad"});
			this.cbbEspecialidad.Location = new System.Drawing.Point(316, 107);
			this.cbbEspecialidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.cbbEspecialidad.Name = "cbbEspecialidad";
			this.cbbEspecialidad.Size = new System.Drawing.Size(94, 30);
			this.cbbEspecialidad.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(224, 110);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(97, 19);
			this.label6.TabIndex = 10;
			this.label6.Text = "Espacialidad:";
			// 
			// cbbGrado
			// 
			this.cbbGrado.FormattingEnabled = true;
			this.cbbGrado.Items.AddRange(new object[] {
									"1",
									"2",
									"3",
									"4",
									"5",
									"6"});
			this.cbbGrado.Location = new System.Drawing.Point(96, 107);
			this.cbbGrado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.cbbGrado.Name = "cbbGrado";
			this.cbbGrado.Size = new System.Drawing.Size(42, 30);
			this.cbbGrado.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(39, 110);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(52, 21);
			this.label5.TabIndex = 8;
			this.label5.Text = "Grado:";
			// 
			// txt3
			// 
			this.txt3.Location = new System.Drawing.Point(382, 56);
			this.txt3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txt3.Name = "txt3";
			this.txt3.Size = new System.Drawing.Size(76, 29);
			this.txt3.TabIndex = 7;
			// 
			// txt2
			// 
			this.txt2.Location = new System.Drawing.Point(303, 56);
			this.txt2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txt2.Name = "txt2";
			this.txt2.Size = new System.Drawing.Size(76, 29);
			this.txt2.TabIndex = 6;
			// 
			// txt1
			// 
			this.txt1.Location = new System.Drawing.Point(224, 56);
			this.txt1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(76, 29);
			this.txt1.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(387, 35);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(64, 22);
			this.label4.TabIndex = 4;
			this.label4.Text = "Parcial 3";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(312, 35);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(64, 22);
			this.label3.TabIndex = 3;
			this.label3.Text = "Parcial 2";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(234, 35);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 22);
			this.label2.TabIndex = 2;
			this.label2.Text = "Parcial 1";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(14, 56);
			this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(156, 29);
			this.txtNombre.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(14, 35);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(145, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nombre del alumno";
			// 
			// lvTabla
			// 
			this.lvTabla.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.Asignatura,
									this.columnHeader2,
									this.columnHeader3,
									this.columnHeader4,
									this.columnHeader5,
									this.columnHeader6});
			this.lvTabla.Location = new System.Drawing.Point(28, 272);
			this.lvTabla.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.lvTabla.Name = "lvTabla";
			this.lvTabla.Size = new System.Drawing.Size(488, 142);
			this.lvTabla.TabIndex = 1;
			this.lvTabla.UseCompatibleStateImageBehavior = false;
			this.lvTabla.View = System.Windows.Forms.View.Details;
			// 
			// Asignatura
			// 
			this.Asignatura.Text = "Asignatura";
			this.Asignatura.Width = 77;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Parcial1";
			this.columnHeader2.Width = 70;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Parcial2";
			this.columnHeader3.Width = 71;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Parcial3";
			this.columnHeader4.Width = 74;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Promedio";
			this.columnHeader5.Width = 76;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Aprobado/Reprobado";
			this.columnHeader6.Width = 153;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(544, 294);
			this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(163, 25);
			this.label9.TabIndex = 2;
			this.label9.Text = "Promedio General:";
			// 
			// lblPromedio
			// 
			this.lblPromedio.Location = new System.Drawing.Point(584, 333);
			this.lblPromedio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblPromedio.Name = "lblPromedio";
			this.lblPromedio.Size = new System.Drawing.Size(87, 23);
			this.lblPromedio.TabIndex = 3;
			this.lblPromedio.Click += new System.EventHandler(this.LblPromedioClick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(28, 46);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(300, 168);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(837, 453);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lblPromedio);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.lvTabla);
			this.Controls.Add(this.gbGrado);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "MainForm";
			this.Text = "boleta de calificaciones";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.gbGrado.ResumeLayout(false);
			this.gbGrado.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader Asignatura;
		private System.Windows.Forms.Label lblPromedio;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ListView lvTabla;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txt1;
		private System.Windows.Forms.TextBox txt2;
		private System.Windows.Forms.TextBox txt3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cbbGrado;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cbbEspecialidad;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cbbMateria;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label lblFecha;
		private System.Windows.Forms.Button btnRegistrar;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.GroupBox gbGrado;
	}
}
