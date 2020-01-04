using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Parser
{
    public partial class HistoryTablo : UserControl
    {
        public HistoryTablo()
        {
            InitializeComponent();
            bunifuDatepicker1_onValueChanged(new object(), new EventArgs());
        }

        /// <summary>
        /// Обработчик события, если поменялась дата
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {
            Message.Visible = false;
            for (int i = 0; i < Controls.Count; i++)
            {
                if (Controls[i].Name.Contains("history/"))
                {
                    Controls.Remove(Controls[i]);
                    i--;
                }
            }
            string date = Datepicker.Value.ToString("dd.MM.yyyy");
            if (Directory.Exists("history/" + date))
            {
                string[] requests = Directory.GetDirectories("history/" + date);
                if (requests.Length == 0)
                    Message.Visible = true;
                else
                {
                    List<HistoryElement> history = new List<HistoryElement>();
                    foreach (string x in requests)
                    {
                        HistoryElement element = new HistoryElement();
                        element.FolderPath = x;
                        history.Add(element);
                    }
                    for (int i = 0; i < history.Count; i++)
                    {
                        history[i].Location = new Point(2, 66 + i*40);
                        history[i].Visible = true;
                        history[i].Name = history[i].FolderPath;
                        this.Controls.Add(history[i]);

                    }
                }
            }
            else
                Message.Visible = true;
        }
    }
}
