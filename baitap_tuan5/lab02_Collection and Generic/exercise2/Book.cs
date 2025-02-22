using System;
using System.Collections.Generic;

namespace exercise2
{
    internal class Book : IComparable<Book>
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string ISBN { get; set; }
        public int Year { get; set; }

        public List<string> Chapters { get; set; } = new List<string>();

        public void Input()
        {
            Console.Write("Title: ");
            Title = Console.ReadLine();
            Console.Write("Author: ");
            Author = Console.ReadLine();
            Console.Write("Publisher: ");
            Publisher = Console.ReadLine();
            Console.Write("ISBN: ");
            ISBN = Console.ReadLine();
            Console.Write("Year: ");
            Year = int.Parse(Console.ReadLine());

            Console.WriteLine("Input chapters (finished with empty string):");
            while (true)
            {
                string chapter = Console.ReadLine();
                if (string.IsNullOrEmpty(chapter)) break;
                Chapters.Add(chapter);
            }
        }

        public void Show()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"Publisher: {Publisher}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine("Chapters:");
            for (int i = 0; i < Chapters.Count; i++)
            {
                Console.WriteLine($"  {i + 1}: {Chapters[i]}");
            }
        }

        // Thực hiện sắp xếp theo Title
        public int CompareTo(Book other)
        {
            return Title.CompareTo(other.Title);
        }
    }
}
