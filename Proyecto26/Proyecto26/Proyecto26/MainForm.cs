/*
 * Creado por SharpDevelop.
 * Usuario: CC1_PC32
 * Fecha: 08/12/2025
 * Hora: 02:24 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Proyecto26
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
		public bool AgregarProducto(string Producto, double Precio, int Cantidad, double Total)
		{
			MySqlConnection det = new MySqlConnection();
			det.ConnectionString = "server=127.0.0.1; database=Proyecto26; user=root; pwd=root;";
				det.Open();
				
				string strSQL = "insert into Ticket (Producto, Precio, Cantidad, Total)" +
	                 "values (@Producto, @Precio, @Cantidad, @Total)";
	            MySqlCommand comando = new MySqlCommand(strSQL, det);
	            comando.Parameters.AddWithValue("Producto", Producto);
	            comando.Parameters.AddWithValue("Precio", Precio);
	            comando.Parameters.AddWithValue("Cantidad", Cantidad);
	            comando.Parameters.AddWithValue("Total", Total);
            comando.ExecuteNonQuery();
            MessageBox.Show("Producto agregado");
            
            comando.Dispose();
            det.Close();
            det.Dispose();
            return true;
		}
		Dictionary<string, decimal> preciosProductos = new Dictionary<string, decimal>()
			{
			    { "Crepa Dulce", 70m },
			    { "Concha", 10m },
			    { "Donas", 20m },
			    { "Muffyn", 25m },
			
			    { "Crepa Salada", 65m },
			    { "Cuernito con Queso", 35m },
			    { "Baguet con Jamon", 60m },
			    { "Pretzel", 25m }
			};
		void RdbDulceCheckedChanged(object sender, EventArgs e)
		{
			cmbProductos.Items.Clear();
			if (rdbDulce.Checked){
			rdbDulce.ForeColor = Color.Green;
			rdbSalado.ForeColor = Color.Red;
			cmbProductos.Items.Add("Crepa Dulce");
			cmbProductos.Items.Add("Concha");
			cmbProductos.Items.Add("Donas");
			cmbProductos.Items.Add("Muffyn");
			}
		}
		
		void RdbSaladoCheckedChanged(object sender, EventArgs e)
		{
			cmbProductos.Items.Clear();
			if (rdbSalado.Checked){
			rdbDulce.ForeColor = Color.Red;
			rdbSalado.ForeColor = Color.Green;
			cmbProductos.Items.Add("Crepa Salada");
			cmbProductos.Items.Add("Cuernito con Queso");
			cmbProductos.Items.Add("Baguet con Jamon");
			cmbProductos.Items.Add("Pretzel");
			}
		}
		void CmbProductosSelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbProductos.SelectedItem == null)
			   return;
			
			    string producto = cmbProductos.SelectedItem.ToString();
			
			    if (preciosProductos.ContainsKey(producto))
			    {
			        txtPrecio.Text = preciosProductos[producto].ToString();
			    }
		}
		void TxtCantidadTextChanged(object sender, EventArgs e)
		{
			decimal precio, cantidad;

			    if (decimal.TryParse(txtPrecio.Text, out precio) &&
			        decimal.TryParse(txtCantidad.Text, out cantidad))
			    {
			        decimal total = precio * cantidad;
			        txtTotal.Text = total.ToString();
			    }
			    else
			    {
			        txtTotal.Text = "";
			    }
		}
		void BtnAgregarClick(object sender, EventArgs e)
		{
			string producto = cmbProductos.SelectedItem.ToString();
			    string precio = txtPrecio.Text;
			    string cantidad = txtCantidad.Text;
			    string total = txtTotal.Text;
			    ListViewItem item = new ListViewItem(producto);
			    item.SubItems.Add(precio);
			    item.SubItems.Add(cantidad);
			    item.SubItems.Add(total);
			    listView1.Items.Add(item);
			    
			    CalcularTotales();
		}
			private void CalcularTotales()
				{
				    decimal subtotal = 0;
				    int totalProductos = 0;
				    foreach (ListViewItem item in listView1.Items)
				    {
				        decimal totalProducto = Convert.ToDecimal(item.SubItems[3].Text);
				        int cantidad = Convert.ToInt32(item.SubItems[2].Text);
				        subtotal += totalProducto;
				        totalProductos += cantidad;
				    }
				    txtSubtotal.Text = subtotal.ToString();
				    CalcularDescuento(subtotal, totalProductos);
				}
			private void CalcularDescuento(decimal subtotal, int totalProductos)
				{
				    decimal descuento = 0;
				
				    bool masDeTresProductos = totalProductos > 3;
				    bool subtotalMayor200 = subtotal >= 200;
				
				    if (masDeTresProductos && subtotalMayor200)
				        descuento = subtotal * 0.15m;  
				    else if (masDeTresProductos)
				        descuento = subtotal * 0.07m;  
				    else if (subtotalMayor200)
				        descuento = subtotal * 0.10m;   
				
				    txtDescuento.Text = descuento.ToString();
				
				    decimal importeFinal = subtotal - descuento;
				    txtImporte.Text = importeFinal.ToString();
				}
		void BtnEliminarClick(object sender, EventArgs e)
		{
			    if (listView1.Items.Count > 0)
			    {
			        listView1.Items.RemoveAt(listView1.Items.Count - 1);
			        CalcularTotales();
			    }
		}
		void BtnBorrarClick(object sender, EventArgs e)
		{
			listView1.Items.Clear();
				
				    txtPrecio.Clear();
				    txtCantidad.Clear();
				    txtTotal.Clear();
				
				    txtSubtotal.Clear();
				    txtDescuento.Clear();
				    txtImporte.Clear();
				    cmbProductos.SelectedIndex = -1;
		}
		void BtnSalirClick(object sender, EventArgs e)
		{
			this.Close();
		}
		void Button3Click(object sender, EventArgs e)
		{
			foreach (ListViewItem item in listView1.Items)
   			 {
		        string producto = item.SubItems[0].Text;
		        double precio = Convert.ToDouble(item.SubItems[1].Text);
		        int cantidad = Convert.ToInt32(item.SubItems[2].Text);
		        double total = Convert.ToDouble(item.SubItems[3].Text);

			    AgregarProducto(producto, precio, cantidad, total);
			 }
		    MessageBox.Show("Su ticket se ha guardado en la base de datos e impreso");
		}
	}
}
