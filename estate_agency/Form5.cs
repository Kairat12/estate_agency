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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void sellersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sellersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.real_estate_agencyDataSet);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.sellersBindingSource.MoveFirst();
        }

        private void sellersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.sellersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.real_estate_agencyDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "real_estate_agencyDataSet.Sellers". При необходимости она может быть перемещена или удалена.
            this.sellersTableAdapter.Fill(this.real_estate_agencyDataSet.Sellers);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.sellersBindingSource.MovePrevious();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.sellersBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.sellersBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.sellersBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.sellersBindingSource.RemoveCurrent();
        }
        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sellersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.real_estate_agencyDataSet);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void id_iTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void id_iNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(id_iNumericUpDown, "10 дейін");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form6 newForm = new Form6();
            newForm.Show();
        }
    }
}
