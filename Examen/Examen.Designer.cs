/*
 * Created by SharpDevelop.
 * User: mario
 * Date: 08/05/2014
 * Time: 10:36 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Examen
{
	partial class Examen
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.numericUpDown = new System.Windows.Forms.NumericUpDown();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.checkBox4 = new System.Windows.Forms.CheckBox();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.comboBox = new System.Windows.Forms.ComboBox();
			this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(24, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(152, 42);
			this.label1.TabIndex = 0;
			this.label1.Text = "1- Numero de los estados de la republica mexicana?";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(24, 94);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(152, 31);
			this.label2.TabIndex = 1;
			this.label2.Text = "2-Paises aliados en la Segunda guerra mundial?";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(24, 235);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(136, 33);
			this.label3.TabIndex = 2;
			this.label3.Text = "3-Dictador de Italia durante la segunda gerra mundial?";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(222, 25);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(162, 43);
			this.label4.TabIndex = 3;
			this.label4.Text = "4-Enque continente se encuentra el pais tuvalu?";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(222, 118);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(162, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "5-Fecha del grito de Dolores";
			// 
			// numericUpDown
			// 
			this.numericUpDown.Location = new System.Drawing.Point(40, 71);
			this.numericUpDown.Maximum = new decimal(new int[] {
									31,
									0,
									0,
									0});
			this.numericUpDown.Name = "numericUpDown";
			this.numericUpDown.Size = new System.Drawing.Size(120, 20);
			this.numericUpDown.TabIndex = 5;
			this.numericUpDown.ValueChanged += new System.EventHandler(this.NumericUpDown1ValueChanged);
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(40, 128);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(104, 24);
			this.checkBox1.TabIndex = 6;
			this.checkBox1.Text = "Rusia";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// checkBox2
			// 
			this.checkBox2.Location = new System.Drawing.Point(40, 150);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(104, 23);
			this.checkBox2.TabIndex = 7;
			this.checkBox2.Text = "Japon";
			this.checkBox2.UseVisualStyleBackColor = true;
			this.checkBox2.CheckedChanged += new System.EventHandler(this.CheckBox2CheckedChanged);
			// 
			// checkBox3
			// 
			this.checkBox3.Location = new System.Drawing.Point(40, 179);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(104, 18);
			this.checkBox3.TabIndex = 8;
			this.checkBox3.Text = "Alemania";
			this.checkBox3.UseVisualStyleBackColor = true;
			this.checkBox3.CheckedChanged += new System.EventHandler(this.CheckBox3CheckedChanged);
			// 
			// checkBox4
			// 
			this.checkBox4.Location = new System.Drawing.Point(40, 203);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(104, 24);
			this.checkBox4.TabIndex = 9;
			this.checkBox4.Text = "Reino unido";
			this.checkBox4.UseVisualStyleBackColor = true;
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(40, 271);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(104, 24);
			this.radioButton1.TabIndex = 10;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Hitler";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(40, 294);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(104, 24);
			this.radioButton2.TabIndex = 11;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Mussolini";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton3
			// 
			this.radioButton3.Location = new System.Drawing.Point(40, 324);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(104, 24);
			this.radioButton3.TabIndex = 12;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "Berlusconi";
			this.radioButton3.UseVisualStyleBackColor = true;
			// 
			// comboBox
			// 
			this.comboBox.FormattingEnabled = true;
			this.comboBox.Items.AddRange(new object[] {
									"Asia",
									"Europa",
									"Oceania",
									"America",
									"Africa"});
			this.comboBox.Location = new System.Drawing.Point(222, 71);
			this.comboBox.Name = "comboBox";
			this.comboBox.Size = new System.Drawing.Size(121, 21);
			this.comboBox.TabIndex = 13;
			// 
			// monthCalendar1
			// 
			this.monthCalendar1.Location = new System.Drawing.Point(181, 150);
			this.monthCalendar1.Name = "monthCalendar1";
			this.monthCalendar1.TabIndex = 14;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(234, 324);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 15;
			this.button1.Text = "Terminar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// Examen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(409, 362);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.monthCalendar1);
			this.Controls.Add(this.comboBox);
			this.Controls.Add(this.radioButton3);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.checkBox4);
			this.Controls.Add(this.checkBox3);
			this.Controls.Add(this.checkBox2);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.numericUpDown);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Examen";
			this.Text = "Examen";
			this.Load += new System.EventHandler(this.ExamenLoad);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.MonthCalendar monthCalendar1;
		private System.Windows.Forms.ComboBox comboBox;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.CheckBox checkBox4;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.NumericUpDown numericUpDown;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
