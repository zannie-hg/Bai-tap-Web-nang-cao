namespace OPP_ruachen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Moi ban nhap so nguoi tham gia rua chen");
            int soNguoi = int.Parse(Console.ReadLine());
            string[] nguoiChoi = new string[soNguoi];
            for (int i = 0; i< soNguoi; i++)
            {
                Console.WriteLine($"Nguoi chon so {i} la: ");
                nguoiChoi[i] = Console.ReadLine();
            }
            XucXac xx1 = new XucXac();
            xx1.SoMat = soNguoi;
            int soNgauNhien = xx1.doXucXac(); //tao so ngau nhien tu 1...so mat
            Console.WriteLine(soNgauNhien - 1);
            Console.WriteLine("Nguoi rua chen co ten la: " + nguoiChoi[soNgauNhien-1]);
        }
    }
}
