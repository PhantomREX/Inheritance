using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211205_1_Inheritance
{
    // Inheritance (Kalıtım)
    // Inheritance yani miras alma işlemi c# programlama dili içerisinde kullanılan OOP yapısının temel taşlarından birisidir.
    // Bir proje içerisinde oluşturmuş olduğunuz classların içerisinde bulunan propertyler veya metodlar benzerlik gösteriyorsa miras alma yöntemi ile aynı özellikleri yeniden belirtmenize gerek kalmadan miras alınan class içerisindeki tüm özellikleri kullanabilirsiniz.
    // Miras alma işleminde bir class'a sadece bir tane class miras alınabilir.
    // classlar arasında miras alma işlemi zincirleme olabilir.
    // Class miras alma işlemi class isminden sonra : (iki nokta) yazıldıktan sonra miras alınacak olan class'ın ismi yazılır.


    class Kisi
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }

        public string TamAd
        {
            get { return Ad + " " + Soyad; }
        }
    }
}
