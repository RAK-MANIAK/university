using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using WMPLib;
using System.IO;

namespace main
{
    public partial class Form1 : Form
    {
        Music music = new Music();
        public Form1()
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
            System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo(Properties.Settings.Default.Language);
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            this.FormClosing += Form1_Closing;
            textBox1.MaxLength = 10;
            textBox2.MaxLength = 10;
            textBox3.MaxLength = 10;
            textBox4.MaxLength = 14;
            textBox5.MaxLength = 3;
            nickname(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings.gameName = textBox4.Text;
            if (Settings.gameName.Length == 0)
                Settings.gameName = "-";

            if (radioButton1.Checked)
            {
                nickname(false);
                Settings.gameLevel = 1;
                Settings.mapHeight = 9;
                Settings.mapWidth = 9;
                Settings.mapMin = 10;
                this.Hide();
                Form2 game = new Form2();
                game.Show();
            }

            if (radioButton2.Checked)
            {
                nickname(false);
                Settings.gameLevel = 2;
                Settings.mapHeight = 14;
                Settings.mapWidth = 14;
                Settings.mapMin = 35;
                this.Hide();
                Form2 game = new Form2();
                game.Show();
            }

            if (radioButton3.Checked)
            {
                nickname(false);
                Settings.gameLevel = 3;
                Settings.mapHeight = 15;
                Settings.mapWidth = 23;
                Settings.mapMin = 75;
                this.Hide();
                Form2 game = new Form2();
                game.Show();
            }

            if (radioButton4.Checked)
            {
                Settings.gameLevel = 0;
                int mh, mw, mm, min = 0;
                if (int.TryParse(textBox1.Text, out mh) && mh > min && mh < 20)
                {
                    mh = int.Parse(textBox1.Text);
                    Settings.mapHeight = mh;
                }
                else
                {
                    if (Properties.Settings.Default.Language == "en-US")
                        MessageBox.Show("Error entering height!");
                    else if (Properties.Settings.Default.Language == "pl-PL")
                        MessageBox.Show("Błąd podczas wprowadzania wysokości!");
                    else
                        MessageBox.Show("Помилка введення висоти!");
                    textBox1.Text = null;
                    mh = 0;
                }

                ////

                if (int.TryParse(textBox2.Text, out mw) && mw > min && mw < 40)
                {
                    mw = int.Parse(textBox2.Text);
                    Settings.mapWidth = mw;
                }
                else
                {
                    if (Properties.Settings.Default.Language == "en-US")
                        MessageBox.Show("Width input error!");
                    else if (Properties.Settings.Default.Language == "pl-PL")
                        MessageBox.Show("Błąd podczas wprowadzania wysokości!");
                    else
                        MessageBox.Show("Błąd wprowadzania szerokości!");
                    textBox2.Text = null;
                    mw = 0;
                }

                ////

                if (int.TryParse(textBox3.Text, out mm) && mm > 0)
                {
                    if (mm > (mh * mw) * 0.9)
                        mm = Convert.ToInt32(Math.Round((mh * mw) * 0.9, 2));
                    else if (mh == 1 && mw == 1)
                        mm = 1;
                    else
                        mm = int.Parse(textBox3.Text);
                    Settings.mapMin = mm;
                }
                else
                {
                    if (Properties.Settings.Default.Language == "en-US")
                        MessageBox.Show("Error entering the number of mines!");
                    else if (Properties.Settings.Default.Language == "pl-PL")
                        MessageBox.Show("Błąd podczas wprowadzania liczby min!");
                    else
                        MessageBox.Show("Помилка введення кількості мін!");
                    textBox3.Text = null;
                    mm = 0;
                }

                if (mh > 0 && mw > 0 && mm > 0)
                {
                    nickname(false);
                    this.Hide();
                    Form2 game = new Form2();
                    game.Show();
                }
            }
            Settings.mapFlag = Settings.mapMin;

        }
        private async Task nickname(bool k)
        {
            if (Settings.gameName != "-" && k == false)
            {
                File.Create("files\\nickname.txt").Close();
                StreamWriter write = new StreamWriter("files\\nickname.txt", true);
                write.WriteLineAsync(Settings.gameName);
                write.Close();
            }
            if (k == true)
            {
                StreamReader read = File.OpenText("files\\nickname.txt");
                textBox4.Text = await read.ReadLineAsync();
                read.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 record = new Form3();
            record.Show();
        }
        bool lang = false;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lang = true;
            if (languages.SelectedIndex == 0 && lang)
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("uk-UA");
                System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("uk-UA");
                Properties.Settings.Default.Language = "uk-UA";
                Properties.Settings.Default.Save();
                Application.Restart();
                languages.Text = "Українська";
            }
            else if (languages.SelectedIndex == 1)
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
                System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");
                Properties.Settings.Default.Language = "en-US";
                Properties.Settings.Default.Save();
                Application.Restart();
                languages.Text = "English";
            }
            else if (languages.SelectedIndex == 2)
            {
                System.Threading.Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("pl-PL");
                System.Threading.Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("pl-PL");
                Properties.Settings.Default.Language = "pl-PL";
                Properties.Settings.Default.Save();
                Application.Restart();
                languages.Text = "Polski";
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            music.sound = 0;
            music.stop();
        }

        private void button_music_1_Click(object sender, EventArgs e)
        {
            volum();
            music.sound = 1;
            music.play_music_1();
        }

        private void button_music_2_Click(object sender, EventArgs e)
        {
            volum();
            music.sound = 2;
            music.play_music_2();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            volum();
            music.sound = 3;
            music.Random();
        }
        void volum()
        {
            int k;
            if (int.TryParse(textBox5.Text, out k))
            {
                if (k < 1)
                {
                    textBox5.Text = "1";
                    music.volum = 1;
                }
                else if (k > 100)
                {
                    textBox5.Text = "100";
                    music.volum = 100;
                }
                else music.volum = k;
            }
            else
            {
                textBox5.Text = null;
            }
        }
        private void Form1_Closing(Object sender, FormClosingEventArgs e)
        {
            Settings.gameName = textBox4.Text;
            if (Settings.gameName.Length == 0)
                Settings.gameName = "-";
            nickname(false);
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e) { }
        private void radioButton1_CheckedChanged(object sender, EventArgs e) { }
        private void radioButton2_CheckedChanged(object sender, EventArgs e) { }
        private void radioButton3_CheckedChanged(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
    }
}