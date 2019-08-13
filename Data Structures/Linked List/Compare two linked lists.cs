using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{

    class SinglyLinkedListNode
    {
        public int data;
        public SinglyLinkedListNode next;

        public SinglyLinkedListNode(int nodeData)
        {
            this.data = nodeData;
            this.next = null;
        }
    }

    class SinglyLinkedList
    {
        public SinglyLinkedListNode head;
        public SinglyLinkedListNode tail;

        public SinglyLinkedList()
        {
            this.head = null;
            this.tail = null;
        }

        public void InsertNode(int nodeData)
        {
            SinglyLinkedListNode node = new SinglyLinkedListNode(nodeData);

            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                this.tail.next = node;
            }

            this.tail = node;
        }
    }

    static void PrintSinglyLinkedList(SinglyLinkedListNode node, string sep, TextWriter textWriter)
    {
        while (node != null)
        {
            textWriter.Write(node.data);

            node = node.next;

            if (node != null)
            {
                textWriter.Write(sep);
            }
        }
    }

    // Complete the CompareLists function below.

    /*
     * For your reference:
     *
     * SinglyLinkedListNode {
     *     int data;
     *     SinglyLinkedListNode next;
     * }
     *
     */
    static bool CompareLists(SinglyLinkedListNode head1, SinglyLinkedListNode head2)
    {
        int result = 0;
        //SinglyLinkedListNode temp1 = new SinglyLinkedListNode(head1);
        //SinglyLinkedListNode temp2 = new SinglyLinkedListNode(head2);
        while ((head1.next != null && head2.next != null) && (head1.data == head2.data))
        {
            if (head1.next.data == head2.next.data)
                result = 1;
            else
            {
                result = 0;
                break;
            }
            head1 = head1.next;
            head2 = head2.next;
        }
        if (result == 1)
            return true;
        else
            return false;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int tests = Convert.ToInt32(Console.ReadLine());

        for (int testsItr = 0; testsItr < tests; testsItr++)
        {
            SinglyLinkedList llist1 = new SinglyLinkedList();

            int llist1Count = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < llist1Count; i++)
            {
                int llist1Item = Convert.ToInt32(Console.ReadLine());
                llist1.InsertNode(llist1Item);
            }

            SinglyLinkedList llist2 = new SinglyLinkedList();

            int llist2Count = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < llist2Count; i++)
            {
                int llist2Item = Convert.ToInt32(Console.ReadLine());
                llist2.InsertNode(llist2Item);
            }

            bool result = CompareLists(llist1.head, llist2.head);

            textWriter.WriteLine((result ? 1 : 0));
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
