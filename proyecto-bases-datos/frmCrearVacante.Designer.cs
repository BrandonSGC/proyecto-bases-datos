namespace proyecto_bases_datos
{
    partial class frmCrearVacante
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
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarVacante = new System.Windows.Forms.Button();
            this.btnEliminarVacante = new System.Windows.Forms.Button();
            this.btnModificarVacante = new System.Windows.Forms.Button();
            this.btnCrearVacante = new System.Windows.Forms.Button();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtRequisitos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreEmpresa = new System.Windows.Forms.TextBox();
            this.lblNombreEmpresa = new System.Windows.Forms.Label();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPuesto
            // 
            this.txtPuesto.Location = new System.Drawing.Point(481, 46);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(167, 20);
            this.txtPuesto.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nombre del Puesto:";
            // 
            // btnBuscarVacante
            // 
            this.btnBuscarVacante.Location = new System.Drawing.Point(674, 28);
            this.btnBuscarVacante.Name = "btnBuscarVacante";
            this.btnBuscarVacante.Size = new System.Drawing.Size(125, 38);
            this.btnBuscarVacante.TabIndex = 22;
            this.btnBuscarVacante.Text = "Buscar";
            this.btnBuscarVacante.UseVisualStyleBackColor = true;
            this.btnBuscarVacante.Click += new System.EventHandler(this.btnBuscarVacante_Click);
            // 
            // btnEliminarVacante
            // 
            this.btnEliminarVacante.Location = new System.Drawing.Point(625, 556);
            this.btnEliminarVacante.Name = "btnEliminarVacante";
            this.btnEliminarVacante.Size = new System.Drawing.Size(125, 38);
            this.btnEliminarVacante.TabIndex = 35;
            this.btnEliminarVacante.Text = "Eliminar Vacante";
            this.btnEliminarVacante.UseVisualStyleBackColor = true;
            // 
            // btnModificarVacante
            // 
            this.btnModificarVacante.Location = new System.Drawing.Point(461, 556);
            this.btnModificarVacante.Name = "btnModificarVacante";
            this.btnModificarVacante.Size = new System.Drawing.Size(125, 38);
            this.btnModificarVacante.TabIndex = 34;
            this.btnModificarVacante.Text = "Modificar Vacante";
            this.btnModificarVacante.UseVisualStyleBackColor = true;
            // 
            // btnCrearVacante
            // 
            this.btnCrearVacante.Location = new System.Drawing.Point(306, 556);
            this.btnCrearVacante.Name = "btnCrearVacante";
            this.btnCrearVacante.Size = new System.Drawing.Size(125, 38);
            this.btnCrearVacante.TabIndex = 33;
            this.btnCrearVacante.Text = "Crear Vacante";
            this.btnCrearVacante.UseVisualStyleBackColor = true;
            this.btnCrearVacante.Click += new System.EventHandler(this.btnCrearVacante_Click_1);
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(481, 455);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(124, 20);
            this.txtSalario.TabIndex = 32;
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Location = new System.Drawing.Point(345, 462);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(42, 13);
            this.lblSalario.TabIndex = 31;
            this.lblSalario.Text = "Salario:";
            // 
            // txtRequisitos
            // 
            this.txtRequisitos.Location = new System.Drawing.Point(481, 302);
            this.txtRequisitos.Multiline = true;
            this.txtRequisitos.Name = "txtRequisitos";
            this.txtRequisitos.Size = new System.Drawing.Size(318, 110);
            this.txtRequisitos.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(345, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Requisitos:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(481, 158);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(318, 110);
            this.txtDescripcion.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(345, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Descripción:";
            // 
            // txtNombreEmpresa
            // 
            this.txtNombreEmpresa.Location = new System.Drawing.Point(481, 102);
            this.txtNombreEmpresa.Name = "txtNombreEmpresa";
            this.txtNombreEmpresa.Size = new System.Drawing.Size(318, 20);
            this.txtNombreEmpresa.TabIndex = 26;
            // 
            // lblNombreEmpresa
            // 
            this.lblNombreEmpresa.AutoSize = true;
            this.lblNombreEmpresa.Location = new System.Drawing.Point(345, 109);
            this.lblNombreEmpresa.Name = "lblNombreEmpresa";
            this.lblNombreEmpresa.Size = new System.Drawing.Size(116, 13);
            this.lblNombreEmpresa.TabIndex = 25;
            this.lblNombreEmpresa.Text = "Nombre de la empresa:";
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Location = new System.Drawing.Point(773, 556);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(125, 38);
            this.btnLimpiarCampos.TabIndex = 36;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // frmCrearVacante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 675);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnEliminarVacante);
            this.Controls.Add(this.btnModificarVacante);
            this.Controls.Add(this.btnCrearVacante);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.txtRequisitos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreEmpresa);
            this.Controls.Add(this.lblNombreEmpresa);
            this.Controls.Add(this.btnBuscarVacante);
            this.Controls.Add(this.txtPuesto);
            this.Controls.Add(this.label3);
            this.Name = "frmCrearVacante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNuevaVacante";
            this.Load += new System.EventHandler(this.frmNuevaVacante_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPuesto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscarVacante;
        private System.Windows.Forms.Button btnEliminarVacante;
        private System.Windows.Forms.Button btnModificarVacante;
        private System.Windows.Forms.Button btnCrearVacante;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtRequisitos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreEmpresa;
        private System.Windows.Forms.Label lblNombreEmpresa;
        private System.Windows.Forms.Button btnLimpiarCampos;
    }
}