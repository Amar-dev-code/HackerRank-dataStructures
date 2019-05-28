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



    static void Main(string[] args)
    {
        string[] nd = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nd[0]);

        int d = Convert.ToInt32(nd[1]);

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
        ;
        int val = n - d;
        int[] b = new int[n];
        int index = 0;
        for (int i = 0; i < n; i++)
        {
            if (val + i >= n)
            {
                index = (val + i) - n;
                b[index] = a[i];
            }
            else
                b[val + i] = a[i];
        }
        for (int i = 0; i < n; i++)
            Console.Write(b[i] + " ");
    }
}
