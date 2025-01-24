using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refuling_cars_2025_01_20
{
    public class Product
    {
        public string Name { get; set; } // Название товара или марки бензина
        public double Price { get; set; } // Стоимость товара или марки бензина
        public double Volume { get; set; } // Количество товара или бензина
        public Product() { }
        public Product(string name, double price, double volume)
        {
            Name = name;
            Price = price;
            Volume = volume;
        }
        public override string ToString()
        {
            return $"Продукция: {Name}, Цена: {Price.ToString("F2")} руб., Количество: {Volume.ToString("F2")}, Сумма: {(Price * Volume).ToString("F2")} руб.";
        }
    }
}
