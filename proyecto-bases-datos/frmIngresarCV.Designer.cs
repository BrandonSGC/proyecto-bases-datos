namespace proyecto_bases_datos
{
    partial class frmIngresarCV
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnLeerArchivo = new System.Windows.Forms.Button();
            this.pbAtras = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAtras)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(16, 68);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(913, 458);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // btnLeerArchivo
            // 
            this.btnLeerArchivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeerArchivo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeerArchivo.Location = new System.Drawing.Point(379, 550);
            this.btnLeerArchivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLeerArchivo.Name = "btnLeerArchivo";
            this.btnLeerArchivo.Size = new System.Drawing.Size(180, 49);
            this.btnLeerArchivo.TabIndex = 3;
            this.btnLeerArchivo.Text = "Leer Archivo";
            this.btnLeerArchivo.UseVisualStyleBackColor = true;
            this.btnLeerArchivo.Click += new System.EventHandler(this.btnLeerArchivo_Click);
            // 
            // pbAtras
            // 
            this.pbAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbAtras.Image = global::proyecto_bases_datos.Properties.Resources.flecha_izquierda;
            this.pbAtras.Location = new System.Drawing.Point(0, -1);
            this.pbAtras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbAtras.Name = "pbAtras";
            this.pbAtras.Size = new System.Drawing.Size(71, 62);
            this.pbAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAtras.TabIndex = 5;
            this.pbAtras.TabStop = false;
            this.pbAtras.Click += new System.EventHandler(this.pbAtras_Click);
            // 
            // frmIngresarCV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 614);
            this.Controls.Add(this.pbAtras);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnLeerArchivo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmIngresarCV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresar CV";
            this.Load += new System.EventHandler(this.frmIngresarCV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAtras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnLeerArchivo;
        private System.Windows.Forms.PictureBox pbAtras;
    }
}