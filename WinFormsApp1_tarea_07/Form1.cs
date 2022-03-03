using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1_tarea_07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttn_calcular_Click(object sender, EventArgs e)
        {
            if (bttn_calcular.Text.Equals("Calcular"))
            {
                if (!txtBx_entrada.Text.Equals("")) {
                    bttn_calcular.Text = "Clear";
                    txtBx_entrada.Enabled = false;
                    //Tarea_07
                    ulong entrada = ulong.Parse(txtBx_entrada.Text);
                    ulong cantidad_esferas = entrada * (entrada + 1) / 2;
                    txtBx_salida_tarea_07.Text = "La cantidad de esferas es: " + cantidad_esferas.ToString();

                    //Tarea_08
                    cantidad_esferas = entrada * (entrada + 1) - entrada;
                    txtBx_salida_tarea_08.Text = "La cantidad de esferas es: " + cantidad_esferas.ToString();

                }
            }
            else {
                txtBx_entrada.Text = "";
                txtBx_salida_tarea_07.Text = "";
                txtBx_salida_tarea_08.Text = "";
                bttn_calcular.Text = "Calcular";
                txtBx_entrada.Enabled = true;
            }
        }

        private void txtBx_entrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            //el textBox de entrada solo puede recibir numeros.
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }

        private void txtBx_salida_tarea_08_KeyPress(object sender, KeyPressEventArgs e)
        {
            //el textBox de salida (tarea_08) no puede recibir valores.
            if (e.KeyChar >= 0 && e.KeyChar <= 255)
            {
                e.Handled = true;
            }
        }

        private void txtBx_salida_tarea_07_KeyPress(object sender, KeyPressEventArgs e)
        {
            //el textBox de salida (tarea_08) no puede recibir valores.
            if (e.KeyChar >= 0 && e.KeyChar <= 255)
            {
                e.Handled = true;
            }
        }
    }
}
