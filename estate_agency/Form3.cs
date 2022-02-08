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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void workersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.workersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.real_estate_agencyDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "real_estate_agencyDataSet.Contracts". При необходимости она может быть перемещена или удалена.
            this.contractsTableAdapter.Fill(this.real_estate_agencyDataSet.Contracts);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "real_estate_agencyDataSet.Workers". При необходимости она может быть перемещена или удалена.
            this.workersTableAdapter.Fill(this.real_estate_agencyDataSet.Workers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.workersBindingSource.MoveNext();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.workersBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.workersBindingSource.MoveFirst();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.workersBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.workersBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.workersBindingSource.RemoveCurrent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.workersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.real_estate_agencyDataSet);
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

      

        private void p_idNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(p_idNumericUpDown, "1-директор, 2-зам директор, 3-риэлтор,4-бухалтер,5-юрист,6-администратор");

        }

        private void sexTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void sexLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4();
            newForm.Show();
        }
    }
}
