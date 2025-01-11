using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP_ruachen
{
    internal class XucXac
    {
        //thuộc tính
        public int SoMat { get; set; }
        //phương thức
        public int doXucXac()
        {
            Random rd = new Random();
            int soMay = rd.Next(1, SoMat+1);
            return soMay;
        }
    }
}
