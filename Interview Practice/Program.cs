using System;
using System.Collections;

namespace Interview_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            

            String s = "i like this program very much";

            Exercises ex = new Exercises();

            ex.call();
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
