using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tables;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private List<float> MeasuredData;
        private Table _table;
        public Form1()
        {
            InitializeComponent();
            textBoxPdov.Text = "0.95";
            _table = new Table();
            timer1.Start();
            MeasuredData = new List<float>();

        }

        private void buttonAddMeasurements_Click(object sender, EventArgs e)
        {
            try
            {
                float value = (float)Convert.ToDouble(textBoxNewDimension.Text);
                MeasuredData.Add(value);
                listBoxMeasurements.Items.Add("L" + MeasuredData.Count + " = " + value);
                //textBoxNewDimension.Text = "";
            }
            catch
            {
                MessageBox.Show("Данные введены не корректно");
            }
        }

        private void buttonRemoveMeasurements_Click(object sender, EventArgs e)
        {
            try
            {
                MeasuredData.Remove(MeasuredData[listBoxMeasurements.SelectedIndex]);
                listBoxMeasurements.Items.Remove(listBoxMeasurements.SelectedItem);
            }
            catch
            {
                MessageBox.Show("Данные не выбраны");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float value = 0f;
            foreach (float sum in MeasuredData)
            {
                value += sum;
            }
            value *= 1 / (float)MeasuredData.Count;
            textBoxAverageValue.Text = value.ToString();
        }

        private float SearchMax()
        {
            float value = MeasuredData[0];
            foreach (float max in MeasuredData)
            {
                value = value < max ? max : value;
            }
            return value;
        }

        private float SearchMin()
        {
            float value = MeasuredData[0];
            foreach (float min in MeasuredData)
            {
                value = value > min ? min : value;
            }
            return value;
        }

        private void buttonAverageQuadratic_Click(object sender, EventArgs e)
        {
            float sum = 0;
            foreach (float val in MeasuredData)
            {
                var pow = (float)Math.Pow(val -
                    (float)Convert.ToDouble(textBoxAverageValue.Text), 2);
                sum += pow / (MeasuredData.Count - 1);
            }
            sum = (float)Math.Sqrt(sum);
            textBoxAverageQuadratic.Text = sum.ToString();
        }

        private void buttonLMax_Click(object sender, EventArgs e)
        {
            textBoxLMax.Text = SearchMax().ToString();
        }

        private void buttonLMin_Click(object sender, EventArgs e)
        {
            textBoxLMin.Text = SearchMin().ToString();
        }

        private void buttonBMax_Click(object sender, EventArgs e)
        {
            float sum = Math.Abs((float)Convert.ToDouble(textBoxLMax.Text) -
                (float)Convert.ToDouble(textBoxAverageValue.Text)) /
                (float)Convert.ToDouble(textBoxAverageQuadratic.Text);
            textBoxBMax.Text = sum.ToString();
        }

        private void buttonBMin_Click(object sender, EventArgs e)
        {
            float sum = Math.Abs((float)Convert.ToDouble(textBoxLMin.Text) -
                (float)Convert.ToDouble(textBoxAverageValue.Text)) /
                (float)Convert.ToDouble(textBoxAverageQuadratic.Text);
            textBoxBMin.Text = sum.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if((float)Convert.ToDouble(textBoxBMax.Text) > (float)Convert.ToDouble(textBoxBtab.Text))
            {
                textBoxBMaxResult.Text = textBoxLMax.Text + " промах";
            }
            else
            {
                textBoxBMaxResult.Text = "Истина";
            }
        }

        private void buttonBMinCheck_Click(object sender, EventArgs e)
        {
            if ((float)Convert.ToDouble(textBoxBMin.Text) > (float)Convert.ToDouble(textBoxBtab.Text))
            {
                textBoxBMinResult.Text = textBoxLMin.Text + " промах";
            }
            else
            {
                textBoxBMinResult.Text = "Истина";
            }
        }

        private void buttonSx_Click(object sender, EventArgs e)
        {
            float Sx = 0;
            foreach (float val in MeasuredData)
            {
                Sx += (float)Math.Pow(val -
                    (float)Convert.ToDouble(textBoxAverageValue.Text), 2) /
                    (MeasuredData.Count * ((float)MeasuredData.Count - 1));
            }
            Sx = (float)Math.Sqrt(Sx);
            textBoxSx.Text = Sx.ToString();
        }

        private void buttonDelX_Click(object sender, EventArgs e)
        {
            float rand = (float)Convert.ToDouble(textBoxTpn.Text) * (float)Convert.ToDouble(textBoxSx.Text);

            textBoxDelX.Text = rand.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (MeasuredData.Count >= 4 && MeasuredData.Count <= 28)
            {
                textBoxBtab.Text = _table.CriticalValues[MeasuredData.Count - 4].ToString();
                textBoxTpn.Text = _table.StudentQuantiles[MeasuredData.Count - 4].ToString();
            }
        }
    }
}
