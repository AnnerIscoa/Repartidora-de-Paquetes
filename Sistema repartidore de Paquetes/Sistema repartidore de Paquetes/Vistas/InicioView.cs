using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sistema_repartidore_de_Paquetes.Vistas
{
    public partial class InicioView : Syncfusion.Windows.Forms.Tools.RibbonForm
    {
        public InicioView()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void mostrarcontraseña()
        {
            if (CheckBox1.Checked == false)
            {
                ContraseñatextBox.PasswordChar = '*';
            }
            else
               if (ContraseñatextBox.Text != "")
            {
                ContraseñatextBox.PasswordChar = '\0';
            }
        }
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            mostrarcontraseña();
        }
    }
}
