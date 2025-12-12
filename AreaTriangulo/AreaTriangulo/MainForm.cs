/*
 * Creado por SharpDevelop.
 * Usuario: josue
 * Fecha: 11/12/2025
 * Hora: 08:37 a. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AreaTriangulo
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
			double l,area;
			l = Convert.ToDouble(textBox1.Text);
			area = (l*l)/2;
			label3.Text=area.ToString();
		}
	}
}
