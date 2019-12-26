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
                settings = new Settings(
                    Interval:int.Parse(textBox1.Text),
                    Nesting:textBox2.Text,
                    Sites:(from object item in listBox1.Items select item.ToString()).ToArray<string>(),
                    Chastich:bunifuSwitch1.Value,
                    Tags:(from object item in listBox2.Items select item.ToString()).ToArray<string>());
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
            listBox2.Items.Clear();
            listBox2.Items.AddRange(settings.Tags);
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
            if (Check())
            {
                BinaryFormatter binFormat = new BinaryFormatter();
                using (Stream fStream = new FileStream("settings.dat",
                FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    if (settings != null)
                        settings = new Settings(
                            Interval: int.Parse(textBox1.Text),
                            Nesting: textBox2.Text,
                            Sites: (from object item in listBox1.Items select item.ToString()).ToArray<string>(),
                            Chastich: bunifuSwitch1.Value,
                            Tags: (from object item in listBox2.Items select item.ToString()).ToArray<string>());
                    binFormat.Serialize(fStream, settings);
                }
            }
        }

        private bool Check()
        {
            if (!int.TryParse(textBox1.Text, out int b))
            {
                textBox1.BackColor = Color.FromArgb(214, 141, 169);
                Message.Visible = true;
                return false;
            }
            if (textBox2.Text != "all" && !int.TryParse(textBox2.Text, out int c))
            {
                textBox2.BackColor = Color.FromArgb(214, 141, 169);
                Message.Visible = true;
                return false;
            }
            if (listBox1.Items.Count == 0)
            {
                listBox1.BackColor = Color.FromArgb(214, 141, 169);
                Message.Visible = true;
                return false;
            }
            textBox1.BackColor = SystemColors.Window;
            textBox2.BackColor = SystemColors.Window;
            listBox1.BackColor = SystemColors.Window;
            Message.Visible = false;
            return true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (NewTag.Text != string.Empty && !listBox2.Items.Contains(NewTag.Text))
                listBox2.Items.Add(NewTag.Text);
        }
    }
}
