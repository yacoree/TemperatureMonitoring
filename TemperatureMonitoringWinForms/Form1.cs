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
    }
}
