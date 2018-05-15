﻿namespace _10.Turtle_Graphics
{
    partial class FormThurtleGraphics2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.buttonDraw = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonShowHideTurtle = new System.Windows.Forms.Button();
            this.buttonHexagon = new System.Windows.Forms.Button();
            this.buttonStar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDraw
            // 
            this.buttonDraw.Location = new System.Drawing.Point(21, 28);
            this.buttonDraw.Name = "buttonDraw";
            this.buttonDraw.Size = new System.Drawing.Size(75, 32);
            this.buttonDraw.TabIndex = 0;
            this.buttonDraw.Text = "Draw";
            this.buttonDraw.UseVisualStyleBackColor = true;
            this.buttonDraw.Click += new System.EventHandler(this.buttonDraw_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(21, 76);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 34);
            this.buttonReset.TabIndex = 1;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonShowHideTurtle
            // 
            this.buttonShowHideTurtle.Location = new System.Drawing.Point(21, 128);
            this.buttonShowHideTurtle.Name = "buttonShowHideTurtle";
            this.buttonShowHideTurtle.Size = new System.Drawing.Size(75, 33);
            this.buttonShowHideTurtle.TabIndex = 2;
            this.buttonShowHideTurtle.Text = "Hide Thurtle";
            this.buttonShowHideTurtle.UseVisualStyleBackColor = true;
            this.buttonShowHideTurtle.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonHexagon
            // 
            this.buttonHexagon.Location = new System.Drawing.Point(21, 181);
            this.buttonHexagon.Name = "buttonHexagon";
            this.buttonHexagon.Size = new System.Drawing.Size(75, 33);
            this.buttonHexagon.TabIndex = 3;
            this.buttonHexagon.Text = "Hexagon";
            this.buttonHexagon.UseVisualStyleBackColor = true;
            this.buttonHexagon.Click += new System.EventHandler(this.buttonHexagon_Click);
            // 
            // buttonStar
            // 
            this.buttonStar.Location = new System.Drawing.Point(21, 231);
            this.buttonStar.Name = "buttonStar";
            this.buttonStar.Size = new System.Drawing.Size(75, 29);
            this.buttonStar.TabIndex = 4;
            this.buttonStar.Text = "Star";
            this.buttonStar.UseVisualStyleBackColor = true;
            this.buttonStar.Click += new System.EventHandler(this.buttonStar_Click);
            // 
            // FormThurtleGraphics2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.buttonStar);
            this.Controls.Add(this.buttonHexagon);
            this.Controls.Add(this.buttonShowHideTurtle);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonDraw);
            this.Name = "FormThurtleGraphics2";
            this.Text = "Turtle Graphics- Example";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDraw;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonShowHideTurtle;
        private System.Windows.Forms.Button buttonHexagon;
        private System.Windows.Forms.Button buttonStar;
    }
}

