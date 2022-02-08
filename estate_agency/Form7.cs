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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.real_estate_agencyDataSet);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "real_estate_agencyDataSet.Customers". При необходимости она может быть перемещена или удалена.
            this.customersTableAdapter.Fill(this.real_estate_agencyDataSet.Customers);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.customersBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.customersBindingSource.MovePrevious();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.customersBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.customersBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.customersBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.customersBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.real_estate_agencyDataSet);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form8 newForm = new Form8();
            newForm.Show();
        }
    }
}
