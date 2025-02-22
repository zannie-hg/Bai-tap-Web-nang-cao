﻿using System;
using System.Collections.Generic;

namespace exercise2
{
    internal class BookList
    {
        private List<Book> list = new List<Book>();

        public void AddBook()
        {
            Book b = new Book();
            b.Input();
            list.Add(b);
        }

        public void ShowList()
        {
            foreach (Book b in list)
                b.Show();
        }

        public void InputList()
        {
            Console.Write("Amount of books: ");
            int n = int.Parse(Console.ReadLine());
            while (n-- > 0)
            {
                AddBook();
            }
        }

        public void SortBooksByTitle()
        {
            list.Sort(); // Vì Book đã thực hiện IComparable nên có thể sắp xếp trực tiếp
        }
    }
}
