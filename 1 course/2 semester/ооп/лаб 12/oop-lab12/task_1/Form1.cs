using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net;
using System.Reflection.Emit;

namespace task_1
{
    public partial class Form1 : Form
    {
        public class Weather
        {
            public string Temperature { private set; get; }
            public string Wind { private set; get; }
            public string WindWay { private set; get; }
            public string Wet { private set; get; }
            public string WaterTemp { private set; get; }
            public Weather(string str, string str1, string str2)
            {
                Regex regex = new Regex("<span class=\"sign\">(\\+|-)<\\/span>(\\d+|0)<span class=\"lower\">,(\\d+)<\\/span>", RegexOptions.Compiled);
                Match match = regex.Match(str);
                Temperature = match.Groups[1].Value + match.Groups[2].Value + "," + match.Groups[3].Value;
                Regex regex1 = new Regex("<span class=\"wind-unit unit unit_wind_m_s\">([0-9]) <\\/span>");
                Match match1 = regex1.Match(str);
                Wind = match1.Groups[1].Value;
                Regex regex2 = new Regex("<div class=\"direction\">([А-Я][а-я]?[А-Я])<\\/div>");
                Match match2 = regex2.Match(str);
                WindWay = match2.Groups[1].Value;
                Regex regex3 = new Regex("<div class=\"row-item item-8\">([0-9]{2})<\\/div>");
                Match match3 = regex3.Match(str);
                Wet = match3.Groups[1].Value;
                Regex regex4 = new Regex("<span class=\"unit unit_temperature_c\">(\\+[0-9]{2}\\,[0-9])<\\/span>");
                Match match4 = regex4.Match(str2);
                WaterTemp = match4.Groups[1].Value;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "https://sinst.fwdcdn.com/img/weatherImg/b/d400.jpg";
            WebClient web = new WebClient();
            web.Encoding = Encoding.UTF8;
            string htmlcode = web.DownloadString("https://www.gismeteo.ua/ua/weather-zhytomyr-4943/");
            WebClient web1 = new WebClient();
            web1.Encoding = Encoding.UTF8;
            string htmlcode1 = web1.DownloadString("https://ua.sinoptik.ua/%D0%BF%D0%BE%D0%B3%D0%BE%D0%B4%D0%B0-%D0%B6%D0%B8%D1%82%D0%BE%D0%BC%D0%B8%D1%80");
            WebClient web2 = new WebClient();
            web2.Encoding = Encoding.UTF8;
            string htmlcode2 = web2.DownloadString("https://www.gismeteo.ua/ua/");
            Weather weather = new Weather(htmlcode, htmlcode1, htmlcode2);
            label7.Text = weather.Temperature + " C";
            label8.Text = weather.Wind + " м/c";
            label9.Text = weather.WindWay;
            label10.Text = weather.Wet + " %";
            label11.Text = weather.WaterTemp + " C";
        }
    }
}
