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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void postBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.postBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.real_estate_agencyDataSet);

        }

        private void Form12_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "real_estate_agencyDataSet.Post". При необходимости она может быть перемещена или удалена.
            this.postTableAdapter.Fill(this.real_estate_agencyDataSet.Post);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.postBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.postBindingSource.MovePrevious();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.postBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.postBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.postBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.postBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.postBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.real_estate_agencyDataSet);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
