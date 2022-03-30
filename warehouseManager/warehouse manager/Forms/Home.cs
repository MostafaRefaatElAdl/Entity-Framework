using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using warehouse_manager.Forms;
using warehouse_manager.Forms.ExchangeOrder;
using warehouse_manager.Forms.PaymentOrder;
using warehouse_manager.Forms.Reports;

namespace warehouse_manager
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnSupplyingOrders_Click(object sender, EventArgs e)
        {
            var form = new SupplyingOrdersList();
            form.Show();
        }

        private void btnNewSupplyingOrder_Click(object sender, EventArgs e)
        {
            var form = new AddEditSupplyingOrder();
            form.Show();
        }

        private void btnPaymentOrders_Click(object sender, EventArgs e)
        {
            var form = new PaymentOrdersList();
            form.Show();
        }

        private void btnNewPaymentOrder_Click(object sender, EventArgs e)
        {
            var form = new AddEditPaymentOrder();
            form.Show();
        }

        private void btnExchangeOrders_Click(object sender, EventArgs e)
        {
            var form = new ExchangeOrdersList();
            form.Show();
        }

        private void btnNewExchangeOrder_Click(object sender, EventArgs e)
        {
            var form = new AddEditExchangeOrder();
            form.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            var form = new ItemsExpirationReport();
            form.Show();
        }

        private void btnViewWarehouses_Click(object sender, EventArgs e)
        {
            var form = new Warehouses();
            form.Show();
        }

        private void btnViewProducts_Click(object sender, EventArgs e)
        {
            var form = new Products();
            form.Show();
        }

        private void btnViewUnits_Click(object sender, EventArgs e)
        {
            var form = new Units();
            form.Show();
        }

        private void btnViewProviders_Click(object sender, EventArgs e)
        {
            var form = new PersonList(PersonType.Provider);
            form.Show();
        }

        private void btnViewCustomers_Click(object sender, EventArgs e)
        {
            var form = new PersonList(PersonType.Customer);
            form.Show();
        }

    }
}
