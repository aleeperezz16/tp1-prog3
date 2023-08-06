
namespace tp1_prog3
{
    partial class FormEj1
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
            this.LblIngreseNombre = new System.Windows.Forms.Label();
            this.TbNombre = new System.Windows.Forms.TextBox();
            this.BtnAgregarNombre = new System.Windows.Forms.Button();
            this.LbNombres1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LblIngreseNombre
            // 
            this.LblIngreseNombre.AutoSize = true;
            this.LblIngreseNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIngreseNombre.Location = new System.Drawing.Point(37, 46);
            this.LblIngreseNombre.Name = "LblIngreseNombre";
            this.LblIngreseNombre.Size = new System.Drawing.Size(153, 18);
            this.LblIngreseNombre.TabIndex = 0;
            this.LblIngreseNombre.Text = "Ingrese un nombre:";
            // 
            // TbNombre
            // 
            this.TbNombre.Location = new System.Drawing.Point(196, 47);
            this.TbNombre.Name = "TbNombre";
            this.TbNombre.Size = new System.Drawing.Size(214, 20);
            this.TbNombre.TabIndex = 1;
            // 
            // BtnAgregarNombre
            // 
            this.BtnAgregarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarNombre.Location = new System.Drawing.Point(447, 38);
            this.BtnAgregarNombre.Name = "BtnAgregarNombre";
            this.BtnAgregarNombre.Size = new System.Drawing.Size(96, 37);
            this.BtnAgregarNombre.TabIndex = 2;
            this.BtnAgregarNombre.Text = "Agregar";
            this.BtnAgregarNombre.UseVisualStyleBackColor = true;
            this.BtnAgregarNombre.Click += new System.EventHandler(this.BtnAgregarNombre_Click);
            // 
            // LbNombres1
            // 
            this.LbNombres1.FormattingEnabled = true;
            this.LbNombres1.Location = new System.Drawing.Point(41, 94);
            this.LbNombres1.Name = "LbNombres1";
            this.LbNombres1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LbNombres1.Size = new System.Drawing.Size(175, 277);
            this.LbNombres1.TabIndex = 3;
            // 
            // FormEj1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 450);
            this.Controls.Add(this.LbNombres1);
            this.Controls.Add(this.BtnAgregarNombre);
            this.Controls.Add(this.TbNombre);
            this.Controls.Add(this.LblIngreseNombre);
            this.Name = "FormEj1";
            this.Text = "Nombres";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblIngreseNombre;
        private System.Windows.Forms.TextBox TbNombre;
        private System.Windows.Forms.Button BtnAgregarNombre;
        private System.Windows.Forms.ListBox LbNombres1;
    }
}