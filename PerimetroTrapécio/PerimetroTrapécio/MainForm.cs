/*
 * Creado por SharpDevelop.
 * Usuario: josue
 * Fecha: 10/12/2025
 * Hora: 06:20 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PerimetroTrapécio
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
		
		void Button1Click(object sender, EventArgs e)
		{
			double a,b,c,p;
			a = Convert.ToDouble(textBox1.Text);
			b = Convert.ToDouble(textBox2.Text);
			c = Convert.ToDouble(textBox3.Text);
			p = a + b + c;
			label5.Text=p.ToString();
		}
	}
}
