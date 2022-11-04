using System.Diagnostics;

namespace DataStructures 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            LinkedList linkedList = new LinkedList();
            linkedList.AddNodeToFront(5);
            linkedList.AddNodeToFront(8);
            linkedList.AddNodeToFront(1);
            linkedList.AddNodeToFront(19);
            linkedList.AddNodeToFront(52);
            linkedList.AddNodeToFront(10);
            linkedList.AddNodeToFront(14);
            linkedList.PrintList();
        }

        //Single Linked List
        class LinkedListNode 
        {
            public int data;
            public LinkedListNode next;

            public LinkedListNode(int x) 
            {
                data = x;
                next = null;
            }
        }

        class LinkedList 
        {
            int count;
            LinkedListNode head;

            public LinkedList()
            {
                head = null;
                count = 0;
            }

            public void AddNodeToFront(int data)
            {
                LinkedListNode node - new LinkedListNode(data);
                node.next = head;
                head = node;
                count++;
            }

            public void PrintList()
            {
                LinkedListNode runner = head;
                while(runner != null)
                {
                    Console.WriteLine(runner.data);
                    runner = runner.next;
                }
            }
        }
    }
}