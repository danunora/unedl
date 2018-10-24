using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {

        // Display ArrayList Content
        public static void DisplayList(ArrayList lista, bool sorted)
        {
            if (sorted)
            {
                lista.Sort();
            }
            foreach (int i in lista)
            {
                Console.WriteLine("Item: {0}", i);
            }
        }

        // ArrayList Example
        public static void ArrayListExample()
        {
            ArrayList al = new ArrayList();
            al.Add(11);
            al.Add(53);
            al.Add(10);
            al.Add(32);
            Console.WriteLine("### ArrayList ###");
            Console.WriteLine("Capacity: {0}", al.Capacity);
            Console.WriteLine("Count: {0}", al.Count);
            DisplayList(al,false);
            al.Add(10);
            al.Add(32);
            Console.WriteLine("### Adding Duplicates ###");
            DisplayList(al, false);
            Console.WriteLine("### ArrayList Sorted ###");
            DisplayList(al, true);
        }

        // Display HashTable Content
        public static void DisplayHash(Hashtable hash)
        {
            ICollection key = hash.Keys;
            foreach (string k in key)
            {
                Console.WriteLine(k + ": " + hash[k]);
            }
        }

        // HashTable Example
        public static void HashExample()
        {
            Console.WriteLine("### HashTable ###");
            Hashtable ht = new Hashtable();
            ht.Add("A", "Artemisa");
            ht.Add("B", "Bertha");
            ht.Add("C", "Chely");
            ht.Add("D", "Daniela");
            ht.Add("E", "Estela");
            ht.Add("F", "Fabiola");
            DisplayHash(ht);
            Console.WriteLine("is Estela present?: "+ht.ContainsValue("Estela"));
            ht.Add("G", "Gabriela");
            ht.Add("H", "Helena");
            try
            {
                ht.Add("E", "Elena");
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }            
            DisplayHash(ht);
        }

        // Main 
        static void Main(string[] args)
        {
            ArrayListExample();
            HashExample();
        }
    }
}