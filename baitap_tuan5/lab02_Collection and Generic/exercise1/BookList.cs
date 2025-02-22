using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    internal class BookList
    {
        // định nghĩa danh sách Book
        private ArrayList list = new ArrayList();

        /// Tạo một đối tượng sách, nhập các thông tin và thêm vào list
        public void AddBook()
        {
            Book b = new Book();
            // nhập thông tin
            b.Input();
            // thêm vào danh sách
            list.Add(b);
        }

        /// Xuất danh sách
        public void ShowList()
        {
            foreach (Book b in list)
                b.Show();
        }

        public void InputList()
        {
            int n;
            Console.Write("Amount of books: ");
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                AddBook();
                n--;
            }
        }
    }
}
