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

            TbNombre.Focus();

            if (nombre.Length > 0)
            {
                foreach (char c in nombre)
                {
                    if (c != ' ' && !Char.IsLetter(c))
                    {
                        MessageBox.Show("Se necesita ingresar un nombre válido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                foreach (string nombreGuardado in LbNombres1.Items)
                {
                    if (nombre.ToUpper().Equals(nombreGuardado.ToUpper()))
                    {
                        MessageBox.Show("El nombre ingresado ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                }

                foreach (string nombreGuardado in LbNombres2.Items)
                {
                    if (nombre.ToUpper().Equals(nombreGuardado.ToUpper()))
                    {
                        MessageBox.Show("El nombre ingresado ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                }

                LbNombres1.Items.Add(nombre);
            }
            else
            {
                MessageBox.Show("Se necesita ingresar un nombre válido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void BtnPasarItem_Click(object sender, EventArgs e)
        {
            if (LbNombres1.SelectedIndex >= 0)
            {
                string nombre = LbNombres1.SelectedItem.ToString();

                LbNombres2.Items.Add(nombre);
                LbNombres1.Items.Remove(nombre);

                LbNombres1.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Seleccione un elemento a pasar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            TbNombre.Focus();
        }

        private void BtnPasarTodo_Click(object sender, EventArgs e)
        {
            if (LbNombres1.Items.Count > 0)
            {
                LbNombres2.Items.AddRange(LbNombres1.Items);
                LbNombres1.Items.Clear();
            }
            else
            {
                MessageBox.Show("No hay ningun elemento a pasar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            TbNombre.Focus();
        }
    }
}
