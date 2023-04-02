namespace proyecto_bases_datos
{
    partial class frmSeleccionCandidato
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
            this.tbnRecomendarCandidato = new System.Windows.Forms.Button();
            this.cbPuestos = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(285, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Brandon Gomez Carvajal";
            // 
            // tbnRecomendarCandidato
            // 
            this.tbnRecomendarCandidato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbnRecomendarCandidato.Location = new System.Drawing.Point(260, 295);
            this.tbnRecomendarCandidato.Name = "tbnRecomendarCandidato";
            this.tbnRecomendarCandidato.Size = new System.Drawing.Size(248, 44);
            this.tbnRecomendarCandidato.TabIndex = 1;
            this.tbnRecomendarCandidato.Text = "Ver mejor candidato";
            this.tbnRecomendarCandidato.UseVisualStyleBackColor = true;
            // 
            // cbPuestos
            // 
            this.cbPuestos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPuestos.FormattingEnabled = true;
            this.cbPuestos.Location = new System.Drawing.Point(246, 137);
            this.cbPuestos.Name = "cbPuestos";
            this.cbPuestos.Size = new System.Drawing.Size(230, 29);
            this.cbPuestos.TabIndex = 29;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(491, 137);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(107, 29);
            this.btnFiltrar.TabIndex = 28;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.Location = new System.Drawing.Point(162, 140);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(66, 21);
            this.lblPuesto.TabIndex = 27;
            this.lblPuesto.Text = "Puesto:";
            // 
            // frmSeleccionCandidato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 495);
            this.Controls.Add(this.cbPuestos);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.lblPuesto);
            this.Controls.Add(this.tbnRecomendarCandidato);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmSeleccionCandidato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSeleccionCandidato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tbnRecomendarCandidato;
        private System.Windows.Forms.ComboBox cbPuestos;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label lblPuesto;
    }
}