
namespace tp1_prog3
{
    partial class FormEj3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdBtnFemenino = new System.Windows.Forms.RadioButton();
            this.rdBtnMasculino = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdBtnCasado = new System.Windows.Forms.RadioButton();
            this.rdBtnSoltero = new System.Windows.Forms.RadioButton();
            this.LblMostrar = new System.Windows.Forms.Label();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdBtnFemenino);
            this.groupBox1.Controls.Add(this.rdBtnMasculino);
            this.groupBox1.Location = new System.Drawing.Point(83, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // rdBtnFemenino
            // 
            this.rdBtnFemenino.AutoSize = true;
            this.rdBtnFemenino.Location = new System.Drawing.Point(26, 35);
            this.rdBtnFemenino.Name = "rdBtnFemenino";
            this.rdBtnFemenino.Size = new System.Drawing.Size(91, 21);
            this.rdBtnFemenino.TabIndex = 0;
            this.rdBtnFemenino.TabStop = true;
            this.rdBtnFemenino.Text = "Femenino";
            this.rdBtnFemenino.UseVisualStyleBackColor = true;
            // 
            // rdBtnMasculino
            // 
            this.rdBtnMasculino.AutoSize = true;
            this.rdBtnMasculino.Location = new System.Drawing.Point(26, 62);
            this.rdBtnMasculino.Name = "rdBtnMasculino";
            this.rdBtnMasculino.Size = new System.Drawing.Size(92, 21);
            this.rdBtnMasculino.TabIndex = 1;
            this.rdBtnMasculino.TabStop = true;
            this.rdBtnMasculino.Text = "Masculino";
            this.rdBtnMasculino.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdBtnCasado);
            this.groupBox2.Controls.Add(this.rdBtnSoltero);
            this.groupBox2.Location = new System.Drawing.Point(774, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estado Civil";
            // 
            // rdBtnCasado
            // 
            this.rdBtnCasado.AutoSize = true;
            this.rdBtnCasado.Location = new System.Drawing.Point(25, 35);
            this.rdBtnCasado.Name = "rdBtnCasado";
            this.rdBtnCasado.Size = new System.Drawing.Size(77, 21);
            this.rdBtnCasado.TabIndex = 2;
            this.rdBtnCasado.TabStop = true;
            this.rdBtnCasado.Text = "Casado";
            this.rdBtnCasado.UseVisualStyleBackColor = true;
            // 
            // rdBtnSoltero
            // 
            this.rdBtnSoltero.AutoSize = true;
            this.rdBtnSoltero.Location = new System.Drawing.Point(25, 73);
            this.rdBtnSoltero.Name = "rdBtnSoltero";
            this.rdBtnSoltero.Size = new System.Drawing.Size(74, 21);
            this.rdBtnSoltero.TabIndex = 3;
            this.rdBtnSoltero.TabStop = true;
            this.rdBtnSoltero.Text = "Soltero";
            this.rdBtnSoltero.UseVisualStyleBackColor = true;
            // 
            // LblMostrar
            // 
            this.LblMostrar.AutoSize = true;
            this.LblMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMostrar.Location = new System.Drawing.Point(312, 353);
            this.LblMostrar.Name = "LblMostrar";
            this.LblMostrar.Size = new System.Drawing.Size(0, 25);
            this.LblMostrar.TabIndex = 4;
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Location = new System.Drawing.Point(408, 295);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(239, 32);
            this.BtnMostrar.TabIndex = 5;
            this.BtnMostrar.Text = "Mostrar lo que se seleccionó";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // FormEj3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.LblMostrar);
            this.Controls.Add(this.BtnMostrar);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormEj3";
            this.Text = "Ejercicio 3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdBtnFemenino;
        private System.Windows.Forms.RadioButton rdBtnMasculino;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdBtnCasado;
        private System.Windows.Forms.RadioButton rdBtnSoltero;
        private System.Windows.Forms.Label LblMostrar;
        private System.Windows.Forms.Button BtnMostrar;
    }
}