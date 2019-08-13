using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{

    /*
     * Complete the equalStacks function below.
     */
    static int equalStacks(int[] h1, int[] h2, int[] h3)
    {

        int height1 = h1.Sum();
        int height2 = h2.Sum();
        int height3 = h3.Sum();
        int[] Allheights = { height1, height2, height3 };
        int maxheight = Allheights.Min();
        Stack<int> stack1 = new Stack<int>(h1.Length);
        for (int i = (h1.Length) - 1; i >= 0; i--)
        {
            stack1.Push(h1[i]);
        }
        Stack<int> stack2 = new Stack<int>(h2.Length);
        for (int i = (h2.Length) - 1; i >= 0; i--)
        {
            stack2.Push(h2[i]);
        }
        Stack<int> stack3 = new Stack<int>(h3.Length);
        for (int i = (h3.Length) - 1; i >= 0; i--)
        {
            stack3.Push(h3[i]);
        }
        while (height1 != height2 || height1 != height3 || height2 != height3)
        {
            while (height1 > maxheight)
            {

                height1 = height1 - stack1.Pop();
            }
            while (height2 > maxheight)
            {

                height2 = height2 - stack2.Pop();
            }
            while (height3 > maxheight)
            {
                height3 = height3 - stack3.Pop();
            }
            int[] chk = { height1, height2, height3 };
            maxheight = chk.Min();
        }

        return maxheight;
    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] n1N2N3 = Console.ReadLine().Split(' ');

        int n1 = Convert.ToInt32(n1N2N3[0]);

        int n2 = Convert.ToInt32(n1N2N3[1]);

        int n3 = Convert.ToInt32(n1N2N3[2]);

        int[] h1 = Array.ConvertAll(Console.ReadLine().Split(' '), h1Temp => Convert.ToInt32(h1Temp))
        ;

        int[] h2 = Array.ConvertAll(Console.ReadLine().Split(' '), h2Temp => Convert.ToInt32(h2Temp))
        ;

        int[] h3 = Array.ConvertAll(Console.ReadLine().Split(' '), h3Temp => Convert.ToInt32(h3Temp))
        ;
        int result = equalStacks(h1, h2, h3);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
