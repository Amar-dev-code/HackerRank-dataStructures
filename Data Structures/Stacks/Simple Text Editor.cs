using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{

    public class node
    {
        public string data;
        public node next;
        public node(string s)
        {
            data = s;
            next = null;
        }
    }

    public class linkedlist
    {
        public node headnode;

        public void push(string s)
        {
            if (headnode == null)
                headnode = new node(s);
            else
            {
                node temp = new node(s);
                temp.next = headnode;
                headnode = temp;
            }
        }

        public string undo()
        {
            node temp = headnode;
            headnode = temp.next;
            return temp.data;
        }

    }

    class operations
    {
        public string append(string s1, string s2)
        {
            return s1 + s2;
        }

        public string delete(string S, string num)
        {
            return S.Remove(S.Length - int.Parse(num));
        }

        public string print(string S, string s4)
        {
            char[] value = S.ToCharArray();
            int k = int.Parse(s4) - 1;
            return value[k].ToString();

        }
    }
    class solution
    {
        static void Main(string[] args)
        {
            operations op1 = new operations();
            linkedlist stack = new linkedlist();
            string S = null;
            Int32 input = Int32.Parse(Console.ReadLine());
            for (Int32 i = 1; i <= input; i++)
            {
                string value = Console.ReadLine();
                string[] param = value.Split(' ');
                switch (param[0])
                {
                    case "1":
                        stack.push(S);
                        S = op1.append(S, param[1]);
                        break;
                    case "2":
                        stack.push(S);
                        S = op1.delete(S, param[1]);
                        break;
                    case "3":
                        Console.WriteLine(op1.print(S, param[1]));
                        break;
                    case "4":
                        S = stack.undo();
                        break;
                }

            }
            //Console.ReadKey();

        }
    }

}
