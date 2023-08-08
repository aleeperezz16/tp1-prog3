
namespace tp1_prog3
{
    partial class FormEj2
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
            this.gbIngresoDatos = new System.Windows.Forms.GroupBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.TbApellido = new System.Windows.Forms.TextBox();
            this.TbNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gbElementos = new System.Windows.Forms.GroupBox();
            this.LbNombreApellido = new System.Windows.Forms.ListBox();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.gbIngresoDatos.SuspendLayout();
            this.gbElementos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbIngresoDatos
            // 
            this.gbIngresoDatos.Controls.Add(this.BtnAgregar);
            this.gbIngresoDatos.Controls.Add(this.TbApellido);
            this.gbIngresoDatos.Controls.Add(this.TbNombre);
            this.gbIngresoDatos.Controls.Add(this.lblApellido);
            this.gbIngresoDatos.Controls.Add(this.lblNombre);
            this.gbIngresoDatos.Location = new System.Drawing.Point(12, 28);
            this.gbIngresoDatos.Name = "gbIngresoDatos";
            this.gbIngresoDatos.Size = new System.Drawing.Size(269, 402);
            this.gbIngresoDatos.TabIndex = 0;
            this.gbIngresoDatos.TabStop = false;
            this.gbIngresoDatos.Text = "Ingreso de Datos";
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.BackColor = System.Drawing.Color.White;
            this.BtnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnAgregar.Location = new System.Drawing.Point(66, 235);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(110, 37);
            this.BtnAgregar.TabIndex = 4;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = false;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // TbApellido
            // 
            this.TbApellido.Location = new System.Drawing.Point(107, 182);
            this.TbApellido.MaxLength = 50;
            this.TbApellido.Name = "TbApellido";
            this.TbApellido.Size = new System.Drawing.Size(123, 20);
            this.TbApellido.TabIndex = 3;
            // 
            // TbNombre
            // 
            this.TbNombre.Location = new System.Drawing.Point(107, 152);
            this.TbNombre.MaxLength = 50;
            this.TbNombre.Name = "TbNombre";
            this.TbNombre.Size = new System.Drawing.Size(123, 20);
            this.TbNombre.TabIndex = 2;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(10, 183);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(78, 20);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(12, 153);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(76, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // gbElementos
            // 
            this.gbElementos.Controls.Add(this.LbNombreApellido);
            this.gbElementos.Controls.Add(this.BtnBorrar);
            this.gbElementos.Location = new System.Drawing.Point(304, 28);
            this.gbElementos.Name = "gbElementos";
            this.gbElementos.Size = new System.Drawing.Size(268, 402);
            this.gbElementos.TabIndex = 1;
            this.gbElementos.TabStop = false;
            this.gbElementos.Text = "Elementos";
            // 
            // LbNombreApellido
            // 
            this.LbNombreApellido.FormattingEnabled = true;
            this.LbNombreApellido.Location = new System.Drawing.Point(27, 28);
            this.LbNombreApellido.Name = "LbNombreApellido";
            this.LbNombreApellido.Size = new System.Drawing.Size(224, 316);
            this.LbNombreApellido.Sorted = true;
            this.LbNombreApellido.TabIndex = 1;
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.BackColor = System.Drawing.Color.White;
            this.BtnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBorrar.Location = new System.Drawing.Point(84, 356);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(109, 40);
            this.BtnBorrar.TabIndex = 0;
            this.BtnBorrar.Text = "Borrar";
            this.BtnBorrar.UseVisualStyleBackColor = false;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // FormEj2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 450);
            this.Controls.Add(this.gbElementos);
            this.Controls.Add(this.gbIngresoDatos);
            this.Name = "FormEj2";
            this.Text = "Nombre y apellido";
            this.gbIngresoDatos.ResumeLayout(false);
            this.gbIngresoDatos.PerformLayout();
            this.gbElementos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbIngresoDatos;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.TextBox TbApellido;
        private System.Windows.Forms.TextBox TbNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox gbElementos;
        private System.Windows.Forms.ListBox LbNombreApellido;
        private System.Windows.Forms.Button BtnBorrar;
    }
}