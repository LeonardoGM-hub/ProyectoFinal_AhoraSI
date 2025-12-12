/*
 * Creado por SharpDevelop.
 * Usuario: Dell
 * Fecha: 08/12/2025
 * Hora: 02:44 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoFinalChino
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		int intentos = 0;
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
		
		void BtnAccederClick(object sender, EventArgs e)
		{
			if(txtUsuario.Text=="admin" && txtContra.Text=="123"){
			
				Form1 f=new Form1();
				f.Show();
				Hide();
			}
			else
    		{
        	intentos++;
        	MessageBox.Show("Usuario o contraseña incorrectos. Intentos: " + intentos + "/3");

        	if (intentos == 3)
        	{
        		MessageBox.Show("Has superado el número de intentos. El programa se cerrará.");
        		Application.Exit();
        		
        	}
           			
		}
	}
	}}
