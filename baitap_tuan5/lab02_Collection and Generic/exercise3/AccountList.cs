using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise3
{
    internal class AccountList
    {
        

        //List<Account> AccList {  get; set; }
        private List<Account> AccList;
        public AccountList()
        {
            AccList = new List<Account>();
        }
        public void NewAccount()
        {
            //AccList.Add(acc);
            //Console.WriteLine("Nhập số tài khoản cần thêm vào danh sách: ");
            //int n  = int.Parse(Console.ReadLine());
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine($"Nhập thông tin tài khoản {i+1}:");

            //}  
            Console.WriteLine("Nhập ID: ");
            int accountId = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập FirstName: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Nhập LastName: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Nhập Balance: ");
            double balance = double.Parse(Console.ReadLine());
            // Tạo một đối tượng Account mới và thêm vào danh sách
            Account acc = new Account(accountId, balance, firstName, lastName);
            AccList.Add(acc);
            
        }
        public void ShowAccount()
        {
            Console.WriteLine("\nDanh sách tài khoản:");
            foreach (var acc in AccList)
            {
                Console.WriteLine(acc);
            }
        }
        public void SaveFile()
        {
            // nhập tên file
            Console.Write("Input file name to save: ");
            string filename = Console.ReadLine();

            // ghi file
            try
            {
                // tạo luồng truy cập file
                FileStream output = new FileStream(filename, FileMode.CreateNew, FileAccess.Write);

                // thiết lập writer
                StreamWriter writer = new StreamWriter(output);

                // duyệt qua từng đối tượng trong Accounts
                foreach (Account acc in AccList)
                {
                    // lưu các thông tin của một account trên dòng, phân cách nhau bằng dấu ','
                    writer.WriteLine("{0},{1},{2},{3}", acc.AccountID, acc.FirstName, acc.LastName, acc.Balance);
                }

                // đóng kết nối
                writer.Close();
                output.Close();
            }
            catch (IOException e) // phát sinh ngoại lệ nếu có
            {
                Console.WriteLine(e.Message);
            }
        }
        public void LoadFile()
        {
            // đọc tên file chứa dữ liệu
            Console.Write("Input file name to load: ");
            string filename = Console.ReadLine();

            // xóa danh sách hiện có
            AccList.Clear();

            try
            {
                // tạo luồng đọc file
                FileStream input = new FileStream(filename, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(input);

                string str;
                // đọc qua từng dòng, kết thúc khi chuỗi null
                while ((str = reader.ReadLine()) != null)
                {
                    // tách chuỗi đọc ra thành các phần tử con, phân cách nhau dấu ','
                    string[] list = str.Split(',');

                    // tạo đối tượng Account mới
                    Account acc = new Account(int.Parse(list[0]), double.Parse(list[3]), list[1], list[2]);


                    // đưa đối tượng mới đọc vào danh sách account
                    AccList.Add(acc);
                }

                // đóng luồng
                input.Close();
                reader.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }



    }
}
