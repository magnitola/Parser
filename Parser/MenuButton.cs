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
    public partial class MenuButton : UserControl
    {
        public MenuButton()
        {
            InitializeComponent();
        }
        
        public bool IsActive
        {
            get
            {
                if (panel1.Visible == true)
                    return true;
                else
                    return false;
            }
            set
            {
                if (value == true)
                    panel1.Visible = true;
                else
                    panel1.Visible = false;
            }
        }

        public string CustomText
        {
            get
            {
                return label1.Text;
            }
            set
            {
                label1.Text = value;
            }
        }

        public Image Picture
        {
            get
            {
                return pictureBox1.Image;
            }
            set
            {
                pictureBox1.Image = value;
            }
        }

        public string CustomTag
        {
            set
            {
                label1.Tag = value;
                pictureBox1.Tag = value;
                panel1.Tag = value;
                Tag = value;
            }
        }

        public delegate void Clickk(object sender, EventArgs e);
        public event Clickk ClickOnButton;

        private void MenuButton_MouseHover(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(76, 75, 105);
        }

        private void MenuButton_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(50, 49, 69); 
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            ClickOnButton?.Invoke(sender, e);
        }
    }
}
