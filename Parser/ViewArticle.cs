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
    public partial class ViewArticle : UserControl
    {
        public ViewArticle()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Заголовок статьи
        /// </summary>
        public string ArticleTitle
        {
            get { return Title.Text; }
            set
            {
                Title.Text = value;
            }
        }
        /// <summary>
        /// Текст статьи
        /// </summary>
        public string ArticleText
        {
            get { return txt.Text; }
            set
            {
                txt.Text = value;
            }
        }
        /// <summary>
        /// Дата статьи
        /// </summary>
        public string ArticleDate
        {
            get { return date.Text; }
            set
            {
                date.Text = value;
            }
        }

        private IArticle article;
        /// <summary>
        /// Статья, по которой отобразятся данные на форме
        /// </summary>
        internal IArticle Article { 
            get { return article; }
            set
            {
                Title.Text = value.Title;
                txt.Text = value.Text;
                date.Text = value.Date;
                article = value;
            }
        }
        /// <summary>
        /// Нажатие на статью
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void date_Click(object sender, EventArgs e)
        {
            if (Title.Text != string.Empty)
            {
                System.Diagnostics.Process.Start(article.Link);
            }
        }
    }
}
