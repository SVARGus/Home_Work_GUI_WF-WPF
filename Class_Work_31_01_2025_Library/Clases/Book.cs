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
        public string Description { get; set; }
        public string TextFont { get; set; }
        public int TextSize { get; set; }
        public string TextColor { get; set; }
        public string TextBackGroundColor { get; set; }

        public Book() { }
        public Book(int id, string title, string author, string genre, 
            string publisher, string description, string font = "Segoe UI", int size = 8, string color = "ControlText", string backGroundColor = "Control")
        {
            Id = id;
            Title = title;
            Author = author;
            Genre = genre;
            Publisher = publisher;
            Description = description;
            TextFont = font;
            TextSize = size;
            TextColor = color;
            TextBackGroundColor = backGroundColor;
        }
        public override string ToString()
        {
            return $"{Id}) Название: \"{Title}\", Автор \"{Author}\"";
        }
    }
}
