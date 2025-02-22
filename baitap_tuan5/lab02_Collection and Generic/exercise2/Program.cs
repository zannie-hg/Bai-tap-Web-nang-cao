using System;

namespace exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookList bookList = new BookList();

            // Nhập danh sách sách
            bookList.InputList();

            // Hiển thị danh sách trước khi sắp xếp
            Console.WriteLine("\nDanh sách sách trước khi sắp xếp:");
            bookList.ShowList();

            // Sắp xếp sách theo tiêu đề
            bookList.SortBooksByTitle();

            // Hiển thị danh sách sau khi sắp xếp
            Console.WriteLine("\nDanh sách sách sau khi sắp xếp theo tiêu đề:");
            bookList.ShowList();

            Console.ReadLine();
        }
    }
}
