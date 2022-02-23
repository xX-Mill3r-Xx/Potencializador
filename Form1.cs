using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Potenciador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Potencia_Click(object sender, EventArgs e)
        {
            double numx,numy, potencia;

            numx = -1;
            numy = -1;

            while(numx < 0 && numy < 0)
            {
                if(txt_ValorPotencia.Text == "" && txt_ValorDig.Text == "")
                {
                    txt_Result.ForeColor = Color.Red;
                    btn_Potencia.ForeColor = Color.Red;
                    txt_Result.Text = "Invalido";
                    txt_ValorDig.Focus();
                    return;
                }

                numx = double.Parse(txt_ValorPotencia.Text);
                numy = double.Parse(txt_ValorDig.Text);

                if(numx == -1 || numy == -1)
                {
                    txt_Result.ForeColor = Color.Red;
                    btn_Potencia.ForeColor = Color.Red;
                    txt_Result.Text = "Invalido";
                    txt_ValorDig.Focus();
                    return;
                }

                
            }

            potencia = Math.Pow(numx, numy);
            btn_Potencia.ForeColor = Color.Green;
            txt_Result.ForeColor = Color.Black;
            txt_Result.Text = potencia.ToString("F1");
            label2.ForeColor = Color.Green;
        }
    }
}
