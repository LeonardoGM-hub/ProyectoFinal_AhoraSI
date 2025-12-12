/*
 * Created by SharpDevelop.
 * User: CC1_PC34
 * Date: 10/12/2025
 * Time: 02:29 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Factorial
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
		
		void BtnAplicarClick(object sender, EventArgs e)
		{
			int n = Convert.ToInt32(txtNum.Text);
			if(n <= 0){
				MessageBox.Show("El numero a ingresar debe ser positivo");
			}
			int m = n;
			lbFac.Items.Add(n);
			for(int i = n-1;i>1;i--){
				m = m = m * i;
				lbFac.Items.Add(m);
				
			}
		}
	}
}
