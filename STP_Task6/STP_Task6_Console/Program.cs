﻿using STP_Task6.Collections.Generics;
using STP_Task6.Collections.Utils;
using STP_Task6.Random.Texting;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STP_Task6_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> list = new LinkedList<string>();
            list.Add("1232");
            for(int i =0; i < 20; i++)
            {
                list.Add("ITEM" + i);

            }
            list.PushFront("FF");

            for(int i =0; i < list.Length; i++)
            {
                Console.WriteLine(list[i]);
            }

            Console.WriteLine("\nRemoving.....\n");

            list.Remove("1232");
            list.Remove("F");
            list.RemoveAt(3);
            list.InsertAt(5, "GG");
            Console.WriteLine("Index of \"ITEM7\": " + ListUtils<string>.FindIndex<string>(list, u => u == "ITEM7"));
            Console.WriteLine("Index of \"ITEM7\": " + list.IndexOf("ITEM7"));
            ListUtils<string>.ForEach(list, (string item) => Console.WriteLine(item));

            Console.WriteLine("\n------------------- ARRAY_LIST -------------------\n");


            ArrayList<string> arraylist = new ArrayList<string>(10);
            arraylist.Add("1232");
            arraylist.Add("F");

            for (int i = 0; i < 20; i++)
            {
                arraylist.Add("ITEM" + i);

            }

            ListUtils<string>.ForEach(arraylist, (string item) => Console.WriteLine(item));

            Console.WriteLine("\nRemoving.....\n");

            arraylist.Remove("1232");
            arraylist.Remove("F");
            arraylist.RemoveAt(3);
            arraylist.InsertAt(5, "GG");
            arraylist[5] = "ggggggg"; 

            ListUtils<string>.ForEach(arraylist, (string item) => Console.WriteLine(item));
            Console.WriteLine("Lenght: " + arraylist.Length);

            Console.ReadLine();
        }
    }
}
