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
            this.tbnCandidatos = new System.Windows.Forms.Button();
            this.cbPuestos = new System.Windows.Forms.ComboBox();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRequisitos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdiomas = new System.Windows.Forms.TextBox();
            this.pbAtras = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAtras)).BeginInit();
            this.SuspendLayout();
            // 
            // tbnCandidatos
            // 
            this.tbnCandidatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbnCandidatos.Location = new System.Drawing.Point(271, 403);
            this.tbnCandidatos.Name = "tbnCandidatos";
            this.tbnCandidatos.Size = new System.Drawing.Size(248, 44);
            this.tbnCandidatos.TabIndex = 1;
            this.tbnCandidatos.Text = "Ver candidatos";
            this.tbnCandidatos.UseVisualStyleBackColor = true;
            this.tbnCandidatos.Click += new System.EventHandler(this.btnCandidatos_Click);
            // 
            // cbPuestos
            // 
            this.cbPuestos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPuestos.FormattingEnabled = true;
            this.cbPuestos.Location = new System.Drawing.Point(152, 61);
            this.cbPuestos.Name = "cbPuestos";
            this.cbPuestos.Size = new System.Drawing.Size(638, 29);
            this.cbPuestos.TabIndex = 29;
            this.cbPuestos.SelectedValueChanged += new System.EventHandler(this.cbPuestos_SelectedValueChanged);
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuesto.Location = new System.Drawing.Point(12, 67);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(140, 21);
            this.lblPuesto.TabIndex = 27;
            this.lblPuesto.Text = "Empresa/Puesto:";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(153, 120);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.ReadOnly = true;
            this.txtEmpresa.Size = new System.Drawing.Size(481, 27);
            this.txtEmpresa.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.TabIndex = 31;
            this.label1.Text = "Empresa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 33;
            this.label2.Text = "Puesto:";
            // 
            // txtPuesto
            // 
            this.txtPuesto.Location = new System.Drawing.Point(153, 169);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.ReadOnly = true;
            this.txtPuesto.Size = new System.Drawing.Size(481, 27);
            this.txtPuesto.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 21);
            this.label3.TabIndex = 35;
            this.label3.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(153, 214);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(481, 27);
            this.txtDescripcion.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 37;
            this.label4.Text = "Requisitos:";
            // 
            // txtRequisitos
            // 
            this.txtRequisitos.Location = new System.Drawing.Point(152, 251);
            this.txtRequisitos.Name = "txtRequisitos";
            this.txtRequisitos.ReadOnly = true;
            this.txtRequisitos.Size = new System.Drawing.Size(481, 27);
            this.txtRequisitos.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 21);
            this.label5.TabIndex = 39;
            this.label5.Text = "Idiomas:";
            // 
            // txtIdiomas
            // 
            this.txtIdiomas.Location = new System.Drawing.Point(153, 293);
            this.txtIdiomas.Name = "txtIdiomas";
            this.txtIdiomas.ReadOnly = true;
            this.txtIdiomas.Size = new System.Drawing.Size(481, 27);
            this.txtIdiomas.TabIndex = 38;
            // 
            // pbAtras
            // 
            this.pbAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAtras.Image = global::proyecto_bases_datos.Properties.Resources.flecha_izquierda;
            this.pbAtras.Location = new System.Drawing.Point(8, 6);
            this.pbAtras.Name = "pbAtras";
            this.pbAtras.Size = new System.Drawing.Size(53, 50);
            this.pbAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAtras.TabIndex = 40;
            this.pbAtras.TabStop = false;
            this.pbAtras.Click += new System.EventHandler(this.pbAtras_Click);
            // 
            // frmSeleccionCandidato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(803, 495);
            this.Controls.Add(this.pbAtras);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtIdiomas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRequisitos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPuesto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.cbPuestos);
            this.Controls.Add(this.lblPuesto);
            this.Controls.Add(this.tbnCandidatos);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmSeleccionCandidato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSeleccionCandidato";
            this.Load += new System.EventHandler(this.frmSeleccionCandidato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAtras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button tbnCandidatos;
        private System.Windows.Forms.ComboBox cbPuestos;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtEmpresa;
        public System.Windows.Forms.TextBox txtPuesto;
        public System.Windows.Forms.TextBox txtDescripcion;
        public System.Windows.Forms.TextBox txtRequisitos;
        public System.Windows.Forms.TextBox txtIdiomas;
        private System.Windows.Forms.PictureBox pbAtras;
    }
}