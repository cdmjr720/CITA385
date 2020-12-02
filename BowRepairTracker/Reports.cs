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
    public partial class Reports : Form
    {
        private FormController formController;

        public Reports()
        {
            InitializeComponent();
            formController = new FormController();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            formController.ShowHome(this);
        }

        private void statusButton_Click(object sender, EventArgs e)
        {
            formController.ShowOrderStatus(this);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            formController.ShowAddOrder(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formController.ShowSalesReports(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formController.ShowRepairReports(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formController.ShowCustomerReports(this);
        }

        private void reportButton_Click(object sender, EventArgs e)
        {

        }

        private void homeButton_Click_1(object sender, EventArgs e)
        {

        }
    }
}
