namespace PRIMER_PROYECTO_UAM
{
    partial class Solicitud_servicio
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
            this.cmbconductor = new System.Windows.Forms.ComboBox();
            this.btnservicio = new System.Windows.Forms.Button();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.cmbapellido = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Conductor";
            // 
            // cmbconductor
            // 
            this.cmbconductor.FormattingEnabled = true;
            this.cmbconductor.Location = new System.Drawing.Point(105, 45);
            this.cmbconductor.Name = "cmbconductor";
            this.cmbconductor.Size = new System.Drawing.Size(121, 21);
            this.cmbconductor.TabIndex = 1;
            // 
            // btnservicio
            // 
            this.btnservicio.Location = new System.Drawing.Point(212, 261);
            this.btnservicio.Name = "btnservicio";
            this.btnservicio.Size = new System.Drawing.Size(143, 36);
            this.btnservicio.TabIndex = 2;
            this.btnservicio.Text = "Solicitud Servicio";
            this.btnservicio.UseVisualStyleBackColor = true;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(255, 50);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 3;
            // 
            // cmbapellido
            // 
            this.cmbapellido.FormattingEnabled = true;
            this.cmbapellido.Location = new System.Drawing.Point(105, 88);
            this.cmbapellido.Name = "cmbapellido";
            this.cmbapellido.Size = new System.Drawing.Size(121, 21);
            this.cmbapellido.TabIndex = 4;
            // 
            // Solicitud_servicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 365);
            this.Controls.Add(this.cmbapellido);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.btnservicio);
            this.Controls.Add(this.cmbconductor);
            this.Controls.Add(this.label1);
            this.Name = "Solicitud_servicio";
            this.Text = "Solicitud_servicio";
            this.Load += new System.EventHandler(this.Solicitud_servicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbconductor;
        private System.Windows.Forms.Button btnservicio;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.ComboBox cmbapellido;
    }
}