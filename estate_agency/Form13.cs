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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "real_estate_agencyDataSet.Sell". При необходимости она может быть перемещена или удалена.
            this.sellTableAdapter.Fill(this.real_estate_agencyDataSet.Sell);

        }
    }
}
