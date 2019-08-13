using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    class node
    {
        public char data;
        public node next;
        public node(char a)
        {
            data = a;
            next = null;
        }

    }

    class linkelist
    {
        public node head;

        public void push(char s)
        {
            if (head == null)
                head = new node(s);
            else
            {
                node temp = new node(s);
                temp.next = head;
                head = temp;
            }
        }

        public string pop(char s)
        {
            string result;
            if (head == null)
                result = "NO";
            else
            {
                string chk = string.Concat(head.data, s);
                switch (chk)
                {
                    case "{}":
                        result = "YES";
                        break;

                    case "[]":
                        result = "YES";
                        break;

                    case "()":
                        result = "YES";
                        break;

                    default:
                        result = "NO";
                        break;

                }
                head = head.next;
            }
            return result;

        }

    }
    static string isBalanced(string s)
    {
        linkelist listval = new linkelist();
        string result = null;
        char[] val = s.ToCharArray();
        int length = s.Length;
        int count = 0;
        for (int i = 0; i < length; i++)
        {
            switch (val[i])
            {
                case '{':
                    listval.push(val[i]);
                    break;
                case '[':
                    listval.push(val[i]);
                    break;
                case '(':
                    listval.push(val[i]);
                    break;
                case '}':
                    result = listval.pop(val[i]);
                    count++;
                    break;
                case ']':
                    result = listval.pop(val[i]);
                    count++;
                    break;
                case ')':
                    result = listval.pop(val[i]);
                    count++;
                    break;
            }
            if (result == "NO")
                break;
        }
        if (count == 0)
            result = "NO";
        return result;
    }

    static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++)
        {
            string s = Console.ReadLine();

            string result = isBalanced(s);

            Console.WriteLine(result);
        }

        //textWriter.Flush();
        //textWriter.Close();
    }
}
