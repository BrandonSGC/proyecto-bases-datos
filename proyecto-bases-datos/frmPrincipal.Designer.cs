namespace proyecto_bases_datos
{
    partial class frmPrincipal
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
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnMantenimientoVacantes = new System.Windows.Forms.Button();
            this.btnMostrarCandidatos = new System.Windows.Forms.Button();
            this.btnIngresarCV = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(507, 383);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(176, 44);
            this.button5.TabIndex = 9;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(507, 333);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(176, 44);
            this.button4.TabIndex = 8;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnMantenimientoVacantes
            // 
            this.btnMantenimientoVacantes.Location = new System.Drawing.Point(507, 283);
            this.btnMantenimientoVacantes.Name = "btnMantenimientoVacantes";
            this.btnMantenimientoVacantes.Size = new System.Drawing.Size(176, 44);
            this.btnMantenimientoVacantes.TabIndex = 7;
            this.btnMantenimientoVacantes.Text = "Mantenimiento Vacantes";
            this.btnMantenimientoVacantes.UseVisualStyleBackColor = true;
            this.btnMantenimientoVacantes.Click += new System.EventHandler(this.btnNuevaVacante_Click);
            // 
            // btnMostrarCandidatos
            // 
            this.btnMostrarCandidatos.Location = new System.Drawing.Point(507, 233);
            this.btnMostrarCandidatos.Name = "btnMostrarCandidatos";
            this.btnMostrarCandidatos.Size = new System.Drawing.Size(176, 44);
            this.btnMostrarCandidatos.TabIndex = 6;
            this.btnMostrarCandidatos.Text = "Mostrar candidatos";
            this.btnMostrarCandidatos.UseVisualStyleBackColor = true;
            // 
            // btnIngresarCV
            // 
            this.btnIngresarCV.Location = new System.Drawing.Point(507, 183);
            this.btnIngresarCV.Name = "btnIngresarCV";
            this.btnIngresarCV.Size = new System.Drawing.Size(176, 44);
            this.btnIngresarCV.TabIndex = 5;
            this.btnIngresarCV.Text = "Ingresar CV";
            this.btnIngresarCV.UseVisualStyleBackColor = true;
            this.btnIngresarCV.Click += new System.EventHandler(this.btnIngresarCV_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 675);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnMantenimientoVacantes);
            this.Controls.Add(this.btnMostrarCandidatos);
            this.Controls.Add(this.btnIngresarCV);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnMantenimientoVacantes;
        private System.Windows.Forms.Button btnMostrarCandidatos;
        private System.Windows.Forms.Button btnIngresarCV;
    }
}

