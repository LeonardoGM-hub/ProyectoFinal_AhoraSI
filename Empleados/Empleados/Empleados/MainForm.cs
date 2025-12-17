/*
 * Created by SharpDevelop.
 * User: CC1_PC34
 * Date: 08/12/2025
 * Time: 02:45 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing.Drawing2D;

namespace Empleados
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
		
		
		void BtnGuardarClick(object sender, EventArgs e)
		{
			
			if(txtCodigo.Text == ""){
				errpError.SetError(txtCodigo, "Debe introducir su codigo");
			}
			if(txtNombre.Text == ""){
				errpError.SetError(txtNombre, "Debe introducir un nombre");
			}
			if(cmbPuesto.Text == ""){
				errpError.SetError(cmbPuesto, "Debe introducir su puesto");
			}
			if(txtFecha.Text == ""){
				errpError.SetError(txtFecha, "Debe introducir un nombre");
			}
			if(cmbSexo.Text == ""){
				errpError.SetError(cmbSexo, "Debe introducir su puesto");
			}
			
			int C;
			string PUS,sex;
			string Estado = string.Empty;
			PUS = Convert.ToString(cmbPuesto.Text);
			sex = Convert.ToString(cmbSexo.Text);
			C = Convert.ToInt32(txtCodigo.Text);
			if(rdbRegular.Checked){
				Estado = "Regular";
			}
			if(rdbContratado.Checked){
				Estado = "Contratado";
			}
			
			string wza = "server=localhost; database=Empleados; uid=root; pwd=;";
			
			MySqlConnection cnn = new MySqlConnection(wza);
			cnn.Open();
			
			
			cnn.Close();
			
			
			dgvDatos.Rows.Add(
			
				txtCodigo.Text,
				txtNombre.Text,
				cmbPuesto.Text,
				txtFecha.Text,
				cmbSexo.Text,
				Estado
			);
		}
		
		void BtnLimpiarClick(object sender, EventArgs e)
		{
			txtCodigo.Text="";
			txtNombre.Text="";
			cmbPuesto.Text="";
			txtFecha.Text="";
			cmbSexo.Text="";
			rdbRegular.Checked=false;
			rdbContratado.Checked=false;
		}
		
		void BtnEliminarClick(object sender, EventArgs e)
		{
			dgvDatos.Rows.Remove(dgvDatos.CurrentRow);
		}
		
		void BtnQuitarClick(object sender, EventArgs e)
		{
			pbEmpleado.Visible=false;
		}
		
		void BtnActualizarClick(object sender, EventArgs e)
		{
			if(pbEmpleado.Visible == true){
				MessageBox.Show("No hay imagen que cargar");
			}
			else{
				pbEmpleado.Visible=true;
			}
		}
	}
}
