using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1
{
    internal interface IBook
    {
        //mo ta indexer chuong sach
        string this[int index] { get; set; }
        //property title dai dien cho ten cua sach
        string Title { get; set; }
        //property author dai dien cho ten cua tac gia cuon sach
        string Author { get; set; }
        //property publisher dai dien cho ten cua NXB
        string Publisher { get; set; }
        //property ISBN dai dien cho so hieu
        string ISBN { get; set; }
        //property year dai dien cho nam xuat ban
        int Year { get; set; }
        //Mo ta phuong thuc hien thi thong tin cuon sach
        void Show();
    }
}
