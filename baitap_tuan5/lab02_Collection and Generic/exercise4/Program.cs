using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exercise4;

namespace exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AccountList accountList = new AccountList();
            //accountList.NewAccount(new Account(1, "Thanh", "Thảo", 400000));
            //accountList.NewAccount(new Account(2, "Đào", "Giang", 20000));
            //accountList.NewAccount(new Account(3, "Thanh", "hải", 50000));
            //accountList.NewAccount(new Account(4, "Minh", "Đăng, 10000"));
            Console.OutputEncoding = Encoding.UTF8;
            int chon;
            do
            {

                Console.WriteLine("\n1. Thêm nhân viên");
                Console.WriteLine("2. Hiển thị danh sách");
                Console.WriteLine("3. Lưu lại file");
                Console.WriteLine("4. Tải file ");
                Console.WriteLine("5. Xóa tài khoản");
                Console.WriteLine("6. Sắp xếp danh sách");
                Console.WriteLine("0. Thoát");
                Console.Write("Chọn: ");
                chon = int.Parse(Console.ReadLine());

                switch (chon)
                {
                    case 1: accountList.NewAccount(); break;
                    case 2: accountList.ShowAccount(); break;
                    case 3: accountList.SaveFile(); break;
                    case 4: accountList.LoadFile(); break;
                    case 5: accountList.RemoveAccount(); break;
                    case 6: accountList.SortAccounts(); break;
                    case 0: Console.WriteLine("Thoát."); break;
                    default: Console.WriteLine("Sai lựa chọn!"); break;
                }
            } while (chon != 0);
        }
    }
}
