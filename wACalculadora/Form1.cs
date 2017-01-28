using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace waCalculadora
{
    public partial class Form1 : Form
    {
        double priValor = 0, segValor = 0, total = 0;
        char op = '0';

        public Form1()
        {
            InitializeComponent();
        }

        private void txtB1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtB1.Text = txtB1.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtB1.Text = txtB1.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtB1.Text = txtB1.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtB1.Text = txtB1.Text + "4";
        }

        private void bnt5_Click(object sender, EventArgs e)
        {
            txtB1.Text = txtB1.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtB1.Text = txtB1.Text + "6";
        }

        private void bnt7_Click(object sender, EventArgs e)
        {
            txtB1.Text = txtB1.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtB1.Text = txtB1.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtB1.Text = txtB1.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtB1.Text = txtB1.Text + "0";
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            if(txtB1.Text=="")
            {
                MessageBox.Show("Não existe valor para calculo");
            }
            else
            {
                priValor = Convert.ToDouble(txtB1.Text);
                txtB1.Text = "";
                op = '+';
            }
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            if(txtB1.Text == "")
            {
                MessageBox.Show("Não existe valor para calculo");
            }
            else
            {
                priValor = Convert.ToDouble(txtB1.Text);
                txtB1.Text = "";
                op = '-';
            }
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            if(txtB1.Text == "")
            {
                MessageBox.Show("Não existe valor para calculo");
            }
            else
            {
                priValor = Convert.ToDouble(txtB1.Text);
                txtB1.Text = "";
                op = '*';
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if(txtB1.Text == "")
            {
                MessageBox.Show("Não existe valor para calcular");
            }
            else
            {
                priValor = Convert.ToDouble(txtB1.Text);
                txtB1.Text = "";
                op = '/';
            }
        }

        private void btnLimpa_Click(object sender, EventArgs e)
        {
            txtB1.Text = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            switch(op)
            {
                case'+':
                    if (txtB1.Text == "")
                    {
                        MessageBox.Show("Não existe valor para o calculo");
                        op = '0';
                    }
                    else
                    {
                        segValor = Convert.ToDouble(txtB1.Text);
                        total = priValor + segValor;
                        txtB1.Text = Convert.ToString(total);
                        op = '0';
                    }
                    break;

                case '-':
                    if (txtB1.Text == "")
                    {
                        MessageBox.Show("Não existe valor para o calculo");
                        op = '0';
                    }
                    else
                    {
                        segValor = Convert.ToDouble(txtB1.Text);
                        total = priValor - segValor;
                        txtB1.Text = Convert.ToString(total);
                        op = '0';
                    }
                    break;

                case '*':
                    if (txtB1.Text == "")
                    {
                        MessageBox.Show("Não existe valor para o calculo");
                        op = '0';
                    }
                    else
                    {
                        segValor = Convert.ToDouble(txtB1.Text);
                        total = priValor * segValor;
                        txtB1.Text = Convert.ToString(total);
                        op = '0';
                    }
                    break;

                case '/':
                    if (txtB1.Text == "")
                    {
                        MessageBox.Show("Não existe valor para o calculo");
                        op = '0';
                    }
                    else
                    {
                        segValor = Convert.ToDouble(txtB1.Text);
                        total = priValor / segValor;
                        txtB1.Text = Convert.ToString(total);
                        op = '0';
                    }
                    break;
            }
        }


    }
}
