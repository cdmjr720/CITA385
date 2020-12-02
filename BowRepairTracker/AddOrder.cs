using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BowRepairTracker
{
    public partial class AddOrder : Form
    {
        public AddOrder()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            FormController formController = new FormController();
            formController.ShowHome(this);
        }

        private void statusButton_Click(object sender, EventArgs e)
        {
            FormController formController = new FormController();
            formController.ShowOrderStatus(this);
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            FormController formController = new FormController();
            formController.ShowReports(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormController formController = new FormController();
            formController.ShowHome(this);
        }
    }
}
