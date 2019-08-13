using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    class Node
    {
        public Int64 data;
        public Node next;

        public Node(Int64 number)
        {
            data = number;
            next = null;
        }
    }
    class Linked_list
    {
        public Node headnode;
        Int64 maxvalue = 0;


        public void push(Int64 number)
        {

            if (number > maxvalue)
                maxvalue = number;
            if (headnode == null)
                headnode = new Node(number);
            else
            {
                Node temp = new Node(number);
                temp.next = headnode;
                headnode = temp;
            }
        }

        public void pop()
        {
            if (maxvalue == headnode.data && headnode.next != null)
            {
                maxvalue = 0;
                Node temp = headnode;
                //Int64 value = temp.data;
                while (temp.next != null)
                {
                    if (temp.next.data > maxvalue)
                    {
                        maxvalue = temp.next.data;
                    }
                    temp = temp.next;
                }
            }
            else if (headnode.next == null)
                maxvalue = 0;

            headnode = headnode.next;
        }

        public string MaxValue()
        {
            //Node temp = headnode;
            //Int64 value = temp.data;
            //while(temp.next!=null)
            //{
            //    if(temp.next.data>value)
            //    {
            //        value = temp.next.data;
            //    }
            //    temp = temp.next;
            //}
            if (maxvalue == 0)
                return null;
            else
                return maxvalue.ToString();
        }
    }
    class LinkedList_Implementation_of_stack
    {

        static void Main(string[] args)
        {
            Linked_list listvalue = new Linked_list();
            Int64 input = Int64.Parse(Console.ReadLine());
            for (Int64 i = 1; i <= input; i++)
            {
                string data = Console.ReadLine();
                string[] val = data.Split();
                if (Int64.Parse(val[0]) == 1)
                    listvalue.push(Int64.Parse(val[1]));
                else if (Int64.Parse(val[0]) == 2)
                    listvalue.pop();
                else
                    Console.WriteLine(listvalue.MaxValue());

            }
        }
    }
}
