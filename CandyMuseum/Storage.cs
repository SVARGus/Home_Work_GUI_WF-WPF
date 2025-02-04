using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyMuseum
{
    public static class Storage
    {
        private static List<Product> _products = new List<Product>()
        {
            new Product("Супер контик", "Конти-Рус", 200, 35),
            new Product("Мишка на севере", "Крупская", 500, 15),
            new Product("Труфели", "Крупская", 300, 15)
        };
        public static List<Product> GetListProducts()
        { return _products; }
        public static void Delete(int index)
        { _products.RemoveAt(index); }
        public static void PushBackProduct(Product product)
        { _products.Add(product); }
    }
}
