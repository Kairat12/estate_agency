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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void serviceesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.serviceesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.real_estate_agencyDataSet);

        }

        private void Form11_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "real_estate_agencyDataSet.Servicees". При необходимости она может быть перемещена или удалена.
            this.serviceesTableAdapter.Fill(this.real_estate_agencyDataSet.Servicees);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.serviceesBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.serviceesBindingSource.MovePrevious();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.serviceesBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.serviceesBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.serviceesBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.serviceesBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            serviceesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.real_estate_agencyDataSet);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
