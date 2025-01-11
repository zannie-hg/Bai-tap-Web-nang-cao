namespace Demo_OPP_POP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chương trình chọn người rửa chén");
            //Cho ng dùng chọn số
            Console.WriteLine("Nguyen Van A chọn số 1");
            Console.WriteLine("Nguyen Van B chọn số 2");
            Console.WriteLine("Nguyen Van C chọn số 3");
            Console.WriteLine("Nguyen Van D chọn số 4");
            //Phát sinh ra số ngẫu nhiên
            Random rd = new Random();
            int soMay=rd.Next(1, 5);
            Console.WriteLine("Bạn phải rửa chén có số là: " + soMay);

        }
    }
}
