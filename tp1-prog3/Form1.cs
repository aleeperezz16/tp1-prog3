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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void BtnEj1_Click(object sender, EventArgs e)
        {
            Hide();
            new FormEj1().ShowDialog();
            Show();
        }

        private void BtnEj2_Click(object sender, EventArgs e)
        {
            Hide();
            new FormEj2().ShowDialog();
            Show();
        }

        private void BtnEj3_Click(object sender, EventArgs e)
        {
            Hide();
            new FormEj3().ShowDialog();
            Show();
        }
    }
}
