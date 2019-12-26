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
        public delegate void Return(object sender, EventArgs e);
        public event Return ClickOn;
        public string ArticleTitle
        {
            get { return Title.Text; }
            set
            {
                Title.Text = value;
            }
        }

        public string ArticleText
        {
            get { return txt.Text; }
            set
            {
                txt.Text = value;
            }
        }

        public string ArticleDate
        {
            get { return date.Text; }
            set
            {
                date.Text = value;
            }
        }

        private IArticle article;
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

        private void date_Click(object sender, EventArgs e)
        {
            if (Title.Text != string.Empty)
            {
                System.Diagnostics.Process.Start(article.Link);
                //ClickOn?.Invoke(sender, e);
            }
        }
    }
}
