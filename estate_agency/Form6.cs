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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "real_estate_agencyDataSet.Sellers". При необходимости она может быть перемещена или удалена.
            this.sellersTableAdapter.Fill(this.real_estate_agencyDataSet.Sellers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DataGridViewColumn col = null;
            switch (listBox1.SelectedIndex)
            {
                case 0:
                    col = surnameDataGridViewTextBoxColumn; break;
                case 1:
                    col = firstnameDataGridViewTextBoxColumn; break;
                case 2:
                    col = ageDataGridViewTextBoxColumn; break;
                case 3:
                    col = liveAdressDataGridViewTextBoxColumn; break;
            }
            if (radioButton1.Checked)
            {
                sellerDataGridView.Sort(col, ListSortDirection.Ascending);
            }
            else
            {
                sellerDataGridView.Sort(col, ListSortDirection.Descending);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void workersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sellersBindingSource.Filter = "SurName='" + comboBox1.Text + "'";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sellersBindingSource.Filter = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < sellerDataGridView.ColumnCount; i++)
            {
                for (int j = 0; j < sellerDataGridView.RowCount; j++)
                {
                    sellerDataGridView[i, j].Style.BackColor = Color.White;
                    sellerDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }


            for (int i = 0; i < sellerDataGridView.ColumnCount; i++)
            {
                for (int j = 0; j < sellerDataGridView.RowCount; j++)
                {
                    string a = Convert.ToString(sellerDataGridView[i, j].Value);
                    if (a.IndexOf(textBox1.Text) != -1)
                    {
                        sellerDataGridView[i, j].Style.BackColor = Color.DarkRed;
                        sellerDataGridView[i, j].Style.ForeColor = Color.White;
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
