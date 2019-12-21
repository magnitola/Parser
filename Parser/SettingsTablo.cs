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
    public partial class SettingsTablo : UserControl
    {
        public SettingsTablo()
        {
            InitializeComponent();
            toolTip1.SetToolTip(label5, "В включенном состоянии вам будут попадаться записи, которые частично совпадают с запросом.\n\n То есть, если у вас запрос \"деревянные дома\", то вам будут попадаться сайты, в которых есть слово \"деревянные\" или \"дома\"");
            toolTip1.SetToolTip(label1, "Раз в сколько секунд программа будет обращаться к сайту.\n\nЧем меньше значение, тем выше шанс, что сайт посчитает нас ботом и не отдаст нам данные");
            toolTip1.SetToolTip(label2, "Сколько уровней сайта проанализирует программа.\n\nЧем больше значение, тем больше времени займет поиск информации, но статей будет найдено больше.\n\nПоставьте значение \"all\", чтобы проанализировать все сайты полностью");
        }
    }
}
