/*Bu pratikte aynı sorunun cevabını hem while hem de do-while ile kodlamanız ve örnek girdilerde ikisi arasındaki farkı irdelemeniz bekleniyor.

Kullanıcının girdiği bir limit değerine kadar 0'dan bir sayaç çalıştırıp artırarak, ekrana " Ben bir Patika'lıyım " yazdırınız.

( Sayacınız 0'dan başlayarak 1'er 1'er artacak, koşulunuz ( Sayac <= Limit ) )

Örnek inputlar : 10 ve - 5

Uygulama testi sonrası while ve do-while arasındaki farkı yorum satırı olarak kodunuzun altına ekleyiniz.*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir limit giriniz: ");
        int limit = Convert.ToInt32(Console.ReadLine());
        int sayac1 = 0;
        int sayac2 = 0;

        if (limit < 0) 
        {
            limit = Math.Abs(limit);
        }

        Console.WriteLine("-----------------While döngüsü--------------");
        while (sayac1 < limit)
        {
            Console.WriteLine("Ben bir Patika'lıyım");
            sayac1++;
        }

        Console.WriteLine("----------------DoWhile Döngüsü----------------");

        do
        {
            Console.WriteLine("Ben bir Patika'lıyım");
            sayac2++;
        }
        while (sayac2 < limit);


    }
}