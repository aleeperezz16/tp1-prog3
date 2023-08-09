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
    public partial class FormEj3 : Form
    {
        public FormEj3()
        {
            InitializeComponent();
            rdBtnFemenino.Checked = true;
            rdBtnCasado.Checked = true;
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
           
            string salida;
            salida="Usted seleccionó los siguientes elementos: "+"\r\n"; 
            salida += "Sexo: " + (string)(rdBtnFemenino.Checked ? "Femenino" : "Masculino") + "\r\n";
            salida += "Estado Civil: " + (string)(rdBtnCasado.Checked ? "Casado" : "Soltero") + "\r\n";

            LblMostrar.Text = salida;
        }
    }
}
