using System;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Atama ve işlemli atama

            int x = 3;
            int y = 3;
            y = y+2;

            System.Console.WriteLine(y);
            y +=2;
            System.Console.WriteLine(y);
            y/=1;
            System.Console.WriteLine(y);
            x*=2;
            System.Console.WriteLine(x);

            System.Console.WriteLine("*** Mantıksal Operatörler ***");

            // Mantıksal Operatörler
            // ||, &&, ! - veya, ve, değil

            bool isSuccess = true;
            bool isCompleted = false;

            if(isSuccess && isCompleted) //iki durum da true(false) mu? Hayır.
            System.Console.WriteLine("Perfect!");

            if(isSuccess || isCompleted) // iki durum true veya false mı? Evet.
            System.Console.WriteLine("Great");

            if(isSuccess && !isCompleted) //iki durum true(false) mu? isCompleted değil mi? Evet.
            System.Console.WriteLine("Fine!");

            System.Console.WriteLine("*** İlişkisel operatörler ***");

            // İlişkisel operatörler
            // <, >, <=, >=, ==, !=

            int a = 3;
            int b = 4;

            bool sonuc = a<b;
            System.Console.WriteLine(sonuc);
            sonuc = a>b;
            System.Console.WriteLine(sonuc);
            sonuc = a>=b;
            System.Console.WriteLine(sonuc);
            sonuc = a<=b;
            System.Console.WriteLine(sonuc);
            sonuc = a==b;
            System.Console.WriteLine(sonuc);
            sonuc = a!=b;
            System.Console.WriteLine(sonuc);

            System.Console.WriteLine("*** Aritmetik Operatörler ***");
            //Aritmetik Operatörler
            // /, *, +, -

            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1/sayi2;
            System.Console.WriteLine(sonuc1);
            sonuc1 = sayi1*sayi2;
            System.Console.WriteLine(sonuc1);
            sonuc1 = sayi1+sayi2;
            System.Console.WriteLine(sonuc1);
            sonuc1 = sayi1++;
            System.Console.WriteLine(sonuc1);

            // % mod almak için kullanılır.
            int sonuc2 = 20%3;
            System.Console.WriteLine(sonuc2);

        }
    }
}
