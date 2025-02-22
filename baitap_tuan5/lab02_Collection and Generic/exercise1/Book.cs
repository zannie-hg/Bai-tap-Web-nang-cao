using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    internal class Book : IBook
    {
        private string isbn;
        private string title;
        private string author;
        private string publisher;
        private int year;
        //luu tru mang chua ten chuong
        private ArrayList chapter = new ArrayList();

        public string this[int index] 
        {
            get
            {
                if (index >= 0 && index < chapter.Count)
                {
                    return (string)chapter[index];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set
            {

                if (index >= 0 && index < chapter.Count)
                {
                    chapter[index] = value;
                }
                else if(index == chapter.Count)
                    chapter.Add(value);
                else
                {
                    throw new IndexOutOfRangeException();
                }
            } 
        }

        public string Title { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Author { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Publisher { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ISBN { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Year { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Show()
        {
            // xuất thông tin sách ra màn hình console
            Console.WriteLine("-------------------------");
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Publisher: " + publisher);
            Console.WriteLine("Year: " + year);
            Console.WriteLine("ISBN: " + isbn);
            Console.WriteLine("Chapter: ");
            for (int i = 0; i < chapter.Count; i++)
                Console.WriteLine("\t{0}: {1}", i + 1, chapter[i]);
            Console.WriteLine("-------------------------");
        }
        public void Input()
        {
            Console.Write("Title: ");
            title = Console.ReadLine();
            Console.Write("Author: ");
            author = Console.ReadLine();
            Console.Write("Publisher: ");
            publisher = Console.ReadLine();
            Console.Write("ISBN: ");
            isbn = Console.ReadLine();
            Console.Write("Year: ");
            year = int.Parse(Console.ReadLine());
            Console.WriteLine("Input chapter (finished with empty string)");

            string str;
            do // nhập lần lượt các chương sách
            {
                str = Console.ReadLine();
                if (str.Length > 0)
                    chapter.Add(str);
            } while (str.Length > 0); // kết thúc khi chuỗi rỗng
        }

    }
}
