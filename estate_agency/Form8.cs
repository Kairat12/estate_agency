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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "real_estate_agencyDataSet.Customers". При необходимости она может быть перемещена или удалена.
            this.customersTableAdapter.Fill(this.real_estate_agencyDataSet.Customers);

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
                    col = surNameDataGridViewTextBoxColumn; break;
                case 1:
                    col = firstNameDataGridViewTextBoxColumn; break;
                case 2:
                    col = ageDataGridViewTextBoxColumn; break;
            }
            if (radioButton1.Checked)
            {
                customerDataGridView.Sort(col, ListSortDirection.Ascending);
            }
            else
            {
                customerDataGridView.Sort(col, ListSortDirection.Descending);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            customersBindingSource.Filter = "SurName='" + comboBox1.Text + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            customersBindingSource.Filter = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < customerDataGridView.ColumnCount; i++)
            {
                for (int j = 0; j < customerDataGridView.RowCount; j++)
                {
                    customerDataGridView[i, j].Style.BackColor = Color.White;
                    customerDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }


            for (int i = 0; i < customerDataGridView.ColumnCount; i++)
            {
                for (int j = 0; j < customerDataGridView.RowCount; j++)
                {
                    string a = Convert.ToString(customerDataGridView[i, j].Value);
                    if (a.IndexOf(textBox1.Text) != -1)
                    {
                        customerDataGridView[i, j].Style.BackColor = Color.DarkRed;
                        customerDataGridView[i, j].Style.ForeColor = Color.White;
                    }
                }
            }
        }
    }
}

