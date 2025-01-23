using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refuling_cars_2025_01_20
{
    public static class Storage
    {
        private static List<Product> productOils = new List<Product>()
        {
            new Product("АИ-80", 5.4, 2000),
            new Product("АИ-92", 5.80, 2000),
            new Product("АИ-95", 6.20, 2000),
            new Product("АИ-98", 6.55, 2000),
            new Product("АИ-100", 7.00, 2000)
        };
        private static List<Product> productCafe = new List<Product>()
        {
            new Product("Хот-Дог", 4.00, 500),
            new Product("Гамбургер", 5.40, 500),
            new Product("Фри-картоха", 7.20, 500),
            new Product("Кока-кола", 4.40, 500)
        };
        public static List<Product> GetProductOils()
        {
            return productOils;
        }
        public static List<Product> GetProductCafe()
        {
            return productCafe;
        }
    }
}
