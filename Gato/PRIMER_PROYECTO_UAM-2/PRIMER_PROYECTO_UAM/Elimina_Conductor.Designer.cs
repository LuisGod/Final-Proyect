﻿namespace PRIMER_PROYECTO_UAM
{
    partial class Elimina_Conductor
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxelim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttondesactiva = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese La Cedula Del Cliente a Eliminar";
            // 
            // textBoxelim
            // 
            this.textBoxelim.BackColor = System.Drawing.Color.OrangeRed;
            this.textBoxelim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxelim.Location = new System.Drawing.Point(228, 108);
            this.textBoxelim.Name = "textBoxelim";
            this.textBoxelim.Size = new System.Drawing.Size(189, 20);
            this.textBoxelim.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-2, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(500, 57);
            this.label2.TabIndex = 2;
            this.label2.Text = "Elimina Conductor";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttondesactiva
            // 
            this.buttondesactiva.BackColor = System.Drawing.Color.LightSalmon;
            this.buttondesactiva.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttondesactiva.Location = new System.Drawing.Point(338, 198);
            this.buttondesactiva.Name = "buttondesactiva";
            this.buttondesactiva.Size = new System.Drawing.Size(133, 33);
            this.buttondesactiva.TabIndex = 3;
            this.buttondesactiva.Text = "Desactivar";
            this.buttondesactiva.UseVisualStyleBackColor = false;
            this.buttondesactiva.Click += new System.EventHandler(this.button1_Click);
            // 
            // Elimina_Conductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(493, 252);
            this.Controls.Add(this.buttondesactiva);
            this.Controls.Add(this.textBoxelim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Elimina_Conductor";
            this.Text = "Elimina_Conductor";
            this.Load += new System.EventHandler(this.Elimina_Conductor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxelim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttondesactiva;
    }
}