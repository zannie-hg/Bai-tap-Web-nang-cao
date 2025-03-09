using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_nguyenThiHaGiang
{
    internal class DanhSachBacSi
    {
        private List<BacSi> DSBacSi { get; set; } = new List<BacSi>();
        public void Nhap()
        {
            Console.WriteLine("Nhập mã: ");
            int ma = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập họ tên: ");
            string hoTen = Console.ReadLine();
            Console.WriteLine("Nhập mức lương: ");
            double mucLuong = double.Parse(Console.ReadLine());
            Console.Write("Chọn loại bác sĩ (1 - Toàn thời gian, 2 - Bán thời gian ): ");
            int loaiNV = int.Parse(Console.ReadLine());
            if (loaiNV == 1)
            {
                Console.WriteLine("Nhập lương khám: ");
                double luongKham = double.Parse(Console.ReadLine());
                Console.WriteLine("Nhập lương xét nghiệm: ");
                double luongXetNghiep = double.Parse(Console.ReadLine());
             
                DSBacSi.Add(new BSToanTG(ma,hoTen,mucLuong, luongKham, luongXetNghiep));
            }
            else if (loaiNV == 2)
            {
                Console.WriteLine("Nhập lương ngày: ");
                double luongNgay = double.Parse(Console.ReadLine());
                Console.WriteLine("Nhập số ngày làm việc: ");
                int soNgayLamViec = int.Parse(Console.ReadLine());
                DSBacSi.Add(new BSBanTG(ma, hoTen, mucLuong, luongNgay, soNgayLamViec));
            }
            else
            {
                Console.WriteLine("Lựa chọn không hợp lệ.");
            }
        }
        public void HienThi()
        {
            Console.WriteLine("\n--- DANH SÁCH BÁC SĨ ---");
            foreach (var bacSi in DSBacSi)
            {
                Console.WriteLine(bacSi.ToString());
                Console.WriteLine($"Lương: {bacSi.TinhLuong()}\n");
            }
        }
    }
}
