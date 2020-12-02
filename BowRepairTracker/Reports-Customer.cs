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
    public partial class Form1 : Form
    {
        private FormController formController;

        public Form1()
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
    }
}
