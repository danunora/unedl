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

        // Display SortedList Content
        public static void DisplaySortedList(SortedList sorted)
        {
            ICollection key = sorted.Keys;
            foreach (string k in key)
            {
                Console.WriteLine(k + ": " + sorted[k]);
            }
        }

        // SortedList Example
        public static void SortedListExample()
        {
            Console.WriteLine("### SortedList ###");
            SortedList ht = new SortedList();
            Console.WriteLine("Inserting unsorted: ");
            Console.WriteLine("B, Bertha");
            Console.WriteLine("A, Artemisa");
            Console.WriteLine("C, Chely");
            Console.WriteLine("E, Estela");
            Console.WriteLine("D, Daniela");
            Console.WriteLine("F, Fabiola");
            Console.WriteLine("H, Helena");
            Console.WriteLine("G, Gabriela");
            ht.Add("B", "Bertha");
            ht.Add("A", "Artemisa");
            ht.Add("C", "Chely");
            ht.Add("E", "Estela");
            ht.Add("D", "Daniela");
            ht.Add("F", "Fabiola");
            ht.Add("H", "Helena");
            ht.Add("G", "Gabriela");
            Console.WriteLine("Displaying without sorting");
            DisplaySortedList(ht);
        }

        // Display stack
        public static void DisplayStack(Stack pila)
        {
            Console.WriteLine("Current stack content : ");
            foreach (char c in pila)
            {
                Console.WriteLine("Item: " + c);
            }
        }

        //Stack Example
        public static void StackExample()
        {
            Stack pila = new Stack();
            Console.WriteLine("### Stack ###");
            Console.WriteLine("Inserting...");
            pila.Push('B');
            pila.Push('A');
            pila.Push('C');
            pila.Push('E');
            pila.Push('D');
            pila.Push('F');
            pila.Push('H');
            pila.Push('G');
            DisplayStack(pila);
            Console.WriteLine("Peek: " + pila.Peek());
            for (int i = 1; i <=3; i++)
            {
                Console.WriteLine("Removing: " + pila.Pop());
            }
            Console.WriteLine("Peek: " + pila.Peek());
        }

        // Main Menu
        public static void MainMenu()
        {
            Console.WriteLine("############");
            Console.WriteLine("A) ArrayList");
            Console.WriteLine("B) HashTable");
            Console.WriteLine("C) SortedList");
            Console.WriteLine("D) Stack");
            Console.WriteLine("Q) Quit");
        }
        // Main 
        static void Main(string[] args)
        {
            bool seguir = true;
            while (seguir) {
                MainMenu();
                var x = Console.ReadLine();
                switch (x)
                {
                    case "A":
                        ArrayListExample();
                        break;
                    case "B":
                        HashExample();
                        break;
                    case "C":
                        SortedListExample();
                        break;
                    case "D":
                        StackExample();
                        break;
                    case "Q":
                        seguir = false;
                        break;
                }
            }
        }
    }
}