using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workaround
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SelamVer("Engin");
            SelamVer("Ahmet");
            SelamVer("Ayşe");
            SelamVer();

            int sonuc = Topla(3, 5);

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Kerem";
            ogrenciler[2] = "Berkay";

            ogrenciler = new string[4];
            ogrenciler[3] = "Ilker";

            int sayi1 = 10;
            int sayi2 = 20;

            sayi2 = sayi1;
            sayi1 = 30;
            //sayi2 = ?; 10 olur

            for (int i = 0; i < ogrenciler.Length; i++) // i++ = i=i+1
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };
            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);

            Person person1 = new Person
            {
                Firstname = "ANIL",
                Lastname = "AKBAY",
                DateOfBirthDay = 1991,
                NationalIdentity = 123
            };

            Person person2 = new Person
            {
                FirstName = "MURAT"
            };

            List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
            yeniSehirler1.Add("Adana 1");

            foreach (var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            Console.ReadLine();
        }
        static void SelamVer(string isim = "isimsiz") //default parametre
        {
            Console.WriteLine("Merhaba" + isim);
        }
        static int Topla(int sayi1 = 5, int sayi2 = 10) //default parametre en sona yazılır
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam : " + sonuc);
            return sonuc;
        }
        public class Vatandas
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public int DogumYili { get; set; }
            public long TcNo { get; set; }
        }

        private class Person
        {
            public string Firstname { get; internal set; }
            public string FirstName { get; internal set; }
            public string Lastname { get; internal set; }
            public int DateOfBirthDay { get; internal set; }
            public int NationalIdentity { get; internal set; }
        }
    }
}

