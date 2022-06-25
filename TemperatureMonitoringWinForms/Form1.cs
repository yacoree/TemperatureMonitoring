using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TemperatureMonitoring;

namespace TemperatureMonitoringWinForms
{
    public partial class Form1 : Form
    {
        TemperatureSensorReport tsReport;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using StreamReader sw = new StreamReader(openFileDialog.FileName, false);
                    var date = sw.ReadLine();
                    var temperatures = sw.ReadLine();
                    tsReport = new TemperatureSensorReport(date, temperatures);
                    tbTemperature.Text = temperatures;
                    tbDate.Text = date;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnGetReport_Click(object sender, EventArgs e)
        {
            try
            {
                Fish fish;
                string kindOfFish = tbKindOfFish.Text;
                int maxStorageTemperature = Int32.Parse(tbMaxStorageTemperature.Text);
                int timeExceededMaxTemperature = Int32.Parse(tbTimeExceededMaxTemperature.Text);
                if ((tbMinStorageTemperature.Text == "") || (tbTimeExceededMinTemperature.Text == ""))
                {
                    fish = new Fish(kindOfFish, maxStorageTemperature, timeExceededMaxTemperature);
                }
                else 
                {
                    int minStorageTemperature = Int32.Parse(tbMinStorageTemperature.Text);
                    int timeExceededMinTemperature = Int32.Parse(tbTimeExceededMinTemperature.Text);
                    fish = new Fish(kindOfFish, maxStorageTemperature, timeExceededMaxTemperature,
                        minStorageTemperature, timeExceededMinTemperature);
                }
                var i = fish.CreateREport(tsReport);
                if (i != "")
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            using StreamWriter sw = new StreamWriter(saveFileDialog.FileName, false);
                            sw.Write(i);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    MessageBox.Show("Условия хранения не соблюдены\n" + i);
                }
                else 
                {
                    MessageBox.Show("Условия хранения соблюдены\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using StreamReader sw = new StreamReader(openFileDialog.FileName, false);
                    var date = sw.ReadLine();
                    var temperatures = sw.ReadLine();
                    tsReport = new TemperatureSensorReport(date, temperatures);
                    tbTemperature.Text = temperatures;
                    tbDate.Text = date;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
