using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Demo_List_2
{
    internal class DanhSachNhanVien
    {
       

        List<NhanVien> DSNhanVien {  get; set; }
         public DanhSachNhanVien()
        {
            DSNhanVien = new List<NhanVien>();
        }
        public void ThemNhanVien(NhanVien nhanVien)
        {
            DSNhanVien.Add(nhanVien);
        }
        public void HienThi()
        {
            foreach (var nv in DSNhanVien)
            {
                Console.WriteLine(nv);
            }
        }
        public NhanVien TimTheoMa(int maNV)
        {
            NhanVien kq = null;
            foreach (var nv in DSNhanVien)
            {
                if (nv.MaNV == maNV)
                {
                    kq= nv;
                    return kq;
                }
            }
            return kq;
        }
        public void SapXepGiamDanTheoMa()
        {
            DSNhanVien = DSNhanVien.OrderByDescending(nv=>nv.MaNV).ToList();
        }
        public void XoaNhanVien(int maNV)
        {
            //for (int i = DSNhanVien.Count - 1; i >= 0; i--)
            //{
            //    if (DSNhanVien[i].MaNV == maNV)
            //    {
            //        DSNhanVien.RemoveAt(i);
            //    }
            //}
            DSNhanVien.RemoveAll(nv=>nv.MaNV==maNV);
        }
         
    }
}
