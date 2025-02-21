using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //List<int> ints = new List<int>();
            //ints.Add(1);
            //ints.Add(2);
            //ints.Add(3);
            //ints.Add(4);
            //ints.Remove(1);
            //foreach (int i in ints)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine(ints.Count);

            DanhSachNhanVien ds = new DanhSachNhanVien();
            int chon;
            do
            {
           
                Console.WriteLine("\n1. Thêm nhân viên");
                Console.WriteLine("2. Hiển thị danh sách");
                Console.WriteLine("3. Tìm kiếm");
                Console.WriteLine("4. Xóa nhân viên");
                Console.WriteLine("5. Sắp xếp");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn: ");
                chon = int.Parse(Console.ReadLine());

                switch (chon)
                {
                    case 1: ds.ThemNhanVien(); break;
                    case 2: ds.HienThi(); break;
                    case 3: ds.TimKiem(); break;
                    case 4: ds.XoaNhanVien(); break;
                    case 5: ds.SapXep(); break;
                    case 0: Console.WriteLine("Thoát."); break;
                    default: Console.WriteLine("Sai lựa chọn!"); break;
                }
            } while (chon != 0);

        }
    }
}

//Tao lop NhanVien: manv, hoten
//tao lop NhanVienBTG co them luong gio
//tao lop NhanVienTTG co them luong thang
//tao lop DSNV co danh sach nhan vien: them nhanvien, xoa nhan vien, tim kieem, sap xeps
