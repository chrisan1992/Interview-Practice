using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Practice
{
    public class LinkedList
    {
        public ListNode head;

        public LinkedList()
        {
            this.head = null;
        }

        public void InserAtEnd(int value)
        {
            if (head == null)
            {//empty list
                head = new ListNode(value);
            }
            else
            {//iterate to add at the end
                ListNode curr = head;
                ListNode newNode = new ListNode(value);
                while (curr.next != null)
                {
                    curr = curr.next;
                }
                curr.next = newNode;
            }
        }

        public void InsertAtHead(int value)
        {
            ListNode newNode = new ListNode(value);
            newNode.next = this.head;
            this.head = newNode;
        }

        public override string ToString()
        {
            String result = "";

            ListNode curr = head;
            while (curr != null)
            {
                result += curr.value + " -> ";
                curr = curr.next;
            }

            return result;
        }

        public int ListToNumber()
        {
            int result = 0;
            int multiplier = 1;
            ListNode curr = this.head;
            while (curr != null)
            {//until we reach the end of the list
                result += curr.value * multiplier;//sum the value multipled
                multiplier *= 10;//multiply by ten
                curr = curr.next;//move pointer
            }

            return result;
        }

        public ListNode NumberToList(int N)
        {
            ListNode newHead = new ListNode(-1);
            ListNode curr = newHead;

            while (N != 0)
            {//until I finish the number
                ListNode node = new ListNode(N%10);//create a node with the last digit
                curr.next = node;//link the new node to the list
                curr = node;//move the pointer
                N = N / 10;//remove last digit from the number
            }

            return newHead.next;
        }

        public void ReverseLinkedList()
        {
            ListNode curr = this.head;
            while (curr.next != null)
            {
                ListNode temp = curr.next;
                curr.next = curr.next.next;
                temp.next = head;
                head = temp;
            }
        }

        public bool DetectLoop()
        {
            bool result = false;
            ListNode fastPointer = head, slowPointer = head;//pointer to iterate on the list

            while (slowPointer.next != null && fastPointer.next != null && fastPointer.next.next != null)
            {//until I reach the end of the list or detect loop
                //move the pointers
                slowPointer = slowPointer.next;
                fastPointer = fastPointer.next.next;

                if (slowPointer == fastPointer)
                {//loop detected as both pointer met
                    result = true;
                    break;
                }
            }

            return result;
        }
    }

    public class ListNode
    {
        public int value;
        public ListNode next;

        public ListNode(int value)
        {
            this.value = value;
            this.next = null;
        }
    }
}
