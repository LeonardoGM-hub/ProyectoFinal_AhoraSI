/*
 * Created by SharpDevelop.
 * User: CC1_PC34
 * Date: 08/12/2025
 * Time: 02:45 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Empleados
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.cmbPuesto = new System.Windows.Forms.ComboBox();
			this.txtFecha = new System.Windows.Forms.TextBox();
			this.cmbSexo = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.pbEmpleado = new System.Windows.Forms.PictureBox();
			this.btnActualizar = new System.Windows.Forms.Button();
			this.btnQuitar = new System.Windows.Forms.Button();
			this.dgvDatos = new System.Windows.Forms.DataGridView();
			this.CodigoDeEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Puesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.errpError = new System.Windows.Forms.ErrorProvider(this.components);
			this.rdbRegular = new System.Windows.Forms.RadioButton();
			this.rdbContratado = new System.Windows.Forms.RadioButton();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnEliminar = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pbEmpleado)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errpError)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 11);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(276, 28);
			this.label1.TabIndex = 0;
			this.label1.Text = "DETALLES DEL EMPLEADO";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(17, 60);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(172, 28);
			this.label2.TabIndex = 1;
			this.label2.Text = "Codigo del empleado: ";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(17, 94);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(155, 28);
			this.label3.TabIndex = 2;
			this.label3.Text = "Nombre del empleado: ";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(17, 143);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(133, 28);
			this.label4.TabIndex = 3;
			this.label4.Text = "Puesto:";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 192);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(155, 30);
			this.label5.TabIndex = 4;
			this.label5.Text = "Fecha de nacimiento:";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(16, 289);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(133, 28);
			this.label6.TabIndex = 5;
			this.label6.Text = "Estado:";
			// 
			// txtCodigo
			// 
			this.txtCodigo.Location = new System.Drawing.Point(197, 57);
			this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(132, 22);
			this.txtCodigo.TabIndex = 6;
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(197, 90);
			this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(132, 22);
			this.txtNombre.TabIndex = 7;
			// 
			// cmbPuesto
			// 
			this.cmbPuesto.FormattingEnabled = true;
			this.cmbPuesto.Items.AddRange(new object[] {
									"Gerente",
									"Contador",
									"Asistente personal",
									"Analista",
									"Gerente de recursos"});
			this.cmbPuesto.Location = new System.Drawing.Point(91, 139);
			this.cmbPuesto.Margin = new System.Windows.Forms.Padding(4);
			this.cmbPuesto.Name = "cmbPuesto";
			this.cmbPuesto.Size = new System.Drawing.Size(160, 24);
			this.cmbPuesto.TabIndex = 8;
			// 
			// txtFecha
			// 
			this.txtFecha.Location = new System.Drawing.Point(179, 188);
			this.txtFecha.Margin = new System.Windows.Forms.Padding(4);
			this.txtFecha.Name = "txtFecha";
			this.txtFecha.Size = new System.Drawing.Size(132, 22);
			this.txtFecha.TabIndex = 9;
			// 
			// cmbSexo
			// 
			this.cmbSexo.FormattingEnabled = true;
			this.cmbSexo.Items.AddRange(new object[] {
									"Masculino",
									"Femenino"});
			this.cmbSexo.Location = new System.Drawing.Point(91, 241);
			this.cmbSexo.Margin = new System.Windows.Forms.Padding(4);
			this.cmbSexo.Name = "cmbSexo";
			this.cmbSexo.Size = new System.Drawing.Size(160, 24);
			this.cmbSexo.TabIndex = 10;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(17, 241);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(65, 28);
			this.label7.TabIndex = 11;
			this.label7.Text = "Sexo:";
			// 
			// pbEmpleado
			// 
			this.pbEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("pbEmpleado.Image")));
			this.pbEmpleado.Location = new System.Drawing.Point(389, 28);
			this.pbEmpleado.Margin = new System.Windows.Forms.Padding(4);
			this.pbEmpleado.Name = "pbEmpleado";
			this.pbEmpleado.Size = new System.Drawing.Size(179, 156);
			this.pbEmpleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbEmpleado.TabIndex = 12;
			this.pbEmpleado.TabStop = false;
			// 
			// btnActualizar
			// 
			this.btnActualizar.Location = new System.Drawing.Point(377, 193);
			this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(100, 28);
			this.btnActualizar.TabIndex = 13;
			this.btnActualizar.Text = "Actualizar";
			this.btnActualizar.UseVisualStyleBackColor = true;
			this.btnActualizar.Click += new System.EventHandler(this.BtnActualizarClick);
			// 
			// btnQuitar
			// 
			this.btnQuitar.Location = new System.Drawing.Point(485, 192);
			this.btnQuitar.Margin = new System.Windows.Forms.Padding(4);
			this.btnQuitar.Name = "btnQuitar";
			this.btnQuitar.Size = new System.Drawing.Size(100, 28);
			this.btnQuitar.TabIndex = 14;
			this.btnQuitar.Text = "Quitar";
			this.btnQuitar.UseVisualStyleBackColor = true;
			this.btnQuitar.Click += new System.EventHandler(this.BtnQuitarClick);
			// 
			// dgvDatos
			// 
			this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.CodigoDeEmpleado,
									this.Nombre,
									this.Puesto,
									this.FechaNac,
									this.Sexo,
									this.Estado});
			this.dgvDatos.Location = new System.Drawing.Point(17, 321);
			this.dgvDatos.Margin = new System.Windows.Forms.Padding(4);
			this.dgvDatos.Name = "dgvDatos";
			this.dgvDatos.Size = new System.Drawing.Size(596, 159);
			this.dgvDatos.TabIndex = 15;
			// 
			// CodigoDeEmpleado
			// 
			this.CodigoDeEmpleado.HeaderText = "CodigoDeEmpleado";
			this.CodigoDeEmpleado.Name = "CodigoDeEmpleado";
			// 
			// Nombre
			// 
			this.Nombre.HeaderText = "Nombre";
			this.Nombre.Name = "Nombre";
			// 
			// Puesto
			// 
			this.Puesto.HeaderText = "Puesto";
			this.Puesto.Name = "Puesto";
			// 
			// FechaNac
			// 
			this.FechaNac.HeaderText = "FechaNac";
			this.FechaNac.Name = "FechaNac";
			// 
			// Sexo
			// 
			this.Sexo.HeaderText = "Sexo";
			this.Sexo.Name = "Sexo";
			// 
			// Estado
			// 
			this.Estado.HeaderText = "Estado";
			this.Estado.Name = "Estado";
			// 
			// errpError
			// 
			this.errpError.ContainerControl = this;
			// 
			// rdbRegular
			// 
			this.rdbRegular.Location = new System.Drawing.Point(91, 282);
			this.rdbRegular.Margin = new System.Windows.Forms.Padding(4);
			this.rdbRegular.Name = "rdbRegular";
			this.rdbRegular.Size = new System.Drawing.Size(139, 30);
			this.rdbRegular.TabIndex = 16;
			this.rdbRegular.TabStop = true;
			this.rdbRegular.Text = "Regular";
			this.rdbRegular.UseVisualStyleBackColor = true;
			// 
			// rdbContratado
			// 
			this.rdbContratado.Location = new System.Drawing.Point(237, 282);
			this.rdbContratado.Margin = new System.Windows.Forms.Padding(4);
			this.rdbContratado.Name = "rdbContratado";
			this.rdbContratado.Size = new System.Drawing.Size(139, 30);
			this.rdbContratado.TabIndex = 17;
			this.rdbContratado.TabStop = true;
			this.rdbContratado.Text = "Contrato";
			this.rdbContratado.UseVisualStyleBackColor = true;
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(377, 240);
			this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(100, 28);
			this.btnGuardar.TabIndex = 18;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// btnEliminar
			// 
			this.btnEliminar.Location = new System.Drawing.Point(485, 241);
			this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
			this.btnEliminar.Name = "btnEliminar";
			this.btnEliminar.Size = new System.Drawing.Size(100, 28);
			this.btnEliminar.TabIndex = 19;
			this.btnEliminar.Text = "Eliminar";
			this.btnEliminar.UseVisualStyleBackColor = true;
			this.btnEliminar.Click += new System.EventHandler(this.BtnEliminarClick);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(440, 282);
			this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(100, 28);
			this.btnLimpiar.TabIndex = 20;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiarClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(633, 495);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.btnEliminar);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.rdbContratado);
			this.Controls.Add(this.rdbRegular);
			this.Controls.Add(this.dgvDatos);
			this.Controls.Add(this.btnQuitar);
			this.Controls.Add(this.btnActualizar);
			this.Controls.Add(this.pbEmpleado);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.cmbSexo);
			this.Controls.Add(this.txtFecha);
			this.Controls.Add(this.cmbPuesto);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.txtCodigo);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "MainForm";
			this.Text = "Empleados";
			((System.ComponentModel.ISupportInitialize)(this.pbEmpleado)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errpError)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
		private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
		private System.Windows.Forms.DataGridViewTextBoxColumn FechaNac;
		private System.Windows.Forms.DataGridViewTextBoxColumn Puesto;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn CodigoDeEmpleado;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Button btnEliminar;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.RadioButton rdbRegular;
		private System.Windows.Forms.RadioButton rdbContratado;
		private System.Windows.Forms.ErrorProvider errpError;
		private System.Windows.Forms.DataGridView dgvDatos;
		private System.Windows.Forms.Button btnQuitar;
		private System.Windows.Forms.Button btnActualizar;
		private System.Windows.Forms.PictureBox pbEmpleado;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox cmbSexo;
		private System.Windows.Forms.TextBox txtFecha;
		private System.Windows.Forms.ComboBox cmbPuesto;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		
	}
}
