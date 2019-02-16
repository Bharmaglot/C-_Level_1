using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherHomeWork
{
    delegate void GetData(string Msg);

    public partial class Form1 : Form
    {
        Repository data;
        GetData getDataEvent;


        public Form1()
        {
            InitializeComponent();

            data = new Repository();
            getDataEvent = Logging.Log;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(var item in data.Citys)
            {
                lbCitys.Items.Add(item);
            }
        }

        private void lbCitys_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbCitys.SelectedIndex == -1) return;
                
            City selectedCity = (City)lbCitys.SelectedItem;
            getDataEvent($" Выбрал{selectedCity.CityName} в {DateTime.Now}. Данные: { selectedCity.Print()}");

            lblPressureValueMin.Text = $"{selectedCity.PressureMin} мм.рт.ст";
            lblPressureValueMax.Text = $"{selectedCity.PressureMax} мм.рт.ст";
            lblTemperatureValueMin.Text = $"{selectedCity.TemperatureMin} °c";
            lblTemperatureValueMax.Text = $"{selectedCity.TemperatureMax} °c";
            lblDateValue.Text = $"{selectedCity.CityDate}";
            lblTimeValue.Text = $"{selectedCity.CityTime}:00";
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormAboutProgram().ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
