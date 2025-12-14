/*
 * Creado por SharpDevelop.
 * Usuario: CC1_PC32
 * Fecha: 10/12/2025
 * Hora: 02:03 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Conversion
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
			this.gpbTemperatura = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtIngresar = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cmbConvertir = new System.Windows.Forms.ComboBox();
			this.cmbGrados = new System.Windows.Forms.ComboBox();
			this.btnCalcualr = new System.Windows.Forms.Button();
			this.lblTemp = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.gpbLongitud = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.lblLong = new System.Windows.Forms.Label();
			this.btnCalcularLong = new System.Windows.Forms.Button();
			this.txtDistancia = new System.Windows.Forms.TextBox();
			this.cmbLogK = new System.Windows.Forms.ComboBox();
			this.cmbLongC = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.gpbMasa = new System.Windows.Forms.GroupBox();
			this.lblMasa = new System.Windows.Forms.Label();
			this.btnMasa = new System.Windows.Forms.Button();
			this.txtMasa = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.cmbConMasa = new System.Windows.Forms.ComboBox();
			this.label12 = new System.Windows.Forms.Label();
			this.cmbMasa = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.gpbTiempo = new System.Windows.Forms.GroupBox();
			this.lblTime = new System.Windows.Forms.Label();
			this.cmbConverTime = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.cmbTiempo = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtTiempo = new System.Windows.Forms.TextBox();
			this.btnCalcularTime = new System.Windows.Forms.Button();
			this.gpbTemperatura.SuspendLayout();
			this.gpbLongitud.SuspendLayout();
			this.gpbMasa.SuspendLayout();
			this.gpbTiempo.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.MediumAquamarine;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(223, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(270, 44);
			this.label1.TabIndex = 0;
			this.label1.Text = "Conversiones ";
			// 
			// gpbTemperatura
			// 
			this.gpbTemperatura.Controls.Add(this.label4);
			this.gpbTemperatura.Controls.Add(this.txtIngresar);
			this.gpbTemperatura.Controls.Add(this.label3);
			this.gpbTemperatura.Controls.Add(this.cmbConvertir);
			this.gpbTemperatura.Controls.Add(this.cmbGrados);
			this.gpbTemperatura.Controls.Add(this.btnCalcualr);
			this.gpbTemperatura.Controls.Add(this.lblTemp);
			this.gpbTemperatura.Controls.Add(this.label2);
			this.gpbTemperatura.Location = new System.Drawing.Point(25, 57);
			this.gpbTemperatura.Name = "gpbTemperatura";
			this.gpbTemperatura.Size = new System.Drawing.Size(301, 143);
			this.gpbTemperatura.TabIndex = 1;
			this.gpbTemperatura.TabStop = false;
			this.gpbTemperatura.Text = "Temperatura";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Yi Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(9, 62);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(132, 23);
			this.label4.TabIndex = 15;
			this.label4.Text = "Ingresa los grados:";
			// 
			// txtIngresar
			// 
			this.txtIngresar.Location = new System.Drawing.Point(9, 88);
			this.txtIngresar.Name = "txtIngresar";
			this.txtIngresar.Size = new System.Drawing.Size(100, 20);
			this.txtIngresar.TabIndex = 14;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(9, 12);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 13;
			this.label3.Text = "Grados";
			// 
			// cmbConvertir
			// 
			this.cmbConvertir.FormattingEnabled = true;
			this.cmbConvertir.Items.AddRange(new object[] {
			"celsius",
			"fahrenheit",
			"kelvin"});
			this.cmbConvertir.Location = new System.Drawing.Point(163, 38);
			this.cmbConvertir.Name = "cmbConvertir";
			this.cmbConvertir.Size = new System.Drawing.Size(121, 21);
			this.cmbConvertir.TabIndex = 12;
			// 
			// cmbGrados
			// 
			this.cmbGrados.FormattingEnabled = true;
			this.cmbGrados.Items.AddRange(new object[] {
			"celsius",
			"fahrenheit",
			"kelvin"});
			this.cmbGrados.Location = new System.Drawing.Point(6, 38);
			this.cmbGrados.Name = "cmbGrados";
			this.cmbGrados.Size = new System.Drawing.Size(121, 21);
			this.cmbGrados.TabIndex = 11;
			// 
			// btnCalcualr
			// 
			this.btnCalcualr.BackColor = System.Drawing.Color.CadetBlue;
			this.btnCalcualr.Location = new System.Drawing.Point(21, 114);
			this.btnCalcualr.Name = "btnCalcualr";
			this.btnCalcualr.Size = new System.Drawing.Size(75, 23);
			this.btnCalcualr.TabIndex = 10;
			this.btnCalcualr.Text = "Calcular";
			this.btnCalcualr.UseVisualStyleBackColor = false;
			this.btnCalcualr.Click += new System.EventHandler(this.BtnCalcualrClick);
			// 
			// lblTemp
			// 
			this.lblTemp.BackColor = System.Drawing.Color.MediumAquamarine;
			this.lblTemp.Location = new System.Drawing.Point(115, 114);
			this.lblTemp.Name = "lblTemp";
			this.lblTemp.Size = new System.Drawing.Size(169, 23);
			this.lblTemp.TabIndex = 9;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(175, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = "Convertir a:";
			// 
			// gpbLongitud
			// 
			this.gpbLongitud.Controls.Add(this.label7);
			this.gpbLongitud.Controls.Add(this.lblLong);
			this.gpbLongitud.Controls.Add(this.btnCalcularLong);
			this.gpbLongitud.Controls.Add(this.txtDistancia);
			this.gpbLongitud.Controls.Add(this.cmbLogK);
			this.gpbLongitud.Controls.Add(this.cmbLongC);
			this.gpbLongitud.Controls.Add(this.label5);
			this.gpbLongitud.Controls.Add(this.label6);
			this.gpbLongitud.Location = new System.Drawing.Point(399, 57);
			this.gpbLongitud.Name = "gpbLongitud";
			this.gpbLongitud.Size = new System.Drawing.Size(309, 143);
			this.gpbLongitud.TabIndex = 2;
			this.gpbLongitud.TabStop = false;
			this.gpbLongitud.Text = "Longitud";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Yi Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(6, 62);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(137, 23);
			this.label7.TabIndex = 16;
			this.label7.Text = "Ingresa la distancia:";
			// 
			// lblLong
			// 
			this.lblLong.BackColor = System.Drawing.Color.MediumAquamarine;
			this.lblLong.Location = new System.Drawing.Point(124, 114);
			this.lblLong.Name = "lblLong";
			this.lblLong.Size = new System.Drawing.Size(169, 23);
			this.lblLong.TabIndex = 16;
			// 
			// btnCalcularLong
			// 
			this.btnCalcularLong.BackColor = System.Drawing.Color.CadetBlue;
			this.btnCalcularLong.Location = new System.Drawing.Point(19, 114);
			this.btnCalcularLong.Name = "btnCalcularLong";
			this.btnCalcularLong.Size = new System.Drawing.Size(75, 23);
			this.btnCalcularLong.TabIndex = 16;
			this.btnCalcularLong.Text = "Calcular";
			this.btnCalcularLong.UseVisualStyleBackColor = false;
			this.btnCalcularLong.Click += new System.EventHandler(this.BtnCalcularLongClick);
			// 
			// txtDistancia
			// 
			this.txtDistancia.Location = new System.Drawing.Point(6, 88);
			this.txtDistancia.Name = "txtDistancia";
			this.txtDistancia.Size = new System.Drawing.Size(100, 20);
			this.txtDistancia.TabIndex = 20;
			// 
			// cmbLogK
			// 
			this.cmbLogK.FormattingEnabled = true;
			this.cmbLogK.Items.AddRange(new object[] {
			"metros",
			"centimetros",
			"pulgadas",
			"millas"});
			this.cmbLogK.Location = new System.Drawing.Point(172, 38);
			this.cmbLogK.Name = "cmbLogK";
			this.cmbLogK.Size = new System.Drawing.Size(121, 21);
			this.cmbLogK.TabIndex = 19;
			// 
			// cmbLongC
			// 
			this.cmbLongC.FormattingEnabled = true;
			this.cmbLongC.Items.AddRange(new object[] {
			"centimetros",
			"metros",
			"pulgadas",
			"millas"});
			this.cmbLongC.Location = new System.Drawing.Point(6, 38);
			this.cmbLongC.Name = "cmbLongC";
			this.cmbLongC.Size = new System.Drawing.Size(121, 21);
			this.cmbLongC.TabIndex = 18;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(6, 12);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(137, 23);
			this.label5.TabIndex = 17;
			this.label5.Text = "Unidad de medida";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(172, 16);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 16;
			this.label6.Text = "Convertir a:";
			// 
			// gpbMasa
			// 
			this.gpbMasa.Controls.Add(this.lblMasa);
			this.gpbMasa.Controls.Add(this.btnMasa);
			this.gpbMasa.Controls.Add(this.txtMasa);
			this.gpbMasa.Controls.Add(this.label13);
			this.gpbMasa.Controls.Add(this.cmbConMasa);
			this.gpbMasa.Controls.Add(this.label12);
			this.gpbMasa.Controls.Add(this.cmbMasa);
			this.gpbMasa.Controls.Add(this.label11);
			this.gpbMasa.Location = new System.Drawing.Point(399, 206);
			this.gpbMasa.Name = "gpbMasa";
			this.gpbMasa.Size = new System.Drawing.Size(309, 138);
			this.gpbMasa.TabIndex = 2;
			this.gpbMasa.TabStop = false;
			this.gpbMasa.Text = "Masa";
			// 
			// lblMasa
			// 
			this.lblMasa.BackColor = System.Drawing.Color.MediumAquamarine;
			this.lblMasa.Location = new System.Drawing.Point(124, 109);
			this.lblMasa.Name = "lblMasa";
			this.lblMasa.Size = new System.Drawing.Size(169, 23);
			this.lblMasa.TabIndex = 22;
			// 
			// btnMasa
			// 
			this.btnMasa.BackColor = System.Drawing.Color.CadetBlue;
			this.btnMasa.Location = new System.Drawing.Point(19, 109);
			this.btnMasa.Name = "btnMasa";
			this.btnMasa.Size = new System.Drawing.Size(75, 23);
			this.btnMasa.TabIndex = 22;
			this.btnMasa.Text = "Calcular";
			this.btnMasa.UseVisualStyleBackColor = false;
			this.btnMasa.Click += new System.EventHandler(this.BtnMasaClick);
			// 
			// txtMasa
			// 
			this.txtMasa.Location = new System.Drawing.Point(6, 83);
			this.txtMasa.Name = "txtMasa";
			this.txtMasa.Size = new System.Drawing.Size(100, 20);
			this.txtMasa.TabIndex = 22;
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Microsoft Yi Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(6, 57);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(137, 23);
			this.label13.TabIndex = 22;
			this.label13.Text = "ingresa la cantidad:";
			// 
			// cmbConMasa
			// 
			this.cmbConMasa.FormattingEnabled = true;
			this.cmbConMasa.Items.AddRange(new object[] {
			"kilogramo",
			"libra"});
			this.cmbConMasa.Location = new System.Drawing.Point(172, 33);
			this.cmbConMasa.Name = "cmbConMasa";
			this.cmbConMasa.Size = new System.Drawing.Size(121, 21);
			this.cmbConMasa.TabIndex = 22;
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(172, 16);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(100, 23);
			this.label12.TabIndex = 22;
			this.label12.Text = "Convertir a:";
			// 
			// cmbMasa
			// 
			this.cmbMasa.FormattingEnabled = true;
			this.cmbMasa.Items.AddRange(new object[] {
			"kilogramo",
			"libra"});
			this.cmbMasa.Location = new System.Drawing.Point(6, 33);
			this.cmbMasa.Name = "cmbMasa";
			this.cmbMasa.Size = new System.Drawing.Size(121, 21);
			this.cmbMasa.TabIndex = 22;
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(6, 16);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(137, 23);
			this.label11.TabIndex = 22;
			this.label11.Text = "Unidad de pesaje";
			// 
			// gpbTiempo
			// 
			this.gpbTiempo.Controls.Add(this.lblTime);
			this.gpbTiempo.Controls.Add(this.cmbConverTime);
			this.gpbTiempo.Controls.Add(this.label10);
			this.gpbTiempo.Controls.Add(this.cmbTiempo);
			this.gpbTiempo.Controls.Add(this.label9);
			this.gpbTiempo.Controls.Add(this.label8);
			this.gpbTiempo.Controls.Add(this.txtTiempo);
			this.gpbTiempo.Controls.Add(this.btnCalcularTime);
			this.gpbTiempo.Location = new System.Drawing.Point(25, 206);
			this.gpbTiempo.Name = "gpbTiempo";
			this.gpbTiempo.Size = new System.Drawing.Size(301, 138);
			this.gpbTiempo.TabIndex = 3;
			this.gpbTiempo.TabStop = false;
			this.gpbTiempo.Text = "Tiempo";
			// 
			// lblTime
			// 
			this.lblTime.BackColor = System.Drawing.Color.MediumAquamarine;
			this.lblTime.Location = new System.Drawing.Point(126, 109);
			this.lblTime.Name = "lblTime";
			this.lblTime.Size = new System.Drawing.Size(169, 23);
			this.lblTime.TabIndex = 21;
			// 
			// cmbConverTime
			// 
			this.cmbConverTime.FormattingEnabled = true;
			this.cmbConverTime.Items.AddRange(new object[] {
			"hora",
			"minuto",
			"segundo"});
			this.cmbConverTime.Location = new System.Drawing.Point(163, 33);
			this.cmbConverTime.Name = "cmbConverTime";
			this.cmbConverTime.Size = new System.Drawing.Size(121, 21);
			this.cmbConverTime.TabIndex = 21;
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(175, 16);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 23);
			this.label10.TabIndex = 21;
			this.label10.Text = "Convertir a:";
			// 
			// cmbTiempo
			// 
			this.cmbTiempo.FormattingEnabled = true;
			this.cmbTiempo.Items.AddRange(new object[] {
			"hora",
			"minuto",
			"segundo"});
			this.cmbTiempo.Location = new System.Drawing.Point(6, 33);
			this.cmbTiempo.Name = "cmbTiempo";
			this.cmbTiempo.Size = new System.Drawing.Size(121, 21);
			this.cmbTiempo.TabIndex = 21;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(4, 16);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(137, 23);
			this.label9.TabIndex = 21;
			this.label9.Text = "Unidad de tiempo";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Yi Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(6, 57);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(137, 23);
			this.label8.TabIndex = 21;
			this.label8.Text = "Ingresa el tiempo:";
			// 
			// txtTiempo
			// 
			this.txtTiempo.Location = new System.Drawing.Point(9, 83);
			this.txtTiempo.Name = "txtTiempo";
			this.txtTiempo.Size = new System.Drawing.Size(100, 20);
			this.txtTiempo.TabIndex = 21;
			// 
			// btnCalcularTime
			// 
			this.btnCalcularTime.BackColor = System.Drawing.Color.CadetBlue;
			this.btnCalcularTime.Location = new System.Drawing.Point(21, 109);
			this.btnCalcularTime.Name = "btnCalcularTime";
			this.btnCalcularTime.Size = new System.Drawing.Size(75, 23);
			this.btnCalcularTime.TabIndex = 21;
			this.btnCalcularTime.Text = "Calcular";
			this.btnCalcularTime.UseVisualStyleBackColor = false;
			this.btnCalcularTime.Click += new System.EventHandler(this.BtnCalcularTimeClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(738, 356);
			this.Controls.Add(this.gpbMasa);
			this.Controls.Add(this.gpbTiempo);
			this.Controls.Add(this.gpbLongitud);
			this.Controls.Add(this.gpbTemperatura);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "MainForm";
			this.Text = "Conversion";
			this.gpbTemperatura.ResumeLayout(false);
			this.gpbTemperatura.PerformLayout();
			this.gpbLongitud.ResumeLayout(false);
			this.gpbLongitud.PerformLayout();
			this.gpbMasa.ResumeLayout(false);
			this.gpbMasa.PerformLayout();
			this.gpbTiempo.ResumeLayout(false);
			this.gpbTiempo.PerformLayout();
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.ComboBox cmbConMasa;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txtMasa;
		private System.Windows.Forms.Button btnMasa;
		private System.Windows.Forms.Label lblMasa;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox cmbMasa;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.ComboBox cmbGrados;
		private System.Windows.Forms.ComboBox cmbConvertir;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtIngresar;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnCalcualr;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblTemp;
		private System.Windows.Forms.GroupBox gpbTiempo;
		private System.Windows.Forms.GroupBox gpbMasa;
		private System.Windows.Forms.GroupBox gpbLongitud;
		private System.Windows.Forms.GroupBox gpbTemperatura;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbLogK;
		private System.Windows.Forms.ComboBox cmbLongC;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lblLong;
		private System.Windows.Forms.Button btnCalcularLong;
		private System.Windows.Forms.TextBox txtDistancia;
		private System.Windows.Forms.Label lblTime;
		private System.Windows.Forms.ComboBox cmbConverTime;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox cmbTiempo;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtTiempo;
		private System.Windows.Forms.Button btnCalcularTime;
		
	}
}
