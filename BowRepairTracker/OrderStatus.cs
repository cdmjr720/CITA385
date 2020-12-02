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
    public partial class OrderStatus : Form 
    {
        public OrderStatus()
        {
            InitializeComponent();
            FormController.orderStatus = this;
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            FormController formController = new FormController();
            formController.ShowHome(this);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            FormController formController = new FormController();
            formController.ShowAddOrder(this);
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            FormController formController = new FormController();
            formController.ShowReports(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormController formController = new FormController();
            formController.ShowOrderStatusResults(this);
        }
    }
}
