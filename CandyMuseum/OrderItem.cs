using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyMuseum
{
    public class OrderItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; } // Количество проданного товара на момент сделки
        public double PriceAtPurchase{ get; set; } // цена по которой продается товар на момент сделки
        public OrderItem(Product product, int quantity)
        {  Product = product; Quantity = quantity; PriceAtPurchase = product.Price; }
        public override string ToString()
        {
            return $"{Product.Name} * {Quantity} - {PriceAtPurchase * Quantity}";
        }
    }
}
