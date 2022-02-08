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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void immovables_buyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.immovables_buyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.real_estate_agencyDataSet);

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "real_estate_agencyDataSet.Immovables_buy". При необходимости она может быть перемещена или удалена.
            this.immovables_buyTableAdapter.Fill(this.real_estate_agencyDataSet.Immovables_buy);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.immovables_buyBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.immovables_buyBindingSource.MovePrevious();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.immovables_buyBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.immovables_buyBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.immovables_buyBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.immovables_buyBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.immovables_buyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.real_estate_agencyDataSet);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form10 newForm = new Form10();
            newForm.Show();
        }
    }
}
