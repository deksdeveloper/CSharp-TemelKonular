using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_TemelKonular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YemekKategorileri
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("***** Yemek Kategorileri *****");
            Console.WriteLine();
            Console.WriteLine("1 - Çorbalar");
            Console.WriteLine("2 - Ana Yemekler");
            Console.WriteLine("3 - Soğuk Başlangıclar");
            Console.WriteLine("4 - Salatalar");
            Console.WriteLine("5 - Tatlılar");
            Console.WriteLine("6 - İçecekler");
            Console.WriteLine();
            Console.WriteLine("***** Yemek Kategorileri *****");
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------");
            #endregion

            #region StringDeğişkenler

            // Değişkenler


            string customerName, customerSurname, customerPhone, customerEmail, customerCity, customerDistrict;

            customerName = "Deks";
            customerSurname = "Göttenbasan";
            customerPhone = "+90 500 400 30 20";
            customerEmail = "deneme@gmail.com";
            customerCity = "İstanbul";
            customerDistrict = "Kadıköy";

            
            Console.WriteLine("**** Müşteri Bilgileri ****");
            Console.WriteLine();
            Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            Console.WriteLine("İletişim: " + customerPhone + " - " + customerEmail);
            Console.WriteLine("Adres: " + customerCity + " - " + customerDistrict);
            Console.WriteLine();
            Console.WriteLine("**** Müşteri Bilgileri ****");
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------");


            #endregion

            #region IntDeğişkenler

            int hamburgerPrice = 31;
            int pizzaPrice = 21;
            int colaPrice = 5;

            Console.WriteLine();
            Console.WriteLine("**** Yemek Fiyatları ****");
            Console.WriteLine();
            Console.WriteLine("Hamburger: " + hamburgerPrice + "TL");
            Console.WriteLine("Pizza: " + pizzaPrice + "TL");
            Console.WriteLine("Kola: " + colaPrice + "TL");
            Console.WriteLine();
            Console.WriteLine("**** Yemek Fiyatları ****");
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------");

            int hamburgerCount;
            int pizzaCount;
            int colaCount;

            colaCount = 2;
            hamburgerCount = 1;
            pizzaCount = 1;

            int totalColaPrice = colaCount * colaPrice;
            int totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            int totalPizzaPrice = pizzaCount * pizzaPrice;
            int totalPrice = totalColaPrice + totalHamburgerPrice + totalPizzaPrice;
            
            Console.WriteLine();
            Console.WriteLine("**** Yenilen Yemekler ****");
            Console.WriteLine();
            Console.WriteLine("Hamburger: " + hamburgerCount + " adet" + " - " + "Fiyat:" + totalHamburgerPrice);
            Console.WriteLine("Pizza: " + pizzaCount + " adet" + " - " + "Fiyat:" + totalPizzaPrice);
            Console.WriteLine("Kola: " + colaCount + " adet" + " - " + "Fiyat:" + totalColaPrice);
            Console.WriteLine("Toplam Fiyat: " + totalPrice + "TL");
            Console.WriteLine();
            Console.WriteLine("**** Yenilen Yemekler ****");
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------");
            #endregion
            Console.Read();
        }
    }
}