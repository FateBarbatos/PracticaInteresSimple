using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaInteresSimple
{
    public partial class CalculoInteres : Form
    {
        public CalculoInteres()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string capitalInicial = txtCapitalInicial.Text;
            string interes = txtInteresGanado.Text;
            string time = txtYears.Text;
            double ganancia;
            string opcion = cbcPeriodosDeTiempo.Text;

            if (capitalInicial == "" || interes == ""|| time == "" || opcion == "")
            {
                MessageBox.Show("Ningun campo puede estar vacio");
            }
            else
            {
                switch (opcion)
                {
                    case "Años":
                        ganancia = (double.Parse(capitalInicial) * double.Parse(interes) * double.Parse(time));
                        MessageBox.Show("La ganancia es de:" + ganancia);
                        break;
                    case "Meses":
                        ganancia = (double.Parse(capitalInicial) * double.Parse(interes) * double.Parse(time))/12;
                        MessageBox.Show("La ganancia es de:" + ganancia);
                        break;
                    case "Dias":
                        ganancia = (double.Parse(capitalInicial) * double.Parse(interes) * double.Parse(time))/360;
                        MessageBox.Show("La ganancia es de:" + ganancia);
                        break;
                }
            }
        }
    }
}
