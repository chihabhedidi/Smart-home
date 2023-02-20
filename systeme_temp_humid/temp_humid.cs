using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System;
using System.Net;

namespace systeme_temp_humid
{
    public partial class temp_humid : DevExpress.XtraEditors.XtraForm
    {
        public temp_humid()
        {

            InitializeComponent();

        }


        private void temp_humid_Load(object sender, EventArgs e)
        {

            var web = new HtmlWeb();
            var doc = web.Load("http://192.168.193.26/");

            // Find the temperature and humidity values
            var temperatureNode = doc.DocumentNode.SelectSingleNode("//span[@id='temperature']");
            var humidityNode = doc.DocumentNode.SelectSingleNode("//span[@id='humidity']");

            // Extract the temperature and humidity values
            var temperature = temperatureNode.InnerText;
            var humidity = humidityNode.InnerText;

            // Print the values
            Console.WriteLine("Temperature: " + temperature);
            Console.WriteLine("Humidity: " + humidity);
            label1.Text = temperature;
            label2.Text = humidity;
        }
    }
}