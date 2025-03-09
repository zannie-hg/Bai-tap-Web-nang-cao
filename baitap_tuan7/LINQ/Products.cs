using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Products
    {
        static List<Product> products = new List<Product>
    {
        new Product(1, "Bàn trà", 400, new string[]{"Xám", "Xanh"}, 2),
        new Product(2, "Tranh treo", 400, new string[]{"Vàng", "Xanh"}, 1),
        new Product(3, "Đèn trùm", 500, new string[]{"Trắng"}, 3),
        new Product(4, "Bàn học", 200, new string[]{"Trắng", "Xanh"}, 1),
        new Product(5, "Túi da", 300, new string[]{"Đỏ", "Đen", "Vàng"}, 2),
        new Product(6, "Giường ngủ", 500, new string[]{"Trắng"}, 2),
        new Product(7, "Tủ áo", 600, new string[]{"Trắng"}, 3)
    };

        public static void ProductPrice400()
        {
            var ketqua = from product in products
                         where product.Price == 400
                         select product;

            foreach (var product in ketqua)
                Console.WriteLine(product.ToString());
        }


    }
}
