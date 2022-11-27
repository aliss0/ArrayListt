using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ArrayListt
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            //liste.Add("Ayşe");
            //liste.Add(2);
            //liste.Add(true);
            //liste.Add('A');

            // İçersindekilere erişme 
            //Console.WriteLine(liste[1]);
            //Console.WriteLine("-----------------------------");
            //foreach (var item in liste)
            //    Console.WriteLine(item);

            // AddRange
            Console.WriteLine("-----------------------------");
            Console.WriteLine("**** Add Range ***");
            //string[] renkler = { "kırmızı", "sarı", "yeşil" };
            List<int> sayilar = new List<int>() { 1, 0, 3, 7, 9, 92, 5 };
            Console.WriteLine("-----------------------------");
            //liste.AddRange(renkler);
            liste.AddRange(sayilar);
            foreach (var item in liste)
                Console.WriteLine(item);

            // Sort
            Console.WriteLine("*******Sort****");
            liste.Sort();
            Console.WriteLine("-----------------------------");
            foreach (var item in liste)
                Console.WriteLine(item);

            // Binary Search
            Console.WriteLine("-----------------------------");

            Console.WriteLine("*******BinarySearch****");
            Console.WriteLine(liste.BinarySearch(9));

            // Reverse
            Console.WriteLine("*******Reverse****");
            liste.Reverse();
            Console.WriteLine("-----------------------------");
            foreach (var item in liste)
                Console.WriteLine(item);
            //Clear
            Console.WriteLine("*******Clear****");
            liste.Clear();
            Console.WriteLine("-----------------------------");
            foreach (var item in liste)
                Console.WriteLine(item);

            Console.ReadLine();

           
        }
    }
}
