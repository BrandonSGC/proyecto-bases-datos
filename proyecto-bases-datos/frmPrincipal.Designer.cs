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
            this.lblMenuPrincipal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(234, 341);
            this.button5.Margin = new System.Windows.Forms.Padding(5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(244, 39);
            this.button5.TabIndex = 9;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(234, 292);
            this.button4.Margin = new System.Windows.Forms.Padding(5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(244, 39);
            this.button4.TabIndex = 8;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnMantenimientoVacantes
            // 
            this.btnMantenimientoVacantes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMantenimientoVacantes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantenimientoVacantes.Location = new System.Drawing.Point(234, 243);
            this.btnMantenimientoVacantes.Margin = new System.Windows.Forms.Padding(5);
            this.btnMantenimientoVacantes.Name = "btnMantenimientoVacantes";
            this.btnMantenimientoVacantes.Size = new System.Drawing.Size(244, 39);
            this.btnMantenimientoVacantes.TabIndex = 7;
            this.btnMantenimientoVacantes.Text = "Mantenimiento Vacantes";
            this.btnMantenimientoVacantes.UseVisualStyleBackColor = true;
            this.btnMantenimientoVacantes.Click += new System.EventHandler(this.btnNuevaVacante_Click);
            // 
            // btnMostrarCandidatos
            // 
            this.btnMostrarCandidatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarCandidatos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarCandidatos.Location = new System.Drawing.Point(234, 194);
            this.btnMostrarCandidatos.Margin = new System.Windows.Forms.Padding(5);
            this.btnMostrarCandidatos.Name = "btnMostrarCandidatos";
            this.btnMostrarCandidatos.Size = new System.Drawing.Size(244, 39);
            this.btnMostrarCandidatos.TabIndex = 6;
            this.btnMostrarCandidatos.Text = "Mostrar candidatos";
            this.btnMostrarCandidatos.UseVisualStyleBackColor = true;
            // 
            // btnIngresarCV
            // 
            this.btnIngresarCV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresarCV.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarCV.Location = new System.Drawing.Point(234, 145);
            this.btnIngresarCV.Margin = new System.Windows.Forms.Padding(5);
            this.btnIngresarCV.Name = "btnIngresarCV";
            this.btnIngresarCV.Size = new System.Drawing.Size(244, 39);
            this.btnIngresarCV.TabIndex = 5;
            this.btnIngresarCV.Text = "Ingresar CV";
            this.btnIngresarCV.UseVisualStyleBackColor = true;
            this.btnIngresarCV.Click += new System.EventHandler(this.btnIngresarCV_Click);
            // 
            // lblMenuPrincipal
            // 
            this.lblMenuPrincipal.AutoSize = true;
            this.lblMenuPrincipal.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenuPrincipal.Location = new System.Drawing.Point(272, 45);
            this.lblMenuPrincipal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMenuPrincipal.Name = "lblMenuPrincipal";
            this.lblMenuPrincipal.Size = new System.Drawing.Size(164, 25);
            this.lblMenuPrincipal.TabIndex = 10;
            this.lblMenuPrincipal.Text = "Menú Principal";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 499);
            this.Controls.Add(this.lblMenuPrincipal);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnMantenimientoVacantes);
            this.Controls.Add(this.btnMostrarCandidatos);
            this.Controls.Add(this.btnIngresarCV);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnMantenimientoVacantes;
        private System.Windows.Forms.Button btnMostrarCandidatos;
        private System.Windows.Forms.Button btnIngresarCV;
        private System.Windows.Forms.Label lblMenuPrincipal;
    }
}

