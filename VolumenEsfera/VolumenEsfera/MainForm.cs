/*
 * Creado por SharpDevelop.
 * Usuario: josue
 * Fecha: 10/12/2025
 * Hora: 05:28 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace VolumenEsfera
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
			double r,vol;
			r = Convert.ToDouble(txtRadio.Text);
			vol = (4/3) * 3.1416 * (r*r*r);
			lblVolumen.Text = vol.ToString();
		}
	}
}
