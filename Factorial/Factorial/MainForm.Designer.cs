/*
 * Created by SharpDevelop.
 * User: CC1_PC34
 * Date: 10/12/2025
 * Time: 02:29 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Factorial
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label1 = new System.Windows.Forms.Label();
			this.txtNum = new System.Windows.Forms.TextBox();
			this.btnAplicar = new System.Windows.Forms.Button();
			this.lbFac = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(18, 29);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(226, 35);
			this.label1.TabIndex = 0;
			this.label1.Text = "Introdusca un numero:";
			// 
			// txtNum
			// 
			this.txtNum.Location = new System.Drawing.Point(254, 28);
			this.txtNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txtNum.Name = "txtNum";
			this.txtNum.Size = new System.Drawing.Size(148, 26);
			this.txtNum.TabIndex = 1;
			// 
			// btnAplicar
			// 
			this.btnAplicar.Location = new System.Drawing.Point(18, 90);
			this.btnAplicar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnAplicar.Name = "btnAplicar";
			this.btnAplicar.Size = new System.Drawing.Size(112, 35);
			this.btnAplicar.TabIndex = 2;
			this.btnAplicar.Text = "Aplicar";
			this.btnAplicar.UseVisualStyleBackColor = true;
			this.btnAplicar.Click += new System.EventHandler(this.BtnAplicarClick);
			// 
			// lbFac
			// 
			this.lbFac.FormattingEnabled = true;
			this.lbFac.ItemHeight = 20;
			this.lbFac.Location = new System.Drawing.Point(18, 135);
			this.lbFac.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.lbFac.Name = "lbFac";
			this.lbFac.Size = new System.Drawing.Size(384, 244);
			this.lbFac.TabIndex = 3;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(426, 402);
			this.Controls.Add(this.lbFac);
			this.Controls.Add(this.btnAplicar);
			this.Controls.Add(this.txtNum);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "MainForm";
			this.Text = "Factorial";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ListBox lbFac;
		private System.Windows.Forms.Button btnAplicar;
		private System.Windows.Forms.TextBox txtNum;
		private System.Windows.Forms.Label label1;
	}
}
