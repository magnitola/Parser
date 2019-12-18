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
            search.GoSearch += Search_GoSearch;
        }

        private void Search_GoSearch(string value)
        {
            Loader.GoLoad(value);
        }

        private void Loader_OnCompleted(bool f1)
        {
            if (f1)
                MessageBox.Show("Все прошло успешно!");
            else
                MessageBox.Show("Произошла ошибка в считывании!");
        }
        bool[] BusyArticles = { false, false, false, false, false };
        //listBox1.Invoke((MethodInvoker)delegate { listBox1.Items.Add(str.Title); });
        //Loader.GoLoad(textBox1.Text);
        private void Loader_NewData(IArticle str)
        {
            Article1.Invoke((MethodInvoker)delegate
           {
               if (!BusyArticles[0])
               {
                   Article1.ArticleTitle = str.Title;
                   Article1.ArticleText = str.Text;
                   Article1.ArticleDate = str.Date;
                   BusyArticles[0] = true;
               }
               else if (!BusyArticles[1])
               {
                   Article2.ArticleTitle = str.Title;
                   Article2.ArticleText = str.Text;
                   Article2.ArticleDate = str.Date;
                   BusyArticles[1] = true;
               }
               else if(!BusyArticles[2])
               {
                   Article3.ArticleTitle = str.Title;
                   Article3.ArticleText = str.Text;
                   Article3.ArticleDate = str.Date;
                   BusyArticles[2] = true;
               }
               else if(!BusyArticles[3])
               {
                   Article4.ArticleTitle = str.Title;
                   Article4.ArticleText = str.Text;
                   Article4.ArticleDate = str.Date;
                   BusyArticles[3] = true;
               }
               else if(!BusyArticles[4])
               {
                   Article5.ArticleTitle = str.Title;
                   Article5.ArticleText = str.Text;
                   Article5.ArticleDate = str.Date;
                   BusyArticles[4] = true;
               }
           });
        }

        private void bunifuTextbox1_Enter(object sender, EventArgs e)
        {
            if (search.CustomText == "What are you looking for?")
            {
                search.CustomText = null;
                //search.ForeColor = Color.Black;
            }
        }

        private void search_Leave(object sender, EventArgs e)
        {
            if (search.CustomText == String.Empty)
            {
                search.CustomText = "What are you looking for?";
                //text.ForeColor = Color.Gray;
            }
        }
    }
}
