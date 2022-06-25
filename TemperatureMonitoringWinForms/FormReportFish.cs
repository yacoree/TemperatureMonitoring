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
    public partial class FormReportFish : System.Windows.Forms.Form
    {
        TemperatureSensorReport tsReport;
        public FormReportFish()
        {
            InitializeComponent();
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
                    MessageBox.Show("Условия хранения соблюдены");
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

        private void tbKeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && e.KeyChar != 45)
            {
                e.Handled = true;
            }
        }
        private void tbKeyPresstemperature(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && e.KeyChar != 45 
                && e.KeyChar != 32 && e.KeyChar != 46 && e.KeyChar != 58)
            {
                e.Handled = true;
            }
        }

        private void saveTemperatureSensorReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using StreamWriter sw = new StreamWriter(saveFileDialog.FileName, false);
                    string date = tbDate.Text;
                    string temperature = tbTemperature.Text;
                    sw.WriteLine(date);
                    sw.WriteLine(temperature);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void saveFishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using StreamWriter sw = new StreamWriter(saveFileDialog.FileName, false);
                    string kindOfFish = tbKindOfFish.Text;
                    int maxStorageTemperature = Int32.Parse(tbMaxStorageTemperature.Text);
                    int timeExceededMaxTemperature = Int32.Parse(tbTimeExceededMaxTemperature.Text);
                    sw.WriteLine(kindOfFish);
                    sw.WriteLine(maxStorageTemperature);
                    sw.WriteLine(timeExceededMaxTemperature);
                    if ((tbMinStorageTemperature.Text != "") && (tbTimeExceededMinTemperature.Text != ""))
                    {
                        int minStorageTemperature = Int32.Parse(tbMinStorageTemperature.Text);
                        int timeExceededMinTemperature = Int32.Parse(tbTimeExceededMinTemperature.Text);
                        sw.WriteLine(minStorageTemperature);
                        sw.WriteLine(timeExceededMinTemperature);
                    }
                    else 
                    {
                        sw.Write("!1");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void loadFishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Fish fish;
                    using StreamReader sw = new StreamReader(openFileDialog.FileName, false);
                    string kindOfFish = sw.ReadLine();
                    int maxStorageTemperature = Int32.Parse(sw.ReadLine());
                    int timeExceededMaxTemperature = Int32.Parse(sw.ReadLine());
                    string minStorageTemperature = sw.ReadLine();
                    tbKindOfFish.Text = kindOfFish;
                    tbMaxStorageTemperature.Text = "" + maxStorageTemperature;
                    tbTimeExceededMaxTemperature.Text = "" + timeExceededMaxTemperature;
                    if (minStorageTemperature == "!1")
                    {
                        fish = new Fish(kindOfFish, maxStorageTemperature, timeExceededMaxTemperature);
                        tbMinStorageTemperature.Text = "";
                        tbTimeExceededMinTemperature.Text = "";
                    }
                    else 
                    {
                        int minStorageTemperaturei = Int32.Parse(minStorageTemperature);
                        int timeExceededMinTemperature = Int32.Parse(sw.ReadLine());
                        fish = new Fish(kindOfFish, maxStorageTemperature, timeExceededMaxTemperature,
                            minStorageTemperaturei, timeExceededMinTemperature);
                        tbMinStorageTemperature.Text = minStorageTemperature;
                        tbTimeExceededMinTemperature.Text = "" + timeExceededMinTemperature;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
