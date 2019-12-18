using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parser
{
    public partial class ViewArticle : UserControl
    {
        public ViewArticle()
        {
            InitializeComponent();
        }
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
    }
}
