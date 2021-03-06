using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using warehouse_manager.Models;

namespace warehouse_manager.Forms.PaymentOrder
{
    public partial class PaymentOrdersList : Form
    {
        private readonly Model _model;

        public PaymentOrdersList()
        {
            InitializeComponent();

            _model = new Model();

            _model.PaymentOrders.Load();
            dgvOrders.DataSource = _model.PaymentOrders.Local.ToBindingList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new AddEditPaymentOrder();
            form.ShowDialog();

            _model.SupplyingOrders.Load();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (dgvOrders.SelectedRows.Count > 0)
            {
                int orderId = ((Models.PaymentOrder)dgvOrders.SelectedRows[0].DataBoundItem).Id;
                var form = new AddEditPaymentOrder(orderId);
                form.Show();
            }
        }

        private void dgvOrders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int orderId = ((Models.PaymentOrder)dgvOrders.SelectedRows[0].DataBoundItem).Id;
            var form = new AddEditSupplyingOrder(orderId);
            form.Show();
        }
    }
}
