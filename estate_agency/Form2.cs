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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 newForm = new Form5();
            newForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 newForm = new Form7();
            newForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form9 newForm = new Form9();
            newForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form11 newForm = new Form11();
            newForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form12 newForm = new Form12();
            newForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form13 newForm = new Form13();
            newForm.Show();
        }
    }
}
