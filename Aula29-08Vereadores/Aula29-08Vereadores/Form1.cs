using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula29_08Vereadores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                int V1, V2, V3, V4;
                float P1, P2, P3, P4, Total;

                V1 = Convert.ToInt32(txtV1.Text);
                V2 = Convert.ToInt32(txtV2.Text);
                V3 = Convert.ToInt32(txtV3.Text);
                V4 = Convert.ToInt32(txtV4.Text);

                Total = V1 + V2 + V3 + V4;

                P1 = V1 / Total * 100;
                P2 = V2 / Total * 100;
                P3 = V3 / Total * 100;
                P4 = V4 / Total * 100;

                txtP1.Text = P1.ToString("n2");
                txtP2.Text = P2.ToString("n2");
                txtP3.Text = P3.ToString("n2");
                txtP4.Text = P4.ToString("n2");
                txtTotal.Text = Total.ToString();

            }
            catch
            {

                MessageBox.Show("Erro ao realizar o cálculo");


            }
           







        }
    }
}
