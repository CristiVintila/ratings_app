using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiectPAW
{
    public static class DataGridViewExtensions
    {
        public static DataGridView AddColumn(this DataGridView data, int index, string name, string headerText)
        {
            data.ColumnCount++;
            data.Columns[index].HeaderText = headerText;
            data.Columns[index].DataPropertyName = name;
            return data;
        }
        public static DataGridView AddButtonColumn(this DataGridView data, string name, string text)
        {
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            button.Name = name;
            button.HeaderText = String.Empty;
            button.Text = text;
            button.UseColumnTextForButtonValue = true;
            data.Columns.Add(button);
            return data;
        }
    }
}
