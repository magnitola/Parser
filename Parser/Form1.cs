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
            SearchPanel.GoLoadOne(value, SettingsPanel.settings);
        }

        private void GoSearchArray()
        {
            SearchPanel.GoLoadArray(SettingsPanel.settings);
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
                        break;
                    }
                case "settings":
                    {
                        SearchPanel.Visible = false;
                        SettingsPanel.Visible = true;
                        menuButtonSearch.IsActive = false;
                        menuButtonSettings.IsActive = true;
                        break;
                    }
            }
        }
    }
}
