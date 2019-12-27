﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Parser
{
    public partial class HistoryElement : UserControl
    {
        public HistoryElement()
        {
            InitializeComponent();
        }
        private string path;
        public string FolderPath
        {
            get { return path; }
            set
            {
                request.Text = value.Substring(value.LastIndexOf('\\')+1).Replace("_", " ");
                Count.Text = Directory.GetFiles(value).Length.ToString();
                path = value;
            }
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(76, 75, 105);
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(44, 43, 60);
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            if (path != null)
            {
                
                string temp = Directory.GetCurrentDirectory().Replace("\\\\", "//").Replace("\\", "/") + "/" + path.Replace("\\\\", "/").Replace("\\", "/") + "/";
                //MessageBox.Show(temp);
                System.Diagnostics.Process.Start(new ProcessStartInfo(temp));
            }
        }
    }
}