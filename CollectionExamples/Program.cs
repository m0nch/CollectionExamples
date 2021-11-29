using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            //OrderedDictionary example
            #region OrderedDictionary
            Console.WriteLine("**********OrderedDictionary example**********");
            OrderedDictionary orderedDictionary = new OrderedDictionary();

            orderedDictionary.Add("testKey1", "testValue1");
            orderedDictionary.Add("testKey2", "testValue2");
            orderedDictionary.Add("testKey3", "testValue3");
            orderedDictionary.Add("testKey4", "testValue4");
            orderedDictionary.Add("testKey5", "testValue5");

            Console.Write("OrderedDictionary elements...\n");
            foreach (DictionaryEntry item in orderedDictionary)
            {
                Console.WriteLine($"{item.Key}\t{item.Value}");
            }
            Console.WriteLine($"OrderedDictionary elements count: {orderedDictionary.Count}");

            if (orderedDictionary.Contains("testKey3"))
            {
                orderedDictionary.Remove("testKey3");
            }
            Console.WriteLine($"OrderedDictionary elements count: {orderedDictionary.Count}");

            orderedDictionary.Insert(2, "testKey3", "testValue3");
            Console.Write("OrderedDictionary elements...\n");
            foreach (DictionaryEntry item in orderedDictionary)
            {
                Console.WriteLine($"{item.Key}\t{item.Value}");
            }
            Console.WriteLine($"OrderedDictionary elements count: {orderedDictionary.Count}");

            orderedDictionary.Clear();
            Console.WriteLine($"OrderedDictionary elements count: {orderedDictionary.Count}");
            #endregion

            //Hashtable example
            #region Hashtable
            Console.WriteLine("**********Hashtable example**********");
            Hashtable hashtable = new Hashtable();

            int[] arrayInt = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            string[] arrayString = new string[10] { "Yerevan", "Gyumri", "Vanadzor", "Vagharshapat", "Abovyan", "Kapan", "Hrazdan", "Artashat", "Armavir", "Dilijan" };

            for (int i = 0; i < arrayInt.Length; i++)
            {
                hashtable.Add(arrayInt[i], arrayString[i]);
            }
            Console.Write("Collection elements...\n");
            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine($"{item.Key}\t{item.Value}");
            }

            Console.WriteLine($"Collection elements count: {hashtable.Count}");

            Console.WriteLine($"{hashtable.ContainsKey(0)}");
            Console.WriteLine($"{hashtable.ContainsValue("Vagharshapat")}");

            Hashtable newHhashtable = (Hashtable)hashtable.Clone();

            hashtable.Remove(10);
            hashtable.Remove(9);

            hashtable.Clear();
            #endregion

            //Queue example
            #region Queue
            Console.WriteLine("**********Queue example**********");
            Queue queue = new Queue(newHhashtable);
            Console.WriteLine($"Collection elements count: {queue.Count}");
            Console.Write("Collection elements...\n");
            DictionaryEntry dictionaryEntry;
            dictionaryEntry.Key = 11;
            dictionaryEntry.Value = "Ijevan";
            queue.Enqueue(dictionaryEntry);
            foreach (DictionaryEntry item in queue)
            {
                Console.WriteLine($"{item.Key}\t{item.Value}");
            }
            queue.Enqueue(new DictionaryEntry(12, "Sevan"));
            queue.Enqueue(new DictionaryEntry(13, "Charentsavan"));
            foreach (DictionaryEntry item in queue)
            {
                Console.WriteLine($"{item.Key}\t{item.Value}");
            }
            Console.WriteLine($"Collection elements count: {queue.Count}");

            var element1 = (DictionaryEntry)queue.Dequeue();
            var element2 = (DictionaryEntry)queue.Dequeue();
            var element3 = (DictionaryEntry)queue.Dequeue();
            Console.WriteLine($"{element1.Key} {element1.Value}");
            Console.WriteLine($"{element2.Key} {element2.Value}");
            Console.WriteLine($"{element3.Key} {element3.Value}");
            var res = (DictionaryEntry)queue.Peek();
            Console.WriteLine($"{res.Key} {res.Value}");

            Console.WriteLine($"Collection elements count: {queue.Count}");

            #endregion

            //Stack example
            #region Stack
            Console.WriteLine("**********Stack example**********");
            Stack stack = new Stack();
            stack.Push("Doe");
            stack.Push("Jane");
            stack.Push("is");
            stack.Push("name");
            stack.Push("My");
            Console.WriteLine("Stack values:");
            foreach (var item in stack)
            {
                Console.Write($"{item} ");
            }

            var res2 = stack.Peek();
            Console.WriteLine($"{res2}");

            var res3 = stack.Pop();
            Console.WriteLine($"{res3}");

            stack.Push("Her");
            Console.WriteLine("Stack values:");
            foreach (var item in stack)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            #endregion

            //HashSet example
            #region HashSet
            Console.WriteLine("**********HashSet example**********");

            HashSet<int> evenNumbers = new HashSet<int>();
            HashSet<int> oddNumbers = new HashSet<int>();

            for (int i = 0; i < 10; i++)
            {
                evenNumbers.Add(i * 2);
                oddNumbers.Add((i * 2) + 1);
            }

            Console.Write("evenNumbers contains {0} elements: ", evenNumbers.Count);
            DisplaySet(evenNumbers);

            Console.Write("oddNumbers contains {0} elements: ", oddNumbers.Count);
            DisplaySet(oddNumbers);

            HashSet<int> numbers = new HashSet<int>(evenNumbers);
            Console.WriteLine("numbers UnionWith oddNumbers...");
            numbers.UnionWith(oddNumbers);

            Console.Write("numbers contains {0} elements: ", numbers.Count);

            void DisplaySet(HashSet<int> collection)
            {
                Console.Write("{");
                foreach (int i in collection)
                {
                    Console.Write($" {i}");
                }
                Console.WriteLine(" }");
            }
            #endregion

            //SortedSet example
            #region SortedSet
            Console.WriteLine("**********SortedSet example**********");
            Random rnd = new Random();
            SortedSet<int> sortedSet1 = new SortedSet<int>();
            SortedSet<int> sortedSet2 = new SortedSet<int>();
            for (int i = 0; i < 20; i++)
            {
                sortedSet1.Add(rnd.Next(1, 20));
                sortedSet2.Add(rnd.Next(1, 20));
            }
            Console.Write("\nSortedSet1 elements...\n");
            foreach (var item in sortedSet1)
            {
                Console.Write($"{item}  ");
            }
            Console.Write("\nSortedSet2 elements...\n");
            foreach (var item in sortedSet2)
            {
                Console.Write($"{item}  ");
            }
            SortedSet<int> sortedSet = new SortedSet<int>(sortedSet1);
            sortedSet.UnionWith(sortedSet2);

            Console.Write("\nUnion elements...\n");
            foreach (var item in sortedSet)
            {
                Console.Write($"{item}  ");
            }
            #endregion

            Console.ReadKey();
        }
    }
}
