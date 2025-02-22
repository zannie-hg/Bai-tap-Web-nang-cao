using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using exercise4;

namespace exercise4
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
            Console.Write("Nhập tên file để lưu: ");
            string filename = Console.ReadLine();

            try
            {
                using (FileStream fs = new FileStream(filename, FileMode.Create))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, AccList);
                }
                Console.WriteLine("Lưu file thành công!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Lỗi khi lưu file: " + e.Message);
            }
        }

        public void LoadFile()
        {
            Console.Write("Nhập tên file để tải: ");
            string filename = Console.ReadLine();

            if (!File.Exists(filename))
            {
                Console.WriteLine("File không tồn tại!");
                return;
            }

            try
            {
                using (FileStream fs = new FileStream(filename, FileMode.Open))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    AccList = (List<Account>)formatter.Deserialize(fs);
                }
                Console.WriteLine("Load file thành công!");
                ShowAccount();
            }
            catch (Exception e)
            {
                Console.WriteLine("❌ Lỗi khi tải file: " + e.Message);
            }
        }

        public void RemoveAccount()
        {
            Console.Write("Nhập ID tài khoản cần xóa: ");
            int id = int.Parse(Console.ReadLine());

            // Sắp xếp danh sách trước khi BinarySearch
            AccList.Sort(new AccountComparer());

            // Tạo một đối tượng giả để tìm kiếm
            Account temp = new Account(id, 0, "", "");

            int index = AccList.BinarySearch(temp, new AccountComparer());

            if (index >= 0)
            {
                AccList.RemoveAt(index);
                Console.WriteLine($"Tài khoản {id} đã bị xóa.");
            }
            else
            {
                Console.WriteLine("Không tìm thấy tài khoản!");
            }
        }
        public void SortAccounts()
        {
            AccList = AccList.OrderBy(a => a.AccountID)
                             .ThenBy(a => a.FirstName)
                             .ThenBy(a => a.Balance)
                             .ToList();
            Console.WriteLine("Danh sách đã được sắp xếp!");
            ShowAccount();
        }




    }
}
