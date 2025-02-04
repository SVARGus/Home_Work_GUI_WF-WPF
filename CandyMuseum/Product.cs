using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyMuseum
{
    public class Product
    {
        public string Name { get; set; }
        public string Producer {  get; set; }
        public int Volume { get; set; }
        public double Price { get; set; }
        public Product() { }
        public Product (string name, string producer, int volume, double price)
        {
            this.Name = name;
            this.Producer = producer;
            this.Volume = volume;
            this.Price = price;
        }
        public override string ToString()
        {
            return $"{Name} Производитель: {Producer}, Цена: {Price} руб. - {Volume} шт.";
        }
    }
}
