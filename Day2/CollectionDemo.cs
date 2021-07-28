using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class CollectionDemo
    {

        static void ArrarEg()
        {
            ArrayList al = new ArrayList();

            Console.WriteLine("Capacity {0}", al.Capacity); //Initially Capacity=0
            al.Add(10);

            Console.WriteLine("Capacity {0}", al.Capacity); //Capacity=4
            al.Add("Shreyash");
            Console.WriteLine("Capacity {0}", al.Capacity);
            al.Add("a");
            Console.WriteLine("Capacity {0}", al.Capacity);

            al.Add(20);
            Console.WriteLine("Capacity {0}", al.Capacity);// After capacity is full, it gets doubled

            foreach( var a in al)
            {
                Console.WriteLine(a);
            }

            Console.WriteLine("Capacity {0}", al.Capacity);

        }

        //Combination of key and value

         static void HashtableEg()
        {
            Hashtable ht = new Hashtable();
            ht.Add("N", "Networks");
            ht.Add("O", "Operating System");
            ht.Add("J", "Java");
            ht.Add("U", "Unix");

            Console.WriteLine(ht.Contains("0"));

            foreach(DictionaryEntry d in ht)
            {
                Console.WriteLine(d.Key + ":" + d.Value);
            }

        }
        /*
        static void SortedListEg()
        {
            SortedList s1 = new SortedList();
            t.Add("N", "Networks");
            ht.Add("O", "Operating System");
            ht.Add("J", "Java");
            ht.Add("U", "Unix");

            Console.WriteLine(ht.Contains("0"));

            foreach (DictionaryEntry d in ht)
            {
                Console.WriteLine(d.Key + ":" + d.Value);
            }

        }
        */
        static void Main()
        {
            ArrarEg();
            Console.WriteLine("Hashtable");
            HashtableEg();
          //Console.WriteLine("SortedList");
         // SortedListEg();
        }


    }
}
