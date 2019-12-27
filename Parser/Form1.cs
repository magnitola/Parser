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
        public Form1()
        {
            InitializeComponent();
            searchBar.GoSearch += Search_GoSearch;
        }

        private void Search_GoSearch(string value)
        {
            SearchPanel.GoLoadOne(new string[]{ value}, SettingsPanel.settings);
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            switch ((sender as Control).Tag)
            {
                case "search":
                    {
                        SearchPanel.Visible = true;
                        SettingsPanel.Visible = false;
                        menuButtonSearch.IsActive = true;
                        menuButtonSettings.IsActive = false;
                        historyPanel.Visible = false;
                        menuButtonHistory.IsActive = false;
                        break;
                    }
                case "settings":
                    {
                        SearchPanel.Visible = false;
                        SettingsPanel.Visible = true;
                        menuButtonSearch.IsActive = false;
                        menuButtonSettings.IsActive = true;
                        historyPanel.Visible = false;
                        menuButtonHistory.IsActive = false;
                        break;
                    }
                case "history":
                    {
                        SearchPanel.Visible = false;
                        SettingsPanel.Visible = false;
                        menuButtonSearch.IsActive = false;
                        menuButtonSettings.IsActive = false;
                        historyPanel.Visible = true;
                        menuButtonHistory.IsActive = true;
                        break;
                    }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchPanel.GoLoadArray(SettingsPanel.settings);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            this.Capture = false;
            Message n = Message.Create(this.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref n);
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (SearchPanel.Searching)
            {
                DialogResult result = MessageBox.Show("Вы уверены, что вы хотите выйти?\n\nНажимая на 'Да', вы подтверждаете, что вы готовы прервать копирование",
                   "Предупреждение",
                   MessageBoxButtons.OKCancel,
                   MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    Dispose();
                }
            }
            else
                Dispose();
        }

        private Int32 tmpX;
        private Int32 tmpY;
        private bool flMove = false;

        private void frmMain_MouseDown(object sender, MouseEventArgs e)
        {
            tmpX = Cursor.Position.X;
            tmpY = Cursor.Position.Y;
            flMove = true;
        }

        private void frmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (flMove)
            {
                this.Left = this.Left + (Cursor.Position.X - tmpX);
                this.Top = this.Top + (Cursor.Position.Y - tmpY);

                tmpX = Cursor.Position.X;
                tmpY = Cursor.Position.Y;
            }
        }

        private void frmMain_MouseUp(object sender, MouseEventArgs e)
        {
            flMove = false;
        }
    }
}
