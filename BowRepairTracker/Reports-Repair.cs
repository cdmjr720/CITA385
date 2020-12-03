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
    public partial class Form3 : Form
    {
        private FormController formController;

        public Form3()
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
            MessageBox.Show("Report Generated, Click OK to View or Cancel to return", "Report Generated", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

        }
    }
}
