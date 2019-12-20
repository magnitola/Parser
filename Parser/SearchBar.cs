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
    public partial class SearchBar : UserControl
    {
        public SearchBar()
        {
            InitializeComponent();
        }

        public Color Color
        {
            get { return bunifuCustomTextbox1.BackColor; }
            set
            {
                bunifuCustomTextbox1.BackColor = value;
                this.BackColor = value;
            }
        }

        public string CustomText
        {
            get { return bunifuCustomTextbox1.Text; }
            set
            {
                bunifuCustomTextbox1.Text = value;
            }
        }

        public delegate void bools(string value);
        public event bools GoSearch;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GoSearch?.Invoke(bunifuCustomTextbox1.Text);
        }

        private void bunifuCustomTextbox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                GoSearch?.Invoke(bunifuCustomTextbox1.Text);
        }
    }
}
