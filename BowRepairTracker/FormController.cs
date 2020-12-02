using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BowRepairTracker
{
    class FormController
    {
        public static Home home = null;
        public static OrderStatus orderStatus = null;
        public static AddOrder addOrder = null;
        public static Reports reports = null;
        public static Form1 customerReports = null;
        public static Form2 salesReports = null;
        public static Form3 repairReports = null;
        public static OrderStatusResults OrderStatusResults = null;

        public void SetHome(Home homeValue)
        {
            home = homeValue;
        }

        public void SetOrderStatus(OrderStatus orderStatusValue)
        {
            orderStatus = orderStatusValue;
        }

        public void ShowAddOrder(Form currentScreen)
        {
            if (addOrder == null)
            {
                addOrder = new AddOrder();
            }

            addOrder.Show();
            currentScreen.Hide();
        }

        public void ShowHome(Form currentScreen)
        {
            if (home == null)
            {
                home = new Home();
            }

            home.Show();
            currentScreen.Hide();
        }

        public void ShowOrderStatus(Form currentScreen)
        {
            if (orderStatus == null)
            {
                orderStatus = new OrderStatus();
            }

            orderStatus.Show();
            currentScreen.Hide();
        }

        public void ShowReports(Form currentScreen)
        {
            if (reports == null)
            {
                reports = new Reports();
            }

            reports.Show();
            currentScreen.Hide();
        }

        public void ShowSalesReports(Form currentScreen)
        {
            if (salesReports == null)
            {
                salesReports = new Form2();
            }

            salesReports.Show();
            currentScreen.Hide();
        }

        public void ShowRepairReports(Form currentScreen)
        {
            if (repairReports == null)
            {
                repairReports = new Form3();
            }

            repairReports.Show();
            currentScreen.Hide();
        }

        public void ShowCustomerReports(Form currentScreen)
        {
            if (customerReports == null)
            {
                customerReports = new Form1();
            }

            customerReports.Show();
            currentScreen.Hide();
        }

        public void ShowOrderStatusResults(Form currentForm)
        {
            if (OrderStatusResults == null)
            {
                OrderStatusResults = new OrderStatusResults();
            }

            OrderStatusResults.Show();
            currentForm.Hide();
        }
    }
}
