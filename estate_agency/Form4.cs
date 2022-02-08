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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void workersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.workersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.real_estate_agencyDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "real_estate_agencyDataSet.Workers". При необходимости она может быть перемещена или удалена.
            this.workersTableAdapter.Fill(this.real_estate_agencyDataSet.Workers);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DataGridViewColumn col = null;
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    col = dataGridViewTextBoxColumn2; break;
                case 1:
                    col = dataGridViewTextBoxColumn3; break;
                case 2:
                    col = dataGridViewTextBoxColumn6; break;
                case 3:
                    col = dataGridViewTextBoxColumn8; break;
            }
            if (radioButton1.Checked)
            {
                workersDataGridView.Sort(col, ListSortDirection.Ascending);
            }
            else
            {
                workersDataGridView.Sort(col, ListSortDirection.Descending);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            workersBindingSource.Filter = "SurName='" + comboBox1.Text + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            workersBindingSource.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < workersDataGridView.ColumnCount; i++)
            {
                for (int j = 0; j < workersDataGridView.RowCount; j++)
                {
                    workersDataGridView[i, j].Style.BackColor = Color.White;
                    workersDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }


            for (int i = 0; i < workersDataGridView.ColumnCount; i++)
            {
                for (int j = 0; j < workersDataGridView.RowCount; j++)
                {
                    string a= Convert.ToString(workersDataGridView[i, j].Value);
                    if (a.IndexOf(textBox1.Text) != -1)
                    {
                        workersDataGridView[i, j].Style.BackColor = Color.DarkRed;
                        workersDataGridView[i, j].Style.ForeColor = Color.White;
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void workersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
