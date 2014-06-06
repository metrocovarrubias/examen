/*
 * Created by SharpDevelop.
 * User: mario
 * Date: 08/05/2014
 * Time: 10:33 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Examen
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
		
		void MaskedTextBox1MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
		{
			
		}
	}
}
