using System.Collections.Generic;

namespace OnlineOrdering
{
    public class Order
    {
        private List<Product> _products;
        private Customer _customer;

        public Order(Customer customer)
        {
            _customer = customer;
            _products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            if (product != null)
                _products.Add(product);
        }

        public double GetTotalPrice()
        {
            double total = 0;
            foreach (var product in _products)
            {
                total += product.GetTotalCost();
            }
            total += _customer.LivesInUSA() ? 5 : 35;
            return total;
        }

        public string GetPackingLabel()
        {
            var label = "Packing Label:\n";
            foreach (var product in _products)
            {
                label += $"{product.Name} (ID: {product.ProductId})\n";
            }
            return label;
        }

        public string GetShippingLabel()
        {
            var label = "Shipping Label:\n";
            label += $"{_customer.Name}\n";
            label += _customer.Address.GetFullAddress();
            return label;
        }
    }
}