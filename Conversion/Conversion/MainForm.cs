/*
 * Creado por SharpDevelop.
 * Usuario: CC1_PC32
 * Fecha: 10/12/2025
 * Hora: 02:03 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace Conversion
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		double resultado;
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
		void BtnCalcualrClick(object sender, EventArgs e)
		{
			string tipoGrados = cmbGrados.Text.ToLower();
			string convertirA = cmbConvertir.Text.ToLower();
			double grados;
			if (!double.TryParse(txtIngresar.Text, out grados))
				{
				    MessageBox.Show("Valor numérico no válido.");
				    return;
				}
            if (tipoGrados == "celsius")
				{
				    if (convertirA == "fahrenheit")
				        resultado = (grados * 9 / 5) + 32;
				    else if (convertirA == "kelvin")
				        resultado = grados + 273.15;
				    else
				        resultado = grados;
				}
				else if (tipoGrados == "fahrenheit")
				{
				    if (convertirA == "celsius")
				        resultado = (grados - 32) * 5 / 9;
				    else if (convertirA == "kelvin")
				        resultado = (grados - 32) * 5 / 9 + 273.15;
				    else
				        resultado = grados;
				}
				else if (tipoGrados == "kelvin")
				{
				    if (convertirA == "celsius")
				        resultado = grados - 273.15;
				    else if (convertirA == "fahrenheit")
				        resultado = (grados - 273.15) * 9 / 5 + 32;
				    else
				        resultado = grados;
				}
				lblTemp.Text = "Resultado: " + resultado.ToString();
		}
		void BtnCalcularLongClick(object sender, EventArgs e)
		{
			string tipoUnidad = cmbLongC.Text.ToLower();
			string convertirA = cmbLogK.Text.ToLower();
			double Longitud;
			if (!double.TryParse(txtDistancia.Text, out Longitud))
				{
				    MessageBox.Show("Valor numérico no válido.");
				    return;
				}
            if (tipoUnidad == "centimetros")
				{
				    if (convertirA == "metros")
				        resultado = (Longitud / 100);
				    else if (convertirA == "pulgadas")
				        resultado = Longitud / 2.54;
				    else if (convertirA == "millas")
				        resultado = Longitud / 160934;
				    else
				        resultado = Longitud;
				}
				else if (tipoUnidad == "metros")
				{
				    if (convertirA == "centimetros")
				        resultado = (Longitud * 100);
				    else if (convertirA == "pulgadas")
				        resultado = (Longitud * 39.3701);
				    else if (convertirA == "millas")
				        resultado = Longitud / 1609.34;
				    else
				        resultado = Longitud;
				}
				else if (tipoUnidad == "pulgadas")
				{
				    if (convertirA == "metros")
				        resultado = Longitud / 39.3701;
				    else if (convertirA == "centimetros")
				        resultado = (Longitud * 2.54);
				    else if (convertirA == "millas")
				        resultado = Longitud / 63360;
				    else
				        resultado = Longitud;
				}
				else if (tipoUnidad == "millas")
				{
				    if (convertirA == "metros")
				        resultado = Longitud * 1609.34;
				    else if (convertirA == "centimetros")
				        resultado = (Longitud * 160934);
				    else if (convertirA == "pulgadas")
				        resultado = Longitud * 63360;
				    else
				        resultado = Longitud;
				}
				lblLong.Text = "Resultado: " + resultado.ToString();
		}
		void BtnCalcularTimeClick(object sender, EventArgs e)
		{
			string tipoTime = cmbTiempo.Text.ToLower();
			string convertirA = cmbConverTime.Text.ToLower();
			double tiempo;
			if (!double.TryParse(txtTiempo.Text, out tiempo))
				{
				    MessageBox.Show("Valor numérico no válido.");
				    return;
				}
            if (tipoTime == "hora")
				{
				    if (convertirA == "minuto")
				        resultado = (tiempo * 60);
				    else if (convertirA == "segundo")
				        resultado = tiempo * 3600;
				    else
				        resultado = tiempo;
				}
				else if (tipoTime == "minuto")
				{
				    if (convertirA == "hora")
				        resultado = tiempo / 60;
				    else if (convertirA == "segundo")
				        resultado = tiempo * 60;
				    else
				        resultado = tiempo;
				}
				else if (tipoTime == "segundo")
				{
				    if (convertirA == "hora")
				        resultado = tiempo / 3600;
				    else if (convertirA == "minuto")
				        resultado = tiempo / 60;
				    else
				        resultado = tiempo;
				}
				lblTime.Text = "Resultado: " + resultado.ToString();
		}
		
		void BtnMasaClick(object sender, EventArgs e)
		{
			string tipoPeso = cmbMasa.Text.ToLower();
			string convertirA = cmbConMasa.Text.ToLower();
			double peso;
			if (!double.TryParse(txtMasa.Text, out peso))
				{
				    MessageBox.Show("Valor numérico no válido.");
				    return;
				}
            if (tipoPeso == "kilogramo")
				{
				    if (convertirA == "libra")
				        resultado = peso * 2.20462;
				    else
				        resultado = peso;
				}
				else if (tipoPeso == "libra")
				{
				    if (convertirA == "kilogramo")
				        resultado = peso / 2.20462;
				    else
				        resultado = peso;
				}
				lblMasa.Text = "Resultado: " + resultado.ToString();
		}
	}
}
