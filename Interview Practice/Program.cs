using System;
using System.Collections;

namespace Interview_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Exercises ex = new Exercises();
            int[] array = new int[] {1,2,5,10,15,19,30,31,35 };
            ex.BinarySearchArray(array,0,array.Length,31);

            /*MultiMap _multiMap = new MultiMap();
            _multiMap.Add("1","uno");
            _multiMap.Add("1","one");
            _multiMap.Add("2", "dos");
            _multiMap.Add("2", "two");

            Console.WriteLine(_multiMap);*/

            /*GenericArray<int> intArray = new GenericArray<int>();
            GenericArray<string> stringArray = new GenericArray<string>();
            

            String s = "i like this program very much";

            Exercises ex = new Exercises();

            //ex.call();
            //Console.WriteLine(ex.ReverseWordsInPlace(s.ToCharArray()));
            ex.NumberToColumns(27);
            //ex.HexToInteger("F");

            //Console.WriteLine("Fibonacci: "+ex.Fibonacci(6));

            //LinkedList li = new LinkedList();
            //li.NumberToList(321);
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
            //ex.BubbleSort(arr);


            int[] arr2 = { 0, 0, 0, 10, 0, 6, 9, 0 };
            ex.MoveZerosToLeft(arr2);

            //Deck d = new Deck();

            //Console.WriteLine(d.ToString());


            /*LinkedList li = new LinkedList();
            li.InserAtEnd(1);
            li.InserAtEnd(2);
            li.InserAtEnd(3);*/
            //li.InsertAtHead(0);

            //Console.WriteLine(li.ListToNumber());
            //Console.WriteLine(li);
            //li.ReverseLinkedList();
            //Console.WriteLine(li);


            /*BinaryTree tree = new BinaryTree();

            tree.Insert(10);
            tree.Insert(5);
            tree.Insert(15);
            tree.Insert(3);
            tree.Insert(6);
            */

        }
    }
}
