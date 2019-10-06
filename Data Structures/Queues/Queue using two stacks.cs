using System;

namespace Queues
{
    class Program
    {
        public class node
        {
            public int data;
            public node next;
            public node(int value)
            {
                data = value;
                next = null;
                
            }
        }
        class Stack1
        {
            public node headnode;
            public void push(int value)
            {
                if (headnode == null)
                    headnode = new node(value);
                else
                {
                    node temp = new node(value);
                    temp.next = headnode;
                    headnode = temp;
                }

            }
            
            public int pop()
            {
                if (headnode == null)
                    return 0;
                node temp = headnode;
                headnode = headnode.next;
                return temp.data;
            }
        }
        class Stack2
        {
            public node headnode;
            public void push(int value)
            {
                if (headnode == null)
                    headnode = new node(value);
                else
                {
                    node temp = new node(value);
                    temp.next = headnode;
                    headnode = temp;
                }

            }

            public int pop()
            {
                if (headnode == null)
                    return 0;
                node temp = headnode;
                headnode = headnode.next;
                return temp.data;
            }

            public bool empty()
            {
                if (headnode == null)
                    return true;
                else
                    return false;
            }
            public int print()
            {
                return headnode.data;
            }
        }
        static void Main(string[] args)
        {
            Stack1 objstack1 = new Stack1();
            Stack2 objstack2 = new Stack2();
            int input = int.Parse(Console.ReadLine());
            for(int i=0;i<input;i++)
            {
                string val = Console.ReadLine();
                string[] values = val.Split(' ');
                if(values[0]=="1")
                {
                    objstack1.push(int.Parse(values[1]));
                }
                else if(values[0]=="2")
                {
                    int chk;
                    if (objstack2.empty())
                    {
                        while ((chk = objstack1.pop()) != 0)
                        {

                            objstack2.push(chk);
                        }
                    }
                    objstack2.pop();
                    //int chk2;
                    //while ((chk2= objstack2.pop()) != 0)
                    //{
                       
                    //    objstack1.push(chk2);
                    //}
                }
                else
                {
                    int chk3;
                    if (objstack2.empty())
                    {
                        while ((chk3 = objstack1.pop()) != 0)
                        {

                            objstack2.push(chk3);
                        }
                    }
                    Console.WriteLine(objstack2.print());
                    //int chk4;
                    //while ((chk4=objstack2.pop() )!= 0)
                    //{
                        
                    //    objstack1.push(chk4);
                    //}
                }
            }
            Console.ReadKey();
        }
    }
}
