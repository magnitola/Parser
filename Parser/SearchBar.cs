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
        /// <summary>
        /// Цвет заднего фона
        /// </summary>
        public Color Color
        {
            get { return bunifuCustomTextbox1.BackColor; }
            set
            {
                bunifuCustomTextbox1.BackColor = value;
                this.BackColor = value;
            }
        }
        /// <summary>
        /// Текст на компоненте
        /// </summary>
        public string CustomText
        {
            get { return bunifuCustomTextbox1.Text; }
            set
            {
                bunifuCustomTextbox1.Text = value;
            }
        }

        public delegate void bools(string value);
        /// <summary>
        /// Возникает при нажатии на поиск или кнопки Enter
        /// </summary>
        public event bools GoSearch;

        /// <summary>
        /// Нажатие на поиск
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            GoSearch?.Invoke(bunifuCustomTextbox1.Text);
        }
        /// <summary>
        /// Нажатие на Ентер
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuCustomTextbox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                GoSearch?.Invoke(bunifuCustomTextbox1.Text);
        }
        /// <summary>
        /// При поиске убирается стандартный текст
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuCustomTextbox1_Enter(object sender, EventArgs e)
        {
            if (bunifuCustomTextbox1.Text == "What are you looking for?")
            {
                bunifuCustomTextbox1.Text = null;
            }
        }
        /// <summary>
        /// При выходе из поисковика, если он пустой, ставится стандартный текст
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuCustomTextbox1_Leave(object sender, EventArgs e)
        {
            if (bunifuCustomTextbox1.Text == String.Empty)
            {
                bunifuCustomTextbox1.Text = "What are you looking for?";
            }
        }
    }
}
