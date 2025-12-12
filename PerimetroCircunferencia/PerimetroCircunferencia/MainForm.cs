/*
 * Creado por SharpDevelop.
 * Usuario: josue
 * Fecha: 10/12/2025
 * Hora: 06:10 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PerimetroCircunferencia
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
			double p,r;
			r = Convert.ToDouble(textBox1.Text);
			p = 2 * 3.1416 * r;
			label3.Text = p.ToString();
		}
	}
}
