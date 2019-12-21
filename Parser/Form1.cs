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
            searchBar.GoSearch += Search_GoSearch;
            menuButtonSearch.ClickOnButton += menuButtonSearch_Click;
            menuButtonSettings.ClickOnButton += menuButtonSettings_Click;
        }

        private void Search_GoSearch(string value)
        {
            Loader.GoLoad(value);
        }

        private void Loader_OnCompleted(bool f1)
        {
            if (f1)
            {
                if (NumberPage.Text == String.Empty)
                    NumberPage.Text = "1";
                CountArticle.Text = Loader.dataBase.CountArticles().ToString();
            }
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
               if (str.Link != String.Empty)
               {
                   if (Article1.ArticleTitle == string.Empty)
                       BusyArticles[0] = false;
                   if (Article2.ArticleTitle == string.Empty)
                       BusyArticles[1] = false;
                   if (Article3.ArticleTitle == string.Empty)
                       BusyArticles[2] = false;
                   if (Article4.ArticleTitle == string.Empty)
                       BusyArticles[3] = false;
                   if (Article5.ArticleTitle == string.Empty)
                       BusyArticles[4] = false;
               }
               if (!BusyArticles[0])
               {
                   SetArticle(1, str);
                   BusyArticles[0] = true;
               }
               else if (!BusyArticles[1])
               {
                   SetArticle(2, str);
                   BusyArticles[1] = true;
               }
               else if(!BusyArticles[2])
               {
                   SetArticle(3, str);
                   BusyArticles[2] = true;
               }
               else if(!BusyArticles[3])
               {
                   SetArticle(4, str);
                   BusyArticles[3] = true;
               }
               else if(!BusyArticles[4])
               {
                   SetArticle(5, str);
                   BusyArticles[4] = true;
               }
           });
        }

        private void SetArticle(int number, IArticle str)
        {
            switch(number)
            {
                case 1:
                    {
                        Article1.ArticleTitle = str.Title;
                        Article1.ArticleText = str.Text;
                        Article1.ArticleDate = str.Date;
                        break;
                    }
                case 2:
                    {
                        Article2.ArticleTitle = str.Title;
                        Article2.ArticleText = str.Text;
                        Article2.ArticleDate = str.Date;
                        break;
                    }
                case 3:
                    {
                        Article3.ArticleTitle = str.Title;
                        Article3.ArticleText = str.Text;
                        Article3.ArticleDate = str.Date;
                        break;
                    }
                case 4:
                    {
                        Article4.ArticleTitle = str.Title;
                        Article4.ArticleText = str.Text;
                        Article4.ArticleDate = str.Date;
                        break;
                    }
                case 5:
                    {
                        Article5.ArticleTitle = str.Title;
                        Article5.ArticleText = str.Text;
                        Article5.ArticleDate = str.Date;
                        break;
                    }
            }
        }

        private void bunifuTextbox1_Enter(object sender, EventArgs e)
        {
            if (searchBar.CustomText == "What are you looking for?")
            {
                searchBar.CustomText = null;
                //search.ForeColor = Color.Black;
            }
        }

        private void search_Leave(object sender, EventArgs e)
        {
            if (searchBar.CustomText == String.Empty)
            {
                searchBar.CustomText = "What are you looking for?";
                //text.ForeColor = Color.Gray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NumberPage.Text != String.Empty && int.Parse(NumberPage.Text) < int.Parse(CountArticle.Text) / 5)
            {
                int number = int.Parse(NumberPage.Text);
                NumberPage.Text = (number + 1).ToString();
                SetArticle(1, Loader.dataBase.GetArticle(1 + 5 * number));
                SetArticle(2, Loader.dataBase.GetArticle(2 + 5 * number));
                SetArticle(3, Loader.dataBase.GetArticle(3 + 5 * number));
                SetArticle(4, Loader.dataBase.GetArticle(4 + 5 * number));
                SetArticle(5, Loader.dataBase.GetArticle(5 + 5 * number));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (NumberPage.Text != String.Empty)
            {
                int number = int.Parse(NumberPage.Text) - 1;
                if (number != 0)
                {
                    NumberPage.Text = (number).ToString();
                    SetArticle(1, Loader.dataBase.GetArticle(0 + 5 * (number - 1)));
                    SetArticle(2, Loader.dataBase.GetArticle(1 + 5 * (number - 1)));
                    SetArticle(3, Loader.dataBase.GetArticle(2 + 5 * (number - 1)));
                    SetArticle(4, Loader.dataBase.GetArticle(3 + 5 * (number - 1)));
                    SetArticle(5, Loader.dataBase.GetArticle(4 + 5 * (number - 1)));
                }
            }
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            ((Control)sender).Capture = false;
        }

        private void menuButtonSearch_Click(object sender, EventArgs e)
        {
            SearchPanel.Visible = true;
            SettingsPanel.Visible = false;
            menuButtonSearch.IsActive = true;
            menuButtonSettings.IsActive = false;
        }

        private void menuButtonSettings_Click(object sender, EventArgs e)
        {
            SearchPanel.Visible = false;
            SettingsPanel.Visible = true;
            menuButtonSearch.IsActive = false;
            menuButtonSettings.IsActive = true;
        }
    }
}
