using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12sinifC_
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Yazdırma komutları 
            //Console.Write("Hello World");
            //Console.WriteLine("12-B tasarım sınıfı");
            //Console.WriteLine("121asdasd");

            //Console.WriteLine("---------- Yemek çeşitleri ----------");
            //Console.WriteLine();
            //Console.WriteLine("1- Çorbalar");
            //Console.WriteLine("2- Ana Yemek");
            //Console.WriteLine("3- Ara Sıcakklar");
            //Console.WriteLine("4- Tatlılar");
            //Console.WriteLine("5-İçecekler");
            //Console.WriteLine("6- Salatalar");
            //Console.WriteLine();
            //Console.WriteLine("---------- Yemek çeşitleri ----------");



            #endregion


            #region String Değişkenler

            //değişken isimlendirme kuralları

            //degisken ismi sayi ile baslyamaz
            //degisken isimleri arasonda bir boşluk bırakılmaz genelde - veya _ gibi  semboler kullanılır
            //programlama dilinde özel anlama gelen (for,while,class) kelimeler değişken adı olamaz

            // Bazı değişken oluşturma stilleri

            // camel case değişken oluşturma ---------   ilkNumaraSecimi
            // Pascal Case değişken oluşturma ---------  PazartesiGunuKahvaltisi
            // Snake Case değişken oluşturma ----------  pazartesi_gunu_kahvaltisi
            // Kebab Case değişken oluşturma -----------  pazartesi-gunu-kahvaltisi
            // UPPER CASE değişkne oluşturma -----------  PAZARTESİGUNUKAHVALTİİSİ
            //flat case değişken isimlendirme ----------  pazartesigunukahvaltisi

            //string değişkenn

            // degiskenTürü değişken adı;

            //string isim; // degiskeni tanımlama adımı
            //isim = "kerim"; // değişkenin içine değer atama adımı
            //Console.WriteLine(isim); //değişkeni ekrana yazdırma 


            #endregion

            #region int Değişkkenler (tam sayı değişkenleri)

            //int yas; // degiskeni tanımlama adımı

            //yas = 17; // değişkenin içine değer atama adımı

            //int sayi = 5; // degiskeni tanımlama ve değer atama adımı

            //Console.WriteLine(yas); //değişkeni ekrana yazdırma
            //Console.WriteLine(sayi);

            //int hamburgerFiyati = 50; // degiskeni tanımlama ve değer atama adımı
            //int kolafiyati = 15;
            //int sufiyati = 5;
            //int limotafiyati = 10;

            //Console.WriteLine("************* Restoran menü Fiyatı ************");
            //Console.WriteLine();
            //Console.WriteLine("hamburger fiyayı: " + hamburgerFiyati);
            //Console.Write("kola fiyayı: " + kolafiyati);
            //Console.WriteLine("su fiyayı: " + sufiyati);
            //Console.WriteLine("limonata fiyayı: " + limotafiyati);
            //Console.WriteLine();
            //Console.WriteLine("************* Restoran menü Fiyatı ************");


            //int hamburgerAdedi = 2;
            //int kolaAdedi = 3;
            //int suAdedi = 1;
            //int limonataAdedi = 2;


            //int toplamhamburgerFiyati = hamburgerFiyati * hamburgerAdedi;
            //int toplamKolaFiyati = kolafiyati * kolaAdedi;
            //int toplamSufiyati = sufiyati * suAdedi;
            //int toplamLimonataFiyati = limotafiyati * limonataAdedi;

            //int toplamFiyat = toplamhamburgerFiyati + toplamKolaFiyati + toplamSufiyati + toplamLimonataFiyati;

            //Console.WriteLine("Toplam Fiyat: " + toplamFiyat + " TL");

            #endregion


            #region Double Değişkenler (ondalıklı sayı değişkenleri)


            //double ondalikliSayi;
            //ondalikliSayi = 3.14;

            //double piSayisi = 3.14;


            //Console.WriteLine(piSayisi);
            //Console.WriteLine(ondalikliSayi);

            //double elmafiyatı, armutfiyati, muzfiyati, cilekfiyati;

            //elmafiyatı = 5.5;
            //armutfiyati = 7.25;
            //muzfiyati = 4.75;
            //cilekfiyati = 126.0;

            ////Console.WriteLine("------- Elma Birim fiyatı: " + elmafiyatı + " TL");
            ////Console.WriteLine("------- Armut Birim fiyatı: " + armutfiyati + " TL");
            ////Console.WriteLine("------- Muz Birim fiyatı: " + muzfiyati + " TL");
            ////Console.WriteLine("------- Çilek Birim fiyatı: " + cilekfiyati + " TL");


            //double elmaGramajı = 1;
            //double armutGramajı = 1.5;
            //double muzGramajı = 2;
            //double cilekGramajı = 0.5;

            //double toplamElmaFiyati = elmafiyatı * elmaGramajı;
            //double toplamArmutFiyati = armutfiyati * armutGramajı;
            //double toplamMuzFiyati = muzfiyati * muzGramajı;
            //double toplamCilekFiyati = cilekfiyati * cilekGramajı;


            //Console.WriteLine("Alınan ürün fiyatı-"+"Elma " +"Ürün gramaj :"+ elmafiyatı+ "- Gramaj:"+elmaGramajı+"-Toplam tutar: "+toplamElmaFiyati);
            //Console.WriteLine("Alınan ürün fiyatı-"+"Armut " +"Ürün gramaj :"+ armutfiyati+ "- Gramaj:"+armutGramajı+"-Toplam tutar: "+toplamArmutFiyati);
            //Console.WriteLine("Alınan ürün fiyatı-"+"Muz " +"Ürün gramaj :"+ muzfiyati+ "- Gramaj:"+muzGramajı+"-Toplam tutar: "+toplamMuzFiyati);
            //Console.WriteLine("Alınan ürün fiyatı-"+"Çilek " +"Ürün gramaj :"+ cilekfiyati+ "- Gramaj:"+cilekGramajı+"-Toplam tutar: "+toplamCilekFiyati);


            //double toplamFiyat = toplamElmaFiyati + toplamArmutFiyati + toplamMuzFiyati + toplamCilekFiyati;
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş tutarı: " + toplamFiyat + " TL");




            #endregion


            #region char Değişkenler (tek karakter değişkenleri)

            char karakter = 'A';
            char karakter2 = '/';

            Console.WriteLine(karakter);
            Console.WriteLine(karakter2);


            #endregion




        }
    }
}
