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
                        TbNombre.BackColor = Color.Red;
                        return;
                    }
                }
                foreach (string nombreguardado in LbNombres1.Items)
                {
                    if (nombre.ToUpper().Equals(nombreguardado.ToUpper()))
                    {
                        MessageBox.Show("Se ha ingresado un nombre repetido, por favor ingrese un nombre diferente", "Advertencia");
                        TbNombre.BackColor = Color.Red;
                        return;
                    }

                }
                LbNombres1.Items.Add(nombre);
                TbNombre.BackColor = System.Drawing.SystemColors.Window;
            }
            else
            {
                MessageBox.Show("Se necesita ingresar un nombre válido", "Advertencia");
                TbNombre.BackColor = Color.Red;
            }

        }

        private void btnPasarItem_Click(object sender, EventArgs e)
        {
            if (LbNombres1.SelectedIndex >= 0)
            {
                string nombre = LbNombres1.SelectedItem.ToString();
                foreach (object aux in LbNombres2.Items)
                {
                    string nombres = aux.ToString().Trim().ToUpper();
                    if (nombre.Trim().ToUpper().Equals(nombres))
                    {
                        MessageBox.Show("No se pueden repetir los nombres", "Advertencia");
                        LbNombres1.SelectedIndex = -1;
                        LblIngreseNombre.Focus();
                        return;
                    }
                }
                LbNombres2.Items.Add(nombre);
                LbNombres1.SelectedIndex = -1;
                LblIngreseNombre.Focus();
            }
            else
            {
                MessageBox.Show("Seleccione un elemento a pasar", "Advertencia");
            }
        }


        /* private void btnPasarItem_Click(object sender, EventArgs e)
{
    if (LbNombres1.SelectedIndex >= 0)
    {
        string nombre = LbNombres1.SelectedItem.ToString();
        foreach (object aux in LbNombres2.Items)
        {
            string nombres = aux.ToString().Trim().ToUpper();
            if (nombre.Trim().ToUpper().Equals(nombres))
            {
                MessageBox.Show("No se pueden repetir los nombres", "Advertencia");
                LbNombres1.SelectedIndex = -1;
                LblIngreseNombre.Focus();
                return;
            }
        }
        LbNombres2.Items.Add(nombre);
        LbNombres1.SelectedIndex = -1;
        LblIngreseNombre.Focus();
    }
    else
    {
        MessageBox.Show("Seleccione un elemento a pasar","Advertencia");
    }
}*/
    }
}
