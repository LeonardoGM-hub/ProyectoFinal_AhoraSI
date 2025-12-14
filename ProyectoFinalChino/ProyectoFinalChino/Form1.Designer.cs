/*
 * Creado por SharpDevelop.
 * Usuario: Dell
 * Fecha: 08/12/2025
 * Hora: 03:08 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace ProyectoFinalChino
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.factorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fibonacciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.factorialToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.areaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cuadardoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rectanguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.trianguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.perimetroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.circunferenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.trapecioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.volumenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.esferaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cuboToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.piramideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.conversionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.boletaCalificacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pasteleriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.factorialToolStripMenuItem,
									this.areaToolStripMenuItem,
									this.perimetroToolStripMenuItem,
									this.volumenToolStripMenuItem,
									this.conversionesToolStripMenuItem,
									this.boletaCalificacionToolStripMenuItem,
									this.pasteleriaToolStripMenuItem,
									this.empleadosToolStripMenuItem,
									this.acercaDeToolStripMenuItem,
									this.salirToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1265, 33);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// factorialToolStripMenuItem
			// 
			this.factorialToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fibonacciToolStripMenuItem,
									this.factorialToolStripMenuItem1});
			this.factorialToolStripMenuItem.Name = "factorialToolStripMenuItem";
			this.factorialToolStripMenuItem.Size = new System.Drawing.Size(122, 29);
			this.factorialToolStripMenuItem.Text = "Aplicaciones";
			// 
			// fibonacciToolStripMenuItem
			// 
			this.fibonacciToolStripMenuItem.Name = "fibonacciToolStripMenuItem";
			this.fibonacciToolStripMenuItem.Size = new System.Drawing.Size(158, 30);
			this.fibonacciToolStripMenuItem.Text = "Fibonacci";
			this.fibonacciToolStripMenuItem.Click += new System.EventHandler(this.FibonacciToolStripMenuItemClick);
			// 
			// factorialToolStripMenuItem1
			// 
			this.factorialToolStripMenuItem1.Name = "factorialToolStripMenuItem1";
			this.factorialToolStripMenuItem1.Size = new System.Drawing.Size(158, 30);
			this.factorialToolStripMenuItem1.Text = "Factorial";
			this.factorialToolStripMenuItem1.Click += new System.EventHandler(this.FactorialToolStripMenuItem1Click);
			// 
			// areaToolStripMenuItem
			// 
			this.areaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.cuadardoToolStripMenuItem,
									this.rectanguloToolStripMenuItem,
									this.trianguloToolStripMenuItem});
			this.areaToolStripMenuItem.Name = "areaToolStripMenuItem";
			this.areaToolStripMenuItem.Size = new System.Drawing.Size(60, 29);
			this.areaToolStripMenuItem.Text = "Area";
			// 
			// cuadardoToolStripMenuItem
			// 
			this.cuadardoToolStripMenuItem.Name = "cuadardoToolStripMenuItem";
			this.cuadardoToolStripMenuItem.Size = new System.Drawing.Size(172, 30);
			this.cuadardoToolStripMenuItem.Text = "Cuadrado";
			this.cuadardoToolStripMenuItem.Click += new System.EventHandler(this.CuadardoToolStripMenuItemClick);
			// 
			// rectanguloToolStripMenuItem
			// 
			this.rectanguloToolStripMenuItem.Name = "rectanguloToolStripMenuItem";
			this.rectanguloToolStripMenuItem.Size = new System.Drawing.Size(172, 30);
			this.rectanguloToolStripMenuItem.Text = "Rectangulo";
			this.rectanguloToolStripMenuItem.Click += new System.EventHandler(this.RectanguloToolStripMenuItemClick);
			// 
			// trianguloToolStripMenuItem
			// 
			this.trianguloToolStripMenuItem.Name = "trianguloToolStripMenuItem";
			this.trianguloToolStripMenuItem.Size = new System.Drawing.Size(172, 30);
			this.trianguloToolStripMenuItem.Text = "Triangulo";
			this.trianguloToolStripMenuItem.Click += new System.EventHandler(this.TrianguloToolStripMenuItemClick);
			// 
			// perimetroToolStripMenuItem
			// 
			this.perimetroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.circunferenciaToolStripMenuItem,
									this.trapecioToolStripMenuItem});
			this.perimetroToolStripMenuItem.Name = "perimetroToolStripMenuItem";
			this.perimetroToolStripMenuItem.Size = new System.Drawing.Size(100, 29);
			this.perimetroToolStripMenuItem.Text = "Perimetro";
			// 
			// circunferenciaToolStripMenuItem
			// 
			this.circunferenciaToolStripMenuItem.Name = "circunferenciaToolStripMenuItem";
			this.circunferenciaToolStripMenuItem.Size = new System.Drawing.Size(194, 30);
			this.circunferenciaToolStripMenuItem.Text = "Circunferencia";
			this.circunferenciaToolStripMenuItem.Click += new System.EventHandler(this.CircunferenciaToolStripMenuItemClick);
			// 
			// trapecioToolStripMenuItem
			// 
			this.trapecioToolStripMenuItem.Name = "trapecioToolStripMenuItem";
			this.trapecioToolStripMenuItem.Size = new System.Drawing.Size(194, 30);
			this.trapecioToolStripMenuItem.Text = "Trapecio";
			this.trapecioToolStripMenuItem.Click += new System.EventHandler(this.TrapecioToolStripMenuItemClick);
			// 
			// volumenToolStripMenuItem
			// 
			this.volumenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.esferaToolStripMenuItem,
									this.cuboToolStripMenuItem,
									this.piramideToolStripMenuItem});
			this.volumenToolStripMenuItem.Name = "volumenToolStripMenuItem";
			this.volumenToolStripMenuItem.Size = new System.Drawing.Size(94, 29);
			this.volumenToolStripMenuItem.Text = "Volumen";
			// 
			// esferaToolStripMenuItem
			// 
			this.esferaToolStripMenuItem.Name = "esferaToolStripMenuItem";
			this.esferaToolStripMenuItem.Size = new System.Drawing.Size(153, 30);
			this.esferaToolStripMenuItem.Text = "Esfera";
			this.esferaToolStripMenuItem.Click += new System.EventHandler(this.EsferaToolStripMenuItemClick);
			// 
			// cuboToolStripMenuItem
			// 
			this.cuboToolStripMenuItem.Name = "cuboToolStripMenuItem";
			this.cuboToolStripMenuItem.Size = new System.Drawing.Size(153, 30);
			this.cuboToolStripMenuItem.Text = "Cubo";
			this.cuboToolStripMenuItem.Click += new System.EventHandler(this.CuboToolStripMenuItemClick);
			// 
			// piramideToolStripMenuItem
			// 
			this.piramideToolStripMenuItem.Name = "piramideToolStripMenuItem";
			this.piramideToolStripMenuItem.Size = new System.Drawing.Size(153, 30);
			this.piramideToolStripMenuItem.Text = "Piramide";
			this.piramideToolStripMenuItem.Click += new System.EventHandler(this.PiramideToolStripMenuItemClick);
			// 
			// conversionesToolStripMenuItem
			// 
			this.conversionesToolStripMenuItem.Name = "conversionesToolStripMenuItem";
			this.conversionesToolStripMenuItem.Size = new System.Drawing.Size(130, 29);
			this.conversionesToolStripMenuItem.Text = "Conversiones";
			this.conversionesToolStripMenuItem.Click += new System.EventHandler(this.ConversionesToolStripMenuItemClick);
			// 
			// boletaCalificacionToolStripMenuItem
			// 
			this.boletaCalificacionToolStripMenuItem.Name = "boletaCalificacionToolStripMenuItem";
			this.boletaCalificacionToolStripMenuItem.Size = new System.Drawing.Size(168, 29);
			this.boletaCalificacionToolStripMenuItem.Text = "Boleta/Calificacion";
			this.boletaCalificacionToolStripMenuItem.Click += new System.EventHandler(this.BoletaCalificacionToolStripMenuItemClick);
			// 
			// pasteleriaToolStripMenuItem
			// 
			this.pasteleriaToolStripMenuItem.Name = "pasteleriaToolStripMenuItem";
			this.pasteleriaToolStripMenuItem.Size = new System.Drawing.Size(97, 29);
			this.pasteleriaToolStripMenuItem.Text = "Pasteleria";
			this.pasteleriaToolStripMenuItem.Click += new System.EventHandler(this.PasteleriaToolStripMenuItemClick);
			// 
			// empleadosToolStripMenuItem
			// 
			this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
			this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(112, 29);
			this.empleadosToolStripMenuItem.Text = "Empleados";
			this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.EmpleadosToolStripMenuItemClick);
			// 
			// acercaDeToolStripMenuItem
			// 
			this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
			this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(113, 29);
			this.acercaDeToolStripMenuItem.Text = "Acerca de...";
			this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.AcercaDeToolStripMenuItemClick);
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(57, 29);
			this.salirToolStripMenuItem.Text = "Salir";
			this.salirToolStripMenuItem.Click += new System.EventHandler(this.SalirToolStripMenuItemClick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(1265, 677);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem piramideToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cuboToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem esferaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem trapecioToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem circunferenciaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem trianguloToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem rectanguloToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cuadardoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem factorialToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem fibonacciToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pasteleriaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem boletaCalificacionToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem conversionesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem volumenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem perimetroToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem areaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem factorialToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
	}
}
