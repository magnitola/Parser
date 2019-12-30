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
        /// <summary>
        /// Выбран ли компонент
        /// </summary>
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
        /// <summary>
        /// Текст на кнопке
        /// </summary>
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
        /// <summary>
        /// Картинка на кнопке
        /// </summary>
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

        private string tag = "";
        /// <summary>
        /// Тэг кнопки
        /// </summary>
        public new string Tag
        {
            get
            {
                return tag;
            }
            set
            {
                label1.Tag = value;
                pictureBox1.Tag = value;
                panel1.Tag = value;
                panel2.Tag = value;
                tag = value;
            }
        }

        public delegate void Clickk(object sender, EventArgs e);
        /// <summary>
        /// Возникает при нажатии на элемент меню
        /// </summary>
        public event Clickk ClickOnButton;

        /// <summary>
        /// Обработчик наведения на компонент
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuButton_MouseHover(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(76, 75, 105);
        }
        /// <summary>
        /// Обработчик наведения на компонент
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuButton_MouseLeave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(50, 49, 69); 
        }
        /// <summary>
        /// Обработчик нажатия на компонент
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuButton_Click(object sender, EventArgs e)
        {
            ClickOnButton?.Invoke(sender, e);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
