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
    public partial class FormEj2 : Form
    {
        public FormEj2()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = TbNombre.Text.Trim();
            string apellido = TbApellido.Text.Trim();

            TbApellido.Text = "";
            TbNombre.Text = "";

            TbNombre.Focus();

            //Validacion del nombre para que no tenga numeros
            foreach(char c in nombre)
            {
                for(int i = 0; i < 10; i++)
                {
                    char c1 = (char) (48+i);
                    if (c.Equals(c1)){
                        MessageBox.Show("No ingrese numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            //Validacion del Apellido para que no tenga numeros
            foreach (char c in apellido)
            {
                for (int i = 0; i < 10; i++)
                {
                    char c1 = (char)(48 + i);
                    if (c.Equals(c1))
                    {
                        MessageBox.Show("No ingrese numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            if (nombre.Length > 0 && apellido.Length > 0)
            {
                string nombreCompleto = nombre + ' ' + apellido;
                
                foreach (string elem in LbNombreApellido.Items)
                {
                    if (elem.ToLower().Equals(nombreCompleto.ToLower()))
                    {
                        MessageBox.Show("El nombre ingresado ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                LbNombreApellido.Items.Add(nombreCompleto);
            }
            else
            {
                MessageBox.Show("Debe incluirse tanto nombre como apellido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            object nombreape = LbNombreApellido.SelectedItem;
            
            if (nombreape != null)
            {
                int indice = LbNombreApellido.SelectedIndex;
                string s = LbNombreApellido.Items[indice].ToString();
                LbNombreApellido.Items.RemoveAt(indice);
                MessageBox.Show("Se ha eliminado a " + s + " correctamente", "Mensaje");
            }
            else
            {
                MessageBox.Show("Debe seleccionar un elemento para borrarlo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            TbNombre.Focus();
        }
    }
}
