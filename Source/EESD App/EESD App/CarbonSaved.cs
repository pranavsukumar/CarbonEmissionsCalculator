using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EESD_App
{
    public partial class CarbonSaved : Form
    {
        public int city1;
        public int city2;
        public static List<double> carLengths = new List<double>();

        public static List<double> trainLengths = new List<double>();

        public double carbonSaved;
        public CarbonSaved()
        {
            InitializeComponent();
            carLengths.Add(18.7);
            carLengths.Add(7.6);
            carLengths.Add(4.7);
            carLengths.Add(11.6);
            carLengths.Add(13.2);

            trainLengths.Add(15.0);
            trainLengths.Add(6.0);
            trainLengths.Add(5.0);
            trainLengths.Add(10.0);
            trainLengths.Add(12.0);

            carbonSaved = 0;
        }

        public double calculateCarD(int c1, int c2)
        {
            double total = 0;

            for (int i = c1; i < c2; i++)
            {
                total += carLengths[i];
            }
            return total;
        }

        public double calculateTrainD(int c1, int c2)
        {
            double total = 0;

            for (int i = c1; i < c2; i++)
            {
                total += trainLengths[i];
            }
            return total;
        }

        private void CarbonSaved_Load(object sender, EventArgs e)
        {
            city1 = 0;
            city2 = 0;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            city1 = 0;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            city1 = 1;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            city1 = 2;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            city1 = 3;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            city1 = 4;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            city1 = 5;
        }


        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            city2 = 0;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            city2 = 1;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            city2 = 2;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            city2 = 3;
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            city2 = 4;
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            city2 = 5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double carL = calculateCarD(city1, city2);
            double trainL = calculateTrainD(city1, city2);

            carbonSaved = (((carL / 21.6) * 19.62) - (trainL * .204));
            carbonSaved = Math.Round(carbonSaved, 3);
            Displayer.Text = (carbonSaved + " lbs of CO2");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 openForm = new Form1();
            openForm.Show();
            Visible = false;
        }
    }
}
