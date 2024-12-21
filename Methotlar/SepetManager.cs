using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methotlar
{
    internal class SepetManager
    {
        public void Ekle(Product product)
        {
            Console.WriteLine("Tebrikler Ürün Sepete Eklendi" + "Ürün ="+ product.Name);
        }
    }       
}
