
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
            this.btnPasarItem = new System.Windows.Forms.Button();
            this.LbNombres2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LblIngreseNombre
            // 
            this.LblIngreseNombre.AutoSize = true;
            this.LblIngreseNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIngreseNombre.Location = new System.Drawing.Point(49, 57);
            this.LblIngreseNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblIngreseNombre.Name = "LblIngreseNombre";
            this.LblIngreseNombre.Size = new System.Drawing.Size(194, 24);
            this.LblIngreseNombre.TabIndex = 0;
            this.LblIngreseNombre.Text = "Ingrese un nombre:";
            // 
            // TbNombre
            // 
            this.TbNombre.Location = new System.Drawing.Point(261, 58);
            this.TbNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TbNombre.Name = "TbNombre";
            this.TbNombre.Size = new System.Drawing.Size(284, 22);
            this.TbNombre.TabIndex = 1;
            // 
            // BtnAgregarNombre
            // 
            this.BtnAgregarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarNombre.Location = new System.Drawing.Point(596, 47);
            this.BtnAgregarNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnAgregarNombre.Name = "BtnAgregarNombre";
            this.BtnAgregarNombre.Size = new System.Drawing.Size(128, 46);
            this.BtnAgregarNombre.TabIndex = 2;
            this.BtnAgregarNombre.Text = "Agregar";
            this.BtnAgregarNombre.UseVisualStyleBackColor = true;
            this.BtnAgregarNombre.Click += new System.EventHandler(this.BtnAgregarNombre_Click);
            // 
            // LbNombres1
            // 
            this.LbNombres1.FormattingEnabled = true;
            this.LbNombres1.ItemHeight = 16;
            this.LbNombres1.Location = new System.Drawing.Point(53, 151);
            this.LbNombres1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LbNombres1.Name = "LbNombres1";
            this.LbNombres1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LbNombres1.Size = new System.Drawing.Size(232, 340);
            this.LbNombres1.TabIndex = 3;
            // 
            // btnPasarItem
            // 
            this.btnPasarItem.Location = new System.Drawing.Point(355, 223);
            this.btnPasarItem.Name = "btnPasarItem";
            this.btnPasarItem.Size = new System.Drawing.Size(75, 23);
            this.btnPasarItem.TabIndex = 4;
            this.btnPasarItem.Text = ">";
            this.btnPasarItem.UseVisualStyleBackColor = true;
            this.btnPasarItem.Click += new System.EventHandler(this.btnPasarItem_Click);
            // 
            // LbNombres2
            // 
            this.LbNombres2.FormattingEnabled = true;
            this.LbNombres2.ItemHeight = 16;
            this.LbNombres2.Location = new System.Drawing.Point(507, 151);
            this.LbNombres2.Name = "LbNombres2";
            this.LbNombres2.Size = new System.Drawing.Size(232, 340);
            this.LbNombres2.TabIndex = 5;
            // 
            // FormEj1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 554);
            this.Controls.Add(this.LbNombres2);
            this.Controls.Add(this.btnPasarItem);
            this.Controls.Add(this.LbNombres1);
            this.Controls.Add(this.BtnAgregarNombre);
            this.Controls.Add(this.TbNombre);
            this.Controls.Add(this.LblIngreseNombre);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button btnPasarItem;
        private System.Windows.Forms.ListBox LbNombres2;
        /* private System.Windows.Forms.Button btnPasarItem;
private System.Windows.Forms.ListBox LbNombres2;*/
    }
}
