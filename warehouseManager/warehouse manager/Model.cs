using System;
using System.Data.Entity;
using System.Linq;
using warehouse_manager.Models;

namespace warehouse_manager
{
    public class Model : DbContext
    {
        public Model() : base("name=Model")
        {
        }

        public virtual DbSet<Warehouse> Warehouses { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Unit> Units { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Provider> Providers { get; set; }
        public virtual DbSet<SupplyingOrder> SupplyingOrders { get; set; }
        public virtual DbSet<PaymentOrder> PaymentOrders { get; set; }
        public virtual DbSet<ExchangeOrder> ExchangeOrders { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<InvoiceItem> InvoiceItems { get; set; }


    }

}