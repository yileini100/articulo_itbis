using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace articulo_itbis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            double montoTotal = Convert.ToDouble(txt_Monto);

            // Calcular el descuento, el ITBIS y el monto neto a pagar según la escala
            double descuento = 0;
            double itbis = montoTotal * 0.18; 

            if (montoTotal >= 5001 && montoTotal <= 10000)
            {
                descuento = montoTotal * 0.03;
            }
            else if (montoTotal > 10000 && montoTotal <= 15000)
            {
                descuento = montoTotal * 0.05;
            }
            else if (montoTotal > 15000 && montoTotal <= 20000)
            {
                descuento = montoTotal * 0.08;
            }
            else if (montoTotal > 20000)
            {
                descuento = montoTotal * 0.1;
            }

            double montoNeto = montoTotal - descuento + itbis;
           
            txt_Monto_neto.Text = montoNeto.ToString("0.00");
            txt_Monto.Text = montoTotal.ToString("0.00");
            txt_Itbis.Text = itbis.ToString("0.00");
            txt_Descuento.Text = descuento.ToString("0.00");


        }

      
    }
}
