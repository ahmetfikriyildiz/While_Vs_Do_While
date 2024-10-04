using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace While_Vs_Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bu pratikte aynı sorunun cevabını hem while hem de do -while ile kodlamanız ve örnek girdilerde ikisi arasındaki farkı irdelemeniz bekleniyor.
            //Kullanıcının girdiği bir limit değerine kadar 0'dan bir sayaç çalıştırıp artırarak, ekrana " Ben bir Patika'lıyım " yazdırınız." +
            //(Sayacınız 0'dan başlayarak 1'er 1'er artacak, koşulunuz ( Sayac <= Limit ) )
            //Örnek inputlar: 10 ve - 5
            //Uygulama testi sonrası while ve do -while arasındaki farkı yorum satırı olarak kodunuzun altına ekleyiniz.

            // ben koşulu değiştirdim. "<=" bunu "<" ile onun dışında kod çalışıyor.
            #region While
            //Console.WriteLine("Bir limit değeri giriniz : ");
            //int limit = int.Parse(Console.ReadLine()); 
            //int sayac = 0;
            //while (sayac < limit)
            //{
            //    Console.WriteLine("Ben bir Patika'lıyım");
            //    sayac++;
            //}
            //Console.ReadLine();
            #endregion
            #region DoWhile
            //Console.WriteLine("Bir limit değeri giriniz:");
            //int limit = int.Parse(Console.ReadLine());
            //int sayac = 0;
            //do
            //{
            //    Console.WriteLine("Ben bir Patika'lıyım");
            //    sayac++;
            //} while (sayac < limit);
            //Console.ReadLine();
            #endregion

        }
        //while döngüsü koşulu önce kontrol eder.
        //do-while döngüsü koşulu sonra kontrol eder yani eğer koşul istenilen koşul değilse bile döngü bir defa çalışır.
    }
}
