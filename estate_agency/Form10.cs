using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estate_agency
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < immovibleDataGridView.ColumnCount; i++)
            {
                for (int j = 0; j < immovibleDataGridView.RowCount; j++)
                {
                    immovibleDataGridView[i, j].Style.BackColor = Color.White;
                    immovibleDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }


            for (int i = 0; i < immovibleDataGridView.ColumnCount; i++)
            {
                for (int j = 0; j < immovibleDataGridView.RowCount; j++)
                {
                    string a = Convert.ToString(immovibleDataGridView[i, j].Value);
                    if (a.IndexOf(textBox1.Text) != -1)
                    {
                        immovibleDataGridView[i, j].Style.BackColor = Color.DarkRed;
                        immovibleDataGridView[i, j].Style.ForeColor = Color.White;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DataGridViewColumn col = null;
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    col = roomCountDataGridViewTextBoxColumn; break;
                case 1:
                    col = roomSquareDataGridViewTextBoxColumn; break;
                case 2:
                    col = yearOfConstructionDataGridViewTextBoxColumn; break;
                case 3:
                    col = flatfloorDataGridViewTextBoxColumn; break;
            }
            if (radioButton1.Checked)
            {
                immovibleDataGridView.Sort(col, ListSortDirection.Ascending);
            }
            else
            {
                immovibleDataGridView.Sort(col, ListSortDirection.Descending);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            immovablesbuyBindingSource.Filter = "SurName='" + comboBox1.Text + "'";
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "real_estate_agencyDataSet.Immovables_buy". При необходимости она может быть перемещена или удалена.
            this.immovables_buyTableAdapter.Fill(this.real_estate_agencyDataSet.Immovables_buy);

        }
    }
}
