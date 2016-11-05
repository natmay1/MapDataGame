using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
    
    namespace MapDataGame
{
    partial class Form1
    {
        static int numPoints = 100;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        Point[] pts = new Point[numPoints];

        int count = 0;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        private void addPoint(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown1 = new NumericUpDown();
            NumericUpDown numericUpDown2 = new NumericUpDown();
            numericUpDown1.Value = 5;
            numericUpDown1.Maximum = 2500;
            numericUpDown1.Minimum = -100;
            numericUpDown2.Value = 5;
            numericUpDown2.Maximum = 2500;
            numericUpDown2.Minimum = -100;

            pts[count++] = new Point((int)numericUpDown1.Value, (int)numericUpDown2.Value);

            for (int i=0; i <= count; i++)
            {
                int x = -10;
                int y = -10;

                if (i != 0)
                {
                    this.CreateGraphics().drawLine(new Pen(Brushes.Black, 4), new Point(x, y), pts[i - 1], pts[i]);
                }
            }
        }
    }
protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 246);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
    }
}

