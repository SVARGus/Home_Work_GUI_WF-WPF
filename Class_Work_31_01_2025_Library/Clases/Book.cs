using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_and_Class_Work_31_01_2025_Library.Clases
{
    public class Book
    {
        int Id { get; set; } // уникальный номер книги
        public string Title { get; set; } // Название книги
        public string Author { get; set; } // Автор книги
        public string Genre { get; set; } // Жанр книги 
        public string Publisher { get; set; } // Издатель
        public bool IsAvailable { get; set; } // Доступность книги
        public int TotalCopies { get; set; } // общее количество экземпляров
        public int AvailableCopies { get; set; } // Сколько сейчас доступно книг
        public string Description { get; set; } // Описание книги, можно запихнуть в подсказки - для отображения
        public Book() { }
        public Book(int id, string title, string author, string genre, 
            string publisher, int totalCopies, int availableCopies, string description)
        {
            Id = id;
            Title = title;
            Author = author;
            Genre = genre;
            Publisher = publisher;
            TotalCopies = totalCopies;
            AvailableCopies = availableCopies;
            Description = description;
            if(AvailableCopies == 0)
                IsAvailable = false;
            else 
                IsAvailable = true;
        }
        public override string ToString()
        {
            return $"{Title} {Author} {Genre}, Доступно - {AvailableCopies}";
        }
    }
}
