﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task1
{
    public partial class frmGraphics : Form
    {
        public frmGraphics()
        {
            InitializeComponent();
        }

        private void chkCos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtZnach_TextChanged(object sender, EventArgs e)
        {

        }

        private void chartGraph_Click(object sender, EventArgs e)
        {

        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            chartGraph.Series[0].Points.Clear();
            chartGraph.Series[1].Points.Clear();
            chartGraph.Series[2].Points.Clear();
            chartGraph.Series[3].Points.Clear();
            chartGraph.Series[4].Points.Clear();
        }

        private void btCount_Click(object sender, EventArgs e)
        {
            txtZnach.Text = "";
            double Xmin, Xmax, Step;

            if (txtMax.Text == "" || txtMax.Text == "" || txtStep.Text == "")
            { MessageBox.Show("Не всі дані введено!", "Помилка вводу!"); }
            else
            {
                Xmin = double.Parse(txtMin.Text);
                Xmax = double.Parse(txtMax.Text);
                Step = double.Parse(txtStep.Text);

                if (Xmin >= Xmax || Step <= 0)
                { MessageBox.Show("Помилка вводу даних!", "Помилка вводу!"); }

                else
                {
                    int count = (int)Math.Ceiling((Xmax - Xmin) / Step) + 1;

                    double[] x = new double[count];
                    double[] y1 = new double[count];
                    double[] y2 = new double[count];
                    double[] y3 = new double[count];
                    double[] y4 = new double[count];
                    double[] y5 = new double[count];

                    for (int i = 0; i < count; i++)
                    {
                        x[i] = Xmin + Step * i;
                        y1[i] = Math.Sin(x[i]);
                        y2[i] = Math.Cos(x[i]);
                        y3[i] = Math.Cos(x[i]) + 2 * x[i];
                        y4[i] = Math.Sqrt(x[i]);
                        y5[i] = 4 + x[i] + Math.Pow(x[i], 2);

                        switch (cbGraphics.SelectedIndex)
                        {
                            case 0: txtZnach.Text += "x[" + i.ToString() + "] = " + Convert.ToString(x[i]) + "   " + "y1[" + i.ToString() + "] = " + Convert.ToString(Math.Round(y1[i], 5)) + Environment.NewLine; break;
                            case 1: txtZnach.Text += "x[" + i.ToString() + "] = " + Convert.ToString(x[i]) + "   " + "y2[" + i.ToString() + "] = " + Convert.ToString(Math.Round(y2[i], 5)) + Environment.NewLine; break;
                            case 2: txtZnach.Text += "x[" + i.ToString() + "] = " + Convert.ToString(x[i]) + "   " + "y3[" + i.ToString() + "] = " + Convert.ToString(Math.Round(y3[i], 5)) + Environment.NewLine; break;
                            case 3: txtZnach.Text += "x[" + i.ToString() + "] = " + Convert.ToString(x[i]) + "   " + "y4[" + i.ToString() + "] = " + Convert.ToString(Math.Round(y4[i], 5)) + Environment.NewLine; break;
                            case 4: txtZnach.Text += "x[" + i.ToString() + "] = " + Convert.ToString(x[i]) + "   " + "y5[" + i.ToString() + "] = " + Convert.ToString(Math.Round(y5[i], 5)) + Environment.NewLine; break;
                            default: txtZnach.Text = "Графік не обрано!"; break;
                        }
                    }

                    chartGraph.ChartAreas[0].AxisX.Minimum = Xmin;
                    chartGraph.ChartAreas[0].AxisX.Maximum = Xmax;

                    chartGraph.ChartAreas[0].AxisX.MajorGrid.Interval = Step;

                    if (chkSin.Checked) { chartGraph.Series[0].Points.DataBindXY(x, y1); }
                    if (chkCos.Checked) { chartGraph.Series[1].Points.DataBindXY(x, y2); }
                    if (chkCos2.Checked) { chartGraph.Series[2].Points.DataBindXY(x, y3); }
                    if (chkFunc1.Checked) { chartGraph.Series[3].Points.DataBindXY(x, y4); }
                    if (chkFunc2.Checked) { chartGraph.Series[4].Points.DataBindXY(x, y5); }
                }
            }

        }

        private void frmGraphics_Load(object sender, EventArgs e)
        {
            cbGraphics.Items.Add("Графік sin(x)");
            cbGraphics.Items.Add("Графік cos(x)");
            cbGraphics.Items.Add("Графік cos(x) + 2x");
            cbGraphics.Items.Add("Графік кв.корінь(х)");
            cbGraphics.Items.Add("Графік 4 + х + х^2");
        }
    }
}
