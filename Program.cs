using System;
using System.Collections.Generic;

namespace CollectionInsert
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var list1 = new List<DateTime>()
            {
                new DateTime(2001, 12, 14),
                new DateTime(2017, 9, 1),
                new DateTime(2019, 5, 21),
                new DateTime(2020, 3, 12)
            };
            
            var list2 = new List<int>()
            {
                1, 3, 6, 88
            };
            
            var list3 = new List<string>()
            {
                "a"
            };
            
            var list4 = new List<float>();

            var list5 = new List<char>()
            {
                'c',
                '#',
                'r',
                'u',
                'l',
                'e',
                's'
            };
            
            list1.MyInsert(new DateTime(2000, 4, 6));
            list1.MyInsert(new DateTime(2018, 1, 1));
            list1.MyInsert(new DateTime());
            list1.MyInsert(new DateTime(2021, 6, 30));

            list2.MyInsert(2);
            list2.MyInsert(6);
            list2.MyInsert(60);

            list3.MyInsert("");
            list3.MyInsert(" ");
            list3.MyInsert("&");

            list4.MyInsert(0.5f);
            list4.MyInsert(0.49f);

            try
            {
                list5.MyInsert('J');
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("list5: " + e.Message);
            }
            
            
            // Output.
            Console.WriteLine("List1:\n");
            foreach (var k in list1)
            {
                Console.WriteLine(k);
            }
            
            Console.WriteLine("\n\nList2:\n");            
            foreach (var k in list2)
            {
                Console.WriteLine(k);
            }

            Console.WriteLine("\n\nList3:\n");            
            foreach (var k in list3)
            {
                Console.WriteLine(k);
            }

            Console.WriteLine("\n\nList4:\n");            
            foreach (var k in list4)
            {
                Console.WriteLine(k);
            }

            Console.WriteLine("\n\nList5:\n");            
            foreach (var k in list5)
            {
                Console.WriteLine(k);
            }
        }
    }
}