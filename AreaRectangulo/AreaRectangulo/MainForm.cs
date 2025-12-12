/*
 * Creado por SharpDevelop.
 * Usuario: josue
 * Fecha: 11/12/2025
 * Hora: 08:26 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AreaRectangulo
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			Close();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			double A,B,Area;
			A = Convert.ToDouble(textBox1.Text);
			B = Convert.ToDouble(textBox2.Text);
			Area = A * B;
			label4.Text= Area.ToString();
		}
	}
}
