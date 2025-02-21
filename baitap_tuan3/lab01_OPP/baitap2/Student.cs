using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baitap2
{
    internal class Student
    {
        private int SID;
        private string TenSV;
        private string Khoa;
        private float DiemTB;

        // Constructor mặc định
        public Student()
        {
            SID = 1;
            TenSV = "Nguyen Van Nam";
            Khoa = "CNTT";
            DiemTB = 7.0f;
        }

        // Constructor sao chép
        public Student(Student stu)
        {
            SID = stu.SID;
            TenSV = stu.TenSV;
            Khoa = stu.Khoa;
            DiemTB = stu.DiemTB;
        }

        // Constructor có tham số
        public Student(int id, string ten, string kh, float dtb)
        {
            SID = id;
            TenSV = ten;
            Khoa = kh;
            DiemTB = dtb;
        }

        // Getter và Setter thay thế Property
        public int GetSID() { return SID; }
        public void SetSID(int id) { SID = id; }

        public string GetTenSV() { return TenSV; }
        public void SetTenSV(string ten) { TenSV = ten; }

        public string GetKhoa() { return Khoa; }
        public void SetKhoa(string khoa) { Khoa = khoa; }

        public float GetDiemTB() { return DiemTB; }
        public void SetDiemTB(float diem) { DiemTB = diem; }

        public void Show()
        {
            Console.WriteLine("MSSV: {0}", SID);
            Console.WriteLine("Tên SV: {0}", TenSV);
            Console.WriteLine("Khoa: {0}", Khoa);
            Console.WriteLine("Điểm TB: {0}", DiemTB);
            Console.WriteLine("----------------------------");
        }
    }
}
