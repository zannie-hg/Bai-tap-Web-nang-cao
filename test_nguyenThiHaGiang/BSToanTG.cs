using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_nguyenThiHaGiang
{
    internal class BSToanTG : BacSi
    {   public double LuongKham {  get; set; }
        public double LuongXetNghiem { get; set; }
        public BSToanTG()
        {
        }

        public BSToanTG(int ma, string hoTen,double mucLuong, double luongKham, double luongXetNghiem) : base(ma, hoTen, mucLuong)
        {     
            LuongKham = luongKham;
            LuongXetNghiem = luongXetNghiem;
        }

       

        
        public override double TinhLuong()
        {
            return LuongKham+LuongXetNghiem+MucLuong;
        }
        public override string ToString()
        {
            return $"Bác sĩ toàn thời gian: " +base.ToString()+ $", Lương khám: {LuongKham}, Lương xét nghiệm: {LuongXetNghiem}";
        }

       
    }
}
