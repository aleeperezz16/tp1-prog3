﻿using System;
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

        private void button1_Click(object sender, EventArgs e)
        {

            if ((txtApellido.Text.Trim().Length > 0) && (txtNombre.Text.Trim().Length > 0)) {
                lbNombreApellido.Items.Add(txtNombre.Text + " " + txtApellido.Text);
                txtApellido.Text = "";
                txtNombre.Text = "";
             }
            else
            {
                MessageBox.Show("Debe incluirse tanto nombre como apellido", "ATENCION");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            object nombreape = lbNombreApellido.SelectedItem;
            
            if(nombreape != null)
            {
                int indice = lbNombreApellido.SelectedIndex;
                MessageBox.Show("Se ha eliminado a "+ lbNombreApellido.SelectedItem.ToString() + " correctamente", "Mensaje");
                lbNombreApellido.Items.RemoveAt(indice);
                txtNombre.Focus();
            }
            else
            {
                MessageBox.Show("Debe Seleccionar un elemento para borrarlo.", "ATENCION");
                txtNombre.Focus();
            }
        }


    }
}
