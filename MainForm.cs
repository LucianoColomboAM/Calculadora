/*
 * Created by SharpDevelop.
 * User: LAB05
 * Date: 26/3/2018
 * Time: 7:56 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Zalculadora
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
		public double n1;
		
		void Button1Click(object sender, EventArgs e)
		{
			label2.Text=(label2.Text+"1");
			
			}
		
		void Button2Click(object sender, EventArgs e)
		{
			label2.Text=(label2.Text+"2");
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			label2.Text=(label2.Text+"3");
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			label2.Text=(label2.Text+"4");
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			label2.Text=(label2.Text+"5");
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			label2.Text=(label2.Text+"6");
		}
		
		void Button7Click(object sender, EventArgs e)
		{
			label2.Text=(label2.Text+"7");
		}
		
		void Button8Click(object sender, EventArgs e)
		{
			label2.Text=(label2.Text+"8");
		}
		
		void Button9Click(object sender, EventArgs e)
		{
			label2.Text=(label2.Text+"9");
		}
		
		void Button0Click(object sender, EventArgs e)
		{
			label2.Text=(label2.Text+"0");
		}
		
		
	
		

		
		
		
		
		
		
		
		
		
		
		void Button10Click(object sender, EventArgs e)
		{
			
		}
		
		void Button11Click(object sender, EventArgs e)
		{
			label2.Text=(label2.Text=" ");			
		}
		
		void Button12Click(object sender, EventArgs e)
		{
			int borrar1=((Convert.ToString(label2.Text)).Length)-1;
			string resultado1=label2.Text.Remove(borrar1);
			label2.Text=resultado1;
		}
		
		void ButtonmasClick(object sender, EventArgs e)
		{
			n1=Convert.ToDouble(label2.Text);
			label2.Text=" ";				
		}
		
		void ButtonmenosClick(object sender, EventArgs e)
		{
			n1=Convert.ToDouble(label2.Text);
			label2.Text=" ";		
		}
		
		void ButtonmultiplicarClick(object sender, EventArgs e)
		{
			n1=Convert.ToDouble(label2.Text);
			label2.Text=" ";			
		}
		
		void ButtondivisionClick(object sender, EventArgs e)
		{
			n1=Convert.ToDouble(label2.Text);
			label2.Text=" ";					
		}
		
		void ButtonigualClick(object sender, EventArgs e)
		{
			
		}
		
		void ButtoncomaClick(object sender, EventArgs e)
		{
				label2.Text=(label2.Text+",");			
		}
	
		
		void LabelresultadoClick(object sender, EventArgs e)
		{
			
		}
		
		void LabelcuentaClick(object sender, EventArgs e)
		{
			
		}
	}
}
