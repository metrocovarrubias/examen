/*
 * Created by SharpDevelop.
 * User: mario
 * Date: 08/05/2014
 * Time: 10:36 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Examen
{
	/// <summary>
	/// Description of Examen.
	/// </summary>
	public partial class Examen : Form
	{
		public Examen()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void CheckBox3CheckedChanged(object sender, EventArgs e)
		{
			
		}
		
		void NumericUpDown1ValueChanged(object sender, EventArgs e)
		{
			
		}
		
		void ExamenLoad(object sender, EventArgs e)
		{
			
		}
		
		void CheckBox2CheckedChanged(object sender, EventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
{
		
			string estados = this.numericUpDown.Text;
			string continente = this.comboBox.Text;
			/*string nombre =this.textBox1.Text;
			string codigo =this.password.Text;
			*/
			int calificacion=0;
			
			if (estados == "31"){
			 calificacion++;
			}
			if(checkBox1.Checked){
				calificacion ++;
			}
			if(checkBox4.Checked){
				calificacion++;
			}
			if(radioButton2.Checked){
				calificacion++;
			}
			if(continente == "Oceania"){
				calificacion++;
			}
			if(this.monthCalendar1.SelectionStart.Date.ToShortDateString() == "16/09/1810"){
				calificacion++;
			}
			MessageBox.Show( "tu calificacion es de " +calificacion +" de 6");  					


			}
		}
		}
	}
