using System;

namespace InterviewPreperationGuide.Core.DesignPattern {
    public class FacadePattern {
        private Customer customer;
        private Order order;

        public FacadePattern (Customer c, Order o) {
            customer = c;
            order = o;
        }

        public string PurchaseOrder () {
            string result = string.Empty;

            if (customer != null && order != null) {
                result = "Customer " + customer.name + " has made an order of " + order.quantity + " units of " + order.product.name + " product.";
            }

            return result;
        }
    }

    public class Customer {
        public int customerId { get; set; }

        public string name { get; set; }
    }

    public class Order {
        public int orderId { get; set; }

        public Product product { get; set; }

        public int quantity { get; set; }
    }

    public class Product {
        public int productId { get; set; }

        public string name { get; set; }
    }
}