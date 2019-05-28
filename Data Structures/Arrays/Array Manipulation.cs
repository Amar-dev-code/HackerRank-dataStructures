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

    // Complete the arrayManipulation function below.
    static long arrayManipulation(int n, int[][] queries)
    {
        int z = queries.GetLength(0);
        long[] arr = new long[n + 2];
        long maxvalue = 0;
        int j = 0;
        for (int i = 0; i < z; i++)
        {
            arr[queries[i][j]] = arr[queries[i][j]] + queries[i][j + 2];
            arr[queries[i][j + 1] + 1] = arr[queries[i][j + 1] + 1] - queries[i][j + 2];
        }
        for (int i = 1; i <= n; i++)
        {
            arr[i] = arr[i] + arr[i - 1];
            if (arr[i] > maxvalue)
                maxvalue = arr[i];
        }
        return maxvalue;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] nm = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nm[0]);

        int m = Convert.ToInt32(nm[1]);

        int[][] queries = new int[m][];

        for (int i = 0; i < m; i++)
        {
            queries[i] = Array.ConvertAll(Console.ReadLine().Split(' '), queriesTemp => Convert.ToInt32(queriesTemp));
        }

        long result = arrayManipulation(n, queries);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
