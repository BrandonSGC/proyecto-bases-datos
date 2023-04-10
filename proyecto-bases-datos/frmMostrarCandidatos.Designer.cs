namespace proyecto_bases_datos
{
    partial class frmMostrarCandidatos
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
            this.pbAtras = new System.Windows.Forms.PictureBox();
            this.dgvCandidatos = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdiomas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRequisitos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidatos)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAtras
            // 
            this.pbAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAtras.Image = global::proyecto_bases_datos.Properties.Resources.flecha_izquierda;
            this.pbAtras.Location = new System.Drawing.Point(-8, 0);
            this.pbAtras.Name = "pbAtras";
            this.pbAtras.Size = new System.Drawing.Size(53, 50);
            this.pbAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAtras.TabIndex = 6;
            this.pbAtras.TabStop = false;
            this.pbAtras.Click += new System.EventHandler(this.pbAtras_Click);
            // 
            // dgvCandidatos
            // 
            this.dgvCandidatos.AllowUserToAddRows = false;
            this.dgvCandidatos.AllowUserToDeleteRows = false;
            this.dgvCandidatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCandidatos.Location = new System.Drawing.Point(12, 177);
            this.dgvCandidatos.Name = "dgvCandidatos";
            this.dgvCandidatos.ReadOnly = true;
            this.dgvCandidatos.Size = new System.Drawing.Size(880, 369);
            this.dgvCandidatos.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(133, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 21);
            this.label5.TabIndex = 49;
            this.label5.Text = "Idiomas:";
            // 
            // txtIdiomas
            // 
            this.txtIdiomas.Location = new System.Drawing.Point(243, 139);
            this.txtIdiomas.Name = "txtIdiomas";
            this.txtIdiomas.ReadOnly = true;
            this.txtIdiomas.Size = new System.Drawing.Size(481, 27);
            this.txtIdiomas.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(132, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 47;
            this.label4.Text = "Requisitos:";
            // 
            // txtRequisitos
            // 
            this.txtRequisitos.Location = new System.Drawing.Point(242, 109);
            this.txtRequisitos.Name = "txtRequisitos";
            this.txtRequisitos.ReadOnly = true;
            this.txtRequisitos.Size = new System.Drawing.Size(481, 27);
            this.txtRequisitos.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(133, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 21);
            this.label3.TabIndex = 45;
            this.label3.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(243, 76);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(481, 27);
            this.txtDescripcion.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 43;
            this.label2.Text = "Puesto:";
            // 
            // txtPuesto
            // 
            this.txtPuesto.Location = new System.Drawing.Point(243, 44);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.ReadOnly = true;
            this.txtPuesto.Size = new System.Drawing.Size(481, 27);
            this.txtPuesto.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 21);
            this.label1.TabIndex = 41;
            this.label1.Text = "Empresa:";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(243, 12);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.ReadOnly = true;
            this.txtEmpresa.Size = new System.Drawing.Size(481, 27);
            this.txtEmpresa.TabIndex = 40;
            // 
            // frmMostrarCandidatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 597);
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
            this.Controls.Add(this.dgvCandidatos);
            this.Controls.Add(this.pbAtras);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmMostrarCandidatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMostrarCandidatos";
            this.Load += new System.EventHandler(this.frmMostrarCandidatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCandidatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAtras;
        private System.Windows.Forms.DataGridView dgvCandidatos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdiomas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRequisitos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPuesto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmpresa;
    }
}