using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp1_prog3
{
    public partial class FormEj1 : Form
    {
        public FormEj1()
        {
            InitializeComponent();
        }

        private void BtnAgregarNombre_Click(object sender, EventArgs e)
        {
            string nombre = TbNombre.Text.Trim();
            TbNombre.Text = "";

            if (nombre.Length != 0)
            {
                foreach (char c in nombre)
                {
                    if (c != ' ' && !Char.IsLetter(c))
                    {
                        MessageBox.Show("Se necesita ingresar un nombre válido", "Advertencia");
                        return;
                    }
                }

                LbNombres1.Items.Add(nombre);
            }
            else
            {
                MessageBox.Show("Se necesita ingresar un nombre válido", "Advertencia");
            }
        }
    }
}
