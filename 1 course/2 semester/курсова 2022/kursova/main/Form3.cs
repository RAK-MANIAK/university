using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace main
{
    public partial class Form3 : Form
    {
        public class RecordEasy
        {
            public string easyName { get; set; }
            public int easyTime { get; set; }
        }
        public class RecordMedium
        {
            public string mediumName { get; set; }
            public int mediumTime { get; set; }
        }
        public class RecordHard
        {
            public string hardName { get; set; }
            public int hardTime { get; set; }
        }
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            if (Settings.konami == true)
            {
                BackgroundImage = Image.FromFile("files\\space.jpg");
                richTextBox1.BackColor = Color.Black;
                richTextBox2.BackColor = Color.Black;
                richTextBox3.BackColor = Color.Black;
                textBox4.BackColor = Color.Black;
                textBox5.BackColor = Color.Black;
                textBox6.BackColor = Color.Black;
            }
            Settings.recordCount = 0;
            this.FormClosing += Form3_Closing;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Settings.recordList = 0;
            read_Easy();
            read_Medium();
            read_Hard();
        }

        private void Form3_Closing(Object sender, FormClosingEventArgs e)
        {
            Form main = Application.OpenForms[0];
            if (Settings.konami == true)
                main.BackgroundImage = Image.FromFile("files\\space.jpg");
            main.Show();
        }

        private async Task read_Hard()
        {
            richTextBox3.Text = null;
            textBox6.Text = null;
            List<RecordHard> recordHard = new List<RecordHard>();
            string line;
            StreamReader readerHard = File.OpenText("files\\hard.txt");
            for (int i = 0; (line = await readerHard.ReadLineAsync()) != null; i++)
            {
                recordHard.Add(new RecordHard() { hardName = line, hardTime = int.Parse(await readerHard.ReadLineAsync()) });
                if (i > Settings.recordCount)
                    Settings.recordCount = i;
            }
            readerHard.Close();

            if (Properties.Settings.Default.Language == "en-US")
                richTextBox3.Text += "\t\tHard";
            else if (Properties.Settings.Default.Language == "pl-PL")
                richTextBox3.Text += "\t\tTrudny";
            else
                richTextBox3.Text += "\t\tВажкий";

            recordHard.Sort(delegate (RecordHard a, RecordHard b)
            { return a.hardTime.CompareTo(b.hardTime); });
            for (int i = 14 * Settings.recordList; i < 14 * (Settings.recordList + 1) || i < recordHard.Count; i++)
            {
                richTextBox3.Text += "\n" + (i + 1) + "." + recordHard[i].hardName;
                textBox6.Text += "\t" + recordHard[i].hardTime;
            }
        }


        private async Task read_Medium()
        {
            richTextBox2.Text = null;
            textBox5.Text = null;
            List<RecordMedium> recordMedium = new List<RecordMedium>();
            string line;
            StreamReader readerMedium = File.OpenText("files\\medium.txt");
            for (int i = 0; (line = await readerMedium.ReadLineAsync()) != null; i++)
            {
                recordMedium.Add(new RecordMedium() { mediumName = line, mediumTime = int.Parse(await readerMedium.ReadLineAsync()) });
                if (i > Settings.recordCount)
                    Settings.recordCount = i;
            }
            readerMedium.Close();

            if (Properties.Settings.Default.Language == "en-US")
                richTextBox2.Text += "\t\tMedium";
            else if (Properties.Settings.Default.Language == "pl-PL")
                richTextBox2.Text += "\t\tŚrednio";
            else
                richTextBox2.Text += "\t\tСередній";

            recordMedium.Sort(delegate (RecordMedium a, RecordMedium b)
            { return a.mediumTime.CompareTo(b.mediumTime); });
            for (int i = 14 * Settings.recordList; i < 14 * (Settings.recordList + 1) || i < recordMedium.Count; i++)
            {
                richTextBox2.Text += "\n" + (i + 1) + "." + recordMedium[i].mediumName;
                textBox5.Text += "\t" + recordMedium[i].mediumTime;
            }
        }
        private async Task read_Easy()
        {
            richTextBox1.Text = null;
            textBox4.Text = null;
            List<RecordEasy> recordEasy = new List<RecordEasy>();
            string line;
            StreamReader readerEasy = File.OpenText("files\\easy.txt");
            for (int i = 0; (line = await readerEasy.ReadLineAsync()) != null; i++)
            {
                recordEasy.Add(new RecordEasy() { easyName = line, easyTime = int.Parse(await readerEasy.ReadLineAsync()) });
                if (i > Settings.recordCount)
                    Settings.recordCount = i;
            }
            readerEasy.Close();

            if (Properties.Settings.Default.Language == "en-US")
                richTextBox1.Text += "\t\tEasy";
            else if (Properties.Settings.Default.Language == "pl-PL")
                richTextBox1.Text += "\t\tŁatwo";
            else
                richTextBox1.Text += "\t\tЛегкий";

            recordEasy.Sort(delegate (RecordEasy a, RecordEasy b)
             { return a.easyTime.CompareTo(b.easyTime); });
            for (int i = 14 * Settings.recordList; i < 14 * (Settings.recordList + 1) && i < recordEasy.Count; i++)
            {
                richTextBox1.Text += "\n" + (i + 1) + "." + recordEasy[i].easyName;
                textBox4.Text += "\t" + recordEasy[i].easyTime;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Settings.recordList >= 1)
            {
                Settings.recordList--;
                read_Easy();
                read_Medium();
                read_Hard();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (14 * (Settings.recordList + 1) < Settings.recordCount + 1)
            {
                Settings.recordList++;
                read_Easy();
                read_Medium();
                read_Hard();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
    }
}