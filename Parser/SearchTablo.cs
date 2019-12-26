using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parser.Core;

namespace Parser
{
    public partial class SearchTablo : UserControl
    {
        public SearchTablo()
        {
            InitializeComponent();
            Loader.NewData += Loader_NewData;
            Loader.OnCompleted += Loader_OnCompleted;
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
        private AllHtmlLoader Loader = new AllHtmlLoader();
        public void GoLoad(string value, Settings settings)
        {
            Task.Run(() => Loader.GoLoad(value, settings));
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (NumberPage.Text != String.Empty && int.Parse(NumberPage.Text) <= int.Parse(CountArticle.Text) / 5)
            {
                int number = int.Parse(NumberPage.Text);
                NumberPage.Text = (number + 1).ToString();
                SetArticle(1, Loader.dataBase.GetArticle(0 + 5 * number));
                SetArticle(2, Loader.dataBase.GetArticle(1 + 5 * number));
                SetArticle(3, Loader.dataBase.GetArticle(2 + 5 * number));
                SetArticle(4, Loader.dataBase.GetArticle(3 + 5 * number));
                SetArticle(5, Loader.dataBase.GetArticle(4 + 5 * number));
            }
        }
        bool[] BusyArticles = { false, false, false, false, false };
        private void Loader_NewData(IArticle str)
        {
            Article1.Invoke((MethodInvoker)delegate
            {
                if (NumberPage.Text == String.Empty)
                    NumberPage.Text = "1";
                CountArticle.Text = (int.Parse(CountArticle.Text) + 1).ToString();
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
                else if (!BusyArticles[2])
                {
                    SetArticle(3, str);
                    BusyArticles[2] = true;
                }
                else if (!BusyArticles[3])
                {
                    SetArticle(4, str);
                    BusyArticles[3] = true;
                }
                else if (!BusyArticles[4])
                {
                    SetArticle(5, str);
                    BusyArticles[4] = true;
                }
            });
        }
        private void SetArticle(int number, IArticle str)
        {
            switch (number)
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

    }
}
