/*
 * Created by SharpDevelop.
 * User: CC1_PC34
 * Date: 10/12/2025
 * Time: 12:53 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FIGURAS
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
				MessageBox.Show("Introdusca un numero positivo");
			}
			int x=0,y=1,z;
			lbAp.Items.Add("1");
			for(int i = 1;i<n;i++){
				z = x + y;
				x = y;
				y = z;
				z=lbAp.Items.Add(z);
			}
		}
	}
}
