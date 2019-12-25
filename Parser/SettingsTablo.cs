using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Parser
{
    public partial class SettingsTablo : UserControl
    {
        internal Settings settings;
        public SettingsTablo()
        {
            InitializeComponent();
            if (File.Exists("settings.dat"))
            {
                LoadSettings();
            }
            else
                settings = new Settings(int.Parse(textBox1.Text), textBox2.Text, (from object item in listBox1.Items select item.ToString()).ToArray<string>(), bunifuSwitch1.Value);
            toolTip1.SetToolTip(label5, "В включенном состоянии вам будут попадаться записи, которые частично совпадают с запросом.\n\n То есть, если у вас запрос \"деревянные дома\", то вам будут попадаться сайты, в которых есть слово \"деревянные\" или \"дома\"");
            toolTip1.SetToolTip(label1, "Раз в сколько секунд программа будет обращаться к сайту.\n\nЧем меньше значение, тем выше шанс, что сайт посчитает нас ботом и не отдаст нам данные");
            toolTip1.SetToolTip(label2, "Сколько уровней сайта проанализирует программа.\n\nЧем больше значение, тем больше времени займет поиск информации, но статей будет найдено больше.\n\nПоставьте значение \"all\", чтобы проанализировать все сайты полностью");
        }

        public void LoadSettings()
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            using (Stream fStream = new FileStream("settings.dat",
            FileMode.Open, FileAccess.Read, FileShare.None))
            {
                settings = (Settings)binFormat.Deserialize(fStream);
            }
            bunifuSwitch1.Value = settings.Chastich;
            textBox1.Text = settings.Interval.ToString();
            textBox2.Text = settings.Nesting;
            listBox1.Items.Clear();
            listBox1.Items.AddRange(settings.Sites);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NewSite.Text != string.Empty && NewSite.Text.Contains(".") && !listBox1.Items.Contains(NewSite.Text))
                listBox1.Items.Add(NewSite.Text);
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (listBox1.SelectedItem != null)
                if (e.KeyData == Keys.Delete)
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            using (Stream fStream = new FileStream("settings.dat",
            FileMode.Create, FileAccess.Write, FileShare.None))
            {
                if (settings != null)
                    settings = new Settings(int.Parse(textBox1.Text), textBox2.Text, (from object item in listBox1.Items select item.ToString()).ToArray<string>(), bunifuSwitch1.Value);
                binFormat.Serialize(fStream, settings);
            }
        }
    }
}
