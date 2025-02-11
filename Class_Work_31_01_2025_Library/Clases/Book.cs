using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_and_Class_Work_31_01_2025_Library.Clases
{
    public class Book
    {
        public int Id { get; set; } // уникальный номер книги
        public string Title { get; set; } // Название книги
        public string Author { get; set; } // Автор книги
        public string Genre { get; set; } // Жанр книги 
        public string Publisher { get; set; } // Издатель
        public Font Font { get; set; }
        public int Size { get; set; }
        public Color Color { get; set; }
        public Color BackGroundColor { get; set; }

        public Book() { }
        public Book(int id, string title, string author, string genre, 
            string publisher, Font font, int size, Color color, Color backGroundColor)
        {
            Id = id;
            Title = title;
            Author = author;
            Genre = genre;
            Publisher = publisher;
            Font = font;
            Size = size;
            Color = color;
            BackGroundColor = backGroundColor;
        }
        public override string ToString()
        {
            return $"{Id}) Название: \"{Title}\", Автор \"{Author}\"";
        }
    }
}
