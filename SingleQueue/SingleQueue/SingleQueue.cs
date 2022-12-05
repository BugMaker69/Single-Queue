// Copyright © 2022 Omar ElSaadany | All rights reserved
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingleQueue
{
    public partial class SingleQueue : Form
    {
        public SingleQueue()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void ClearTxt()
        {
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            ClearTxt();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ClearTxt();
        }

        void ErrorM()
        {
            MessageBox.Show("Enter No.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            label14.Text = "";
            double t4, t3,p;
            if (double.TryParse(textBox1.Text, out t4) && (double.TryParse(textBox2.Text, out t3)))
            {
                p=Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text);
                label14.Text = p.ToString();
            }
            else { ErrorM(); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label13.Text = "";
            double t4, t3, L;
            if (double.TryParse(textBox1.Text, out t4) && (double.TryParse(textBox2.Text, out t3)))
            {
                L = Convert.ToDouble(textBox1.Text) / (Convert.ToDouble(textBox2.Text) - Convert.ToDouble(textBox1.Text));
                label13.Text = L.ToString();
            }
            else { ErrorM(); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label12.Text = "";
            double t4, t3, L,p,Lq;
            if (double.TryParse(textBox1.Text, out t4) && (double.TryParse(textBox2.Text, out t3)))
            {
                p = Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text);
                L = Convert.ToDouble(textBox1.Text) / (Convert.ToDouble(textBox2.Text) - Convert.ToDouble(textBox1.Text));
                Lq = p * L;
                label12.Text = Lq.ToString();
            }
            else { ErrorM(); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label11.Text = "";
            double t4, t3,W;
            if (double.TryParse(textBox1.Text, out t4) && (double.TryParse(textBox2.Text, out t3)))
            {
                W= 1 / (Convert.ToDouble(textBox2.Text) - Convert.ToDouble(textBox1.Text));
                label11.Text = W.ToString();
            }
            else { ErrorM(); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label10.Text = "";
            double t4, t3,p,W,Wq;
            if (double.TryParse(textBox1.Text, out t4) && (double.TryParse(textBox2.Text, out t3)))
            {
                p = Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text);
                W = 1 / (Convert.ToDouble(textBox2.Text) - Convert.ToDouble(textBox1.Text));
                Wq = p * W;
                label10.Text = Wq.ToString();
            }
            else { ErrorM(); }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label9.Text="";
            double t4, t3, p,d=0,t;
            int n;
            if (double.TryParse(textBox1.Text, out t4) && (double.TryParse(textBox3.Text, out t3)))
            {
                p = Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text);
                n = Convert.ToInt32(textBox3.Text);

                for (int i = 0; i <= n; i++)
                {
                    d += Math.Pow(p, i);

                }
                t = (1 - (1 - p) * d);
                label9.Text = t.ToString();
            }
            else { ErrorM(); }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double t1, t2;
            int t3;
            if( double.TryParse(textBox1.Text,out t1) && double.TryParse(textBox2.Text, out t2) && int.TryParse(textBox3.Text, out t3))
            {

                double p = Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text);
                double L = Convert.ToDouble(textBox1.Text) / (Convert.ToDouble(textBox2.Text) - Convert.ToDouble(textBox1.Text));
                double Lq = p * L;
                double W = 1 / (Convert.ToDouble(textBox2.Text) - Convert.ToDouble(textBox1.Text));
                double Wq = p * W;
                int n = Convert.ToInt32(textBox3.Text);
                double d = 0;
                double t;
                for (int i = 0; i <= n; i++)
                {
                    d += Math.Pow(p, i);

                }
                t = (1 - (1 - p) * d);

                MessageBox.Show($"Average Utilization Of System: {p} \n" +
                    $"Avg No Of Customer in Service: {L} \n" +
                    $"Avg No OF Customer Wait In Line: {Lq} \n" +
                    $"Avg Time Spent Wait System: {W} \n" +
                    $"Avg Wait Time Spend in Line: {Wq} \n" +
                    $"Propability: {t}");
            }
            else { ErrorM(); }
        }
    }
}
// Copyright © 2022 Omar ElSaadany | All rights reserved