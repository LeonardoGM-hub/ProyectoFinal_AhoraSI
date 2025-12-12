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
	}
}
