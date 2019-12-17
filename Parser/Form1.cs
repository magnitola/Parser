using Parser.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parser
{
    public partial class Form1 : Form
    {
        AllHtmlLoader Loader = new AllHtmlLoader();
        public Form1()
        {
            InitializeComponent();
            Loader.NewData += Loader_NewData;
            Loader.OnCompleted += Loader_OnCompleted;
        }

        private void Loader_OnCompleted(bool f1)
        {
            if (f1)
                MessageBox.Show("Все прошло успешно!");
            else
                MessageBox.Show("Произошла ошибка в считывании!");
        }

        //listBox1.Invoke((MethodInvoker)delegate { listBox1.Items.Add(str.Title); });
        //Loader.GoLoad(textBox1.Text);

        private void Loader_NewData(IArticle str)
        {
            
        }

        private void bunifuTextbox1_Enter(object sender, EventArgs e)
        {
            if (search.Text == "Текст")
            {
                search.Text = null;
                //search.ForeColor = Color.Black;
            }
        }

        private void search_Leave(object sender, EventArgs e)
        {
            if (search.Text == String.Empty)
            {
                search.Text = "Текст";
                //text.ForeColor = Color.Gray;
            }
        }
    }
}
