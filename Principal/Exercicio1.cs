using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public partial class Exercicio1 : Form
    {

        public Exercicio1()
        {
            InitializeComponent();
        }

        private void cmbFim_SelectedIndexChanged(object sender, EventArgs e)
        {
            int valor1, valor2, cont;

            valor1 = int.Parse(cmbInicio.Text);

            valor2 = int.Parse(cmbFim.Text);

            if (valor1 < valor2)
            {
                for (cont = valor1; cont == valor2; cont++)
                {
                    lstNumeros.Items.Add(cont);
                }
            }
            else
            {
                for (cont = valor1; cont == valor2; cont--)
                {
                    lstNumeros.Items.Add(cont);
                }
            }
        }
    }
}
