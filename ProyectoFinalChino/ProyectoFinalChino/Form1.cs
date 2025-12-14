/*
 * Creado por SharpDevelop.
 * Usuario: Dell
 * Fecha: 08/12/2025
 * Hora: 03:08 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoFinalChino
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void PasteleriaToolStripMenuItemClick(object sender, EventArgs e)
		{
			Proyecto26.MainForm fmrPasteleria=new Proyecto26.MainForm();
			fmrPasteleria.MdiParent=this;
			fmrPasteleria.Show();
		}
		
		void Form1Load(object sender, EventArgs e)
		{
			
		}
		
		void BoletaCalificacionToolStripMenuItemClick(object sender, EventArgs e)
		{
			boleta_de_calificaciones.MainForm fmrBoleta = new boleta_de_calificaciones.MainForm();
			fmrBoleta.MdiParent=this;
			fmrBoleta.Show();
		}
		
		void FactorialToolStripMenuItem1Click(object sender, EventArgs e)
		{
			Factorial.MainForm fmrFactorial=new Factorial.MainForm();
			fmrFactorial.MdiParent=this;
			fmrFactorial.Show();
		}
		
		void FibonacciToolStripMenuItemClick(object sender, EventArgs e)
		{
			FIGURAS.MainForm frmFibonacci=new FIGURAS.MainForm();
			frmFibonacci.MdiParent=this;
			frmFibonacci.Show();
		}
		
		void CuadardoToolStripMenuItemClick(object sender, EventArgs e)
		{
			AreaCubo.MainForm fmrCubo=new AreaCubo.MainForm();
			fmrCubo.MdiParent=this;
			fmrCubo.Show();
		}
		
		void RectanguloToolStripMenuItemClick(object sender, EventArgs e)
		{
			AreaRectangulo.MainForm fmrRectangulo=new AreaRectangulo.MainForm();
			fmrRectangulo.MdiParent=this;
			fmrRectangulo.Show();
		}
		
		void TrianguloToolStripMenuItemClick(object sender, EventArgs e)
		{
			AreaTriangulo.MainForm fmrTriangulo=new AreaTriangulo.MainForm();
			fmrTriangulo.MdiParent=this;
			fmrTriangulo.Show();
		}
		
		void CircunferenciaToolStripMenuItemClick(object sender, EventArgs e)
		{
			PerimetroCircunferencia.MainForm fmrCircunferencia=new PerimetroCircunferencia.MainForm();
			fmrCircunferencia.MdiParent=this;
			fmrCircunferencia.Show();
		}
		
		void TrapecioToolStripMenuItemClick(object sender, EventArgs e)
		{
			PerimetroTrapécio.MainForm fmrTrapecio=new PerimetroTrapécio.MainForm();
			fmrTrapecio.MdiParent=this;
			fmrTrapecio.Show();
		}
		
		void EsferaToolStripMenuItemClick(object sender, EventArgs e)
		{
			VolumenEsfera.MainForm fmrEsfera=new VolumenEsfera.MainForm();
			fmrEsfera.MdiParent=this;
			fmrEsfera.Show();
		}
		
		void CuboToolStripMenuItemClick(object sender, EventArgs e)
		{
			VolumenCubo.MainForm fmrCuboo=new VolumenCubo.MainForm();
			fmrCuboo.MdiParent=this;
			fmrCuboo.Show();
		}
		
		void PiramideToolStripMenuItemClick(object sender, EventArgs e)
		{
			VolumenPiramide.MainForm fmrPiramide=new VolumenPiramide.MainForm();
			fmrPiramide.MdiParent=this;
			fmrPiramide.Show();
		}
		
		void ConversionesToolStripMenuItemClick(object sender, EventArgs e)
		{
			
		}
		
		void EmpleadosToolStripMenuItemClick(object sender, EventArgs e)
		{
			Empleados.MainForm fmrEmpleados=new Empleados.MainForm();
			fmrEmpleados.MdiParent=this;
			fmrEmpleados.Show();
		}
		
		void AcercaDeToolStripMenuItemClick(object sender, EventArgs e)
		{
			Form2 f= new Form2();
			f.Show();
			this.Hide();			
		}
		
		void SalirToolStripMenuItemClick(object sender, EventArgs e)
		{
			if (MessageBox.Show("¿Desea salir?","Confirmación",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes){
			Application.Exit();}			
		}
	}
}
