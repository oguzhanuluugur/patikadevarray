﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace Array_List
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Collections
            ArrayList list = new ArrayList();
            //list.Add("Ayşe");
            //list.Add(2);
            //list.Add(true);
            //list.Add('a');

            //içerisindekş verilere erişim
            //Console.WriteLine(list[1]);
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //Adrange
            Console.WriteLine("********AdRange**********");
           // string[] renkler = { "Kırmızı", "Sarı", "Yeşil" };
            List<int> sayılar = new List<int>() { 1, 3, 7, 9, 5 };
           // list.AddRange(renkler);
            list.AddRange(sayılar);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            //Sort

            Console.WriteLine("*******Sort***********");
            list.Sort();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            // Binary Search
            Console.WriteLine("*******Binary Search***********");
            Console.WriteLine(list.BinarySearch(9));

            //Reverse
            Console.WriteLine("******Reverse***********");
            list.Reverse();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //Clear
            Console.WriteLine("******Clear***********");
            list.Clear();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
