using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_Song
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số lượng bài hát: ");
            int numSongs = int.Parse(Console.ReadLine());
            // Danh sách lưu trữ bài hát
            List<Song> list = new List<Song>();
            // Nhập thông tin từng bài hát
            for (int i = 0; i < numSongs; i++)
            {
                Console.WriteLine($"Nhập thông tin bài hát {i + 1} (định dạng: loại_tên_thời gian):");
                string[] data = Console.ReadLine().Split('_');
                // Tạo đối tượng bài hát và thêm vào danh sách
                Song song = new Song()
                {               
                    TypeList = data[0],
                    Name = data[1],
                    Time = data[2]
                };
                list.Add(song);// Thêm bài hát vào danh sách
            }
            Console.Write("Nhập loại bài hát muốn xem (hoặc 'all' để xem tất cả): ");
            string typeListView = Console.ReadLine();
            Console.WriteLine("Các bài hát tương ứng: ");
            if (typeListView == "all")
            {
                foreach (Song s in list)
                {
                    Console.WriteLine(s.Name);
                }
            }
            else
            {
                foreach (Song s in list)
                {
                    if (s.TypeList == typeListView)
                    {
                        Console.WriteLine(s.Name);
                    }
                }
            }

                //// Hiển thị danh sách bài hát
                //Console.WriteLine("\nDanh sách các bài hát đã nhập:");
                //foreach (Song s in list)
                //{
                //    Console.WriteLine($"Loại: {s.TypeList}, Tên: {s.Name}, Thời gian: {s.Time}");
                //}

        }
    }
}
