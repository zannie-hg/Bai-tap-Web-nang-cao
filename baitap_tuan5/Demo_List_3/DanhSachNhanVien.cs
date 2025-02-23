using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Demo_List_3;

namespace Demo_List_3
{
    internal class DanhSachNhanVien
    {


        List<NhanVien> DSNhanVien { get; set; }
        public DanhSachNhanVien()
        {
            DSNhanVien = new List<NhanVien>();
        }
        public void ThemNhanVien()
        {
            //DSNhanVien.Add(nhanVien);
            Console.WriteLine("Nhập mã nhân viên: ");
            int maNV = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập họ tên: ");
            string hoTen = Console.ReadLine();
            Console.Write("Chọn loại nhân viên (1 - Bán thời gian, 2 - Toàn thời gian): ");
            int loaiNV = int.Parse(Console.ReadLine());
            if (loaiNV == 1)
            {
                Console.WriteLine("Nhập lương theo giờ: ");
                double luongGio = double.Parse(Console.ReadLine());
                DSNhanVien.Add(new NhanVienBTG(maNV, hoTen, luongGio));
            }
            else if (loaiNV == 2)
            {
                    Console.WriteLine("Nhập lương theo tháng: ");
                    double luongThang = double.Parse(Console.ReadLine());
                    DSNhanVien.Add(new NhanVienTTG(maNV, hoTen, luongThang));
            } else
            {
                Console.WriteLine("Loại nhân viên không hợp lệ.");
            }
           
        }
        public void HienThi()
        {
            foreach (var nv in DSNhanVien)
            {
                Console.WriteLine(nv);
            }
        }
        public NhanVien TimTheoMa()
        {
            Console.WriteLine("Nhập mã NV cần tìm: ");
            int maNV = int.Parse(Console.ReadLine());
            NhanVien kq = null;
            foreach (var nv in DSNhanVien)
            {
                if (nv.MaNV == maNV)
                {
                    kq = nv;
                    return kq;
                }
            }
            return kq;
        }
        public void SapXepGiamDanTheoMa()
        {
            DSNhanVien = DSNhanVien.OrderByDescending(nv => nv.MaNV).ToList();
        }
        public void XoaNhanVien()
        {
            //for (int i = DSNhanVien.Count - 1; i >= 0; i--)
            //{
            //    if (DSNhanVien[i].MaNV == maNV)
            //    {
            //        DSNhanVien.RemoveAt(i);
            //    }
            //}
            Console.WriteLine("Nhập mã NV cần xóa: ");
            int maNV = int.Parse(Console.ReadLine());
            DSNhanVien.RemoveAll(nv => nv.MaNV == maNV);
        }

    }
}
