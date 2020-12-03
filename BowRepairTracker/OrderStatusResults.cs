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
    public partial class OrderStatusResults : Form
    {
        private FormController formController;

        public OrderStatusResults()
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

        private void reportButton_Click(object sender, EventArgs e)
        {
            formController.ShowReports(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormController formController = new FormController();
            formController.ShowHome(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("Your Order Status Has Been Updated and Your Customer Has Been Notified", "Order Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Your Order Status Has Been Updated", "Order Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
    }
}
