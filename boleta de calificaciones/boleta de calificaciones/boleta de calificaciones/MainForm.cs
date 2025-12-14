/*
 * Creado por SharpDevelop.
 * Usuario: asus
 * Fecha: 20/11/2025
 * Hora: 01:36 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace boleta_de_calificaciones
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		 int glo = 0;
		 double n = 0.0, d=0;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			string Asignatura;
			string Grado;
			string Especialidad;
		    Asignatura=cbbMateria.Text;
		    Grado=cbbGrado.Text;
		    Especialidad=cbbEspecialidad.Text;
		   
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			lblFecha.Text=DateTime.Today.Date.ToString("");
		}
		
		void BtnSalirClick(object sender, EventArgs e)
		{
			Close();
		}
		
		void BtnRegistrarClick(object sender, EventArgs e)
		{
			glo++;
			double a, b, c, x=1;
			string rep;
			a = Double.Parse(txt1.Text);
			b = Double.Parse(txt2.Text);
			c = Double.Parse(txt3.Text);
			for (int i = 1; i <= glo; i++) {
				d= (a+b+c)/3;
				}
			
			
			if(d >= 6){
				rep="Aprobado";
			}
			else{
				rep="Reprobado";
			}
			ListViewItem fila = new ListViewItem(cbbMateria.Text);
				fila.SubItems.Add(a.ToString());
				fila.SubItems.Add(b.ToString());
				fila.SubItems.Add(c.ToString());
				fila.SubItems.Add(d.ToString());
				fila.SubItems.Add(rep.ToString());
				lvTabla.Items.Add(fila);
				
			n+=d;
			this.lblPromedio.Text=(n/glo).ToString();
			
		}
		
		void BtnCancelarClick(object sender, EventArgs e)
		{
			txt1.Text = " ";
			txt2.Text = " ";
			txt3.Text = " ";
			cbbEspecialidad.Text = "Establece una Especialidad";
			cbbGrado.Text = "Establece un Grado";
			cbbMateria.Text = "Establece una Asignatura";
			txtNombre.Clear();
		}
		
		void CbbMateriaSelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		void LblPromedioClick(object sender, EventArgs e)
		{
			
		
		}
	}
}
