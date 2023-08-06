
namespace tp1_prog3
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEj1 = new System.Windows.Forms.Button();
            this.btnEj2 = new System.Windows.Forms.Button();
            this.btnEj3 = new System.Windows.Forms.Button();
            this.lblIntegrantes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEj1
            // 
            this.btnEj1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEj1.Location = new System.Drawing.Point(22, 65);
            this.btnEj1.Name = "btnEj1";
            this.btnEj1.Size = new System.Drawing.Size(120, 50);
            this.btnEj1.TabIndex = 0;
            this.btnEj1.Text = "EJERCICIO 1";
            this.btnEj1.UseVisualStyleBackColor = true;
            this.btnEj1.Click += new System.EventHandler(this.BtnEj1_Click);
            // 
            // btnEj2
            // 
            this.btnEj2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEj2.Location = new System.Drawing.Point(180, 65);
            this.btnEj2.Name = "btnEj2";
            this.btnEj2.Size = new System.Drawing.Size(120, 50);
            this.btnEj2.TabIndex = 0;
            this.btnEj2.Text = "EJERCICIO 2";
            this.btnEj2.UseVisualStyleBackColor = true;
            this.btnEj2.Click += new System.EventHandler(this.BtnEj2_Click);
            // 
            // btnEj3
            // 
            this.btnEj3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEj3.Location = new System.Drawing.Point(342, 65);
            this.btnEj3.Name = "btnEj3";
            this.btnEj3.Size = new System.Drawing.Size(120, 50);
            this.btnEj3.TabIndex = 0;
            this.btnEj3.Text = "EJERCICIO 3";
            this.btnEj3.UseVisualStyleBackColor = true;
            this.btnEj3.Click += new System.EventHandler(this.BtnEj3_Click);
            // 
            // lblIntegrantes
            // 
            this.lblIntegrantes.AutoSize = true;
            this.lblIntegrantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntegrantes.Location = new System.Drawing.Point(35, 140);
            this.lblIntegrantes.Name = "lblIntegrantes";
            this.lblIntegrantes.Size = new System.Drawing.Size(95, 20);
            this.lblIntegrantes.TabIndex = 1;
            this.lblIntegrantes.Text = "Integrantes:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 100);
            this.label1.TabIndex = 2;
            this.label1.Text = "Juan Ignacio Velesquen Saenz\r\nAlejo Daniel Pérez Herrero\r\nDavid Thomas Vydra\r\nJos" +
    "e Julian Coronel\r\nLoreanny Valentina Verenzuela García";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 321);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblIntegrantes);
            this.Controls.Add(this.btnEj3);
            this.Controls.Add(this.btnEj2);
            this.Controls.Add(this.btnEj1);
            this.Name = "FormPrincipal";
            this.Text = "Formulario principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEj1;
        private System.Windows.Forms.Button btnEj2;
        private System.Windows.Forms.Button btnEj3;
        private System.Windows.Forms.Label lblIntegrantes;
        private System.Windows.Forms.Label label1;
    }
}

