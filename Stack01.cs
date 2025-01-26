using System.Diagnostics.Tracing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                StringBuilder sb = new StringBuilder();
                // StringBuilder is used for efficiently modifying strings by reducing memory allocation overhead, especially in cases of frequent concatenation or manipulation.
                string word = Console.ReadLine();
                string[] tok = word.Split(' '); //speratied

                if (tok[0] == "push")
                //For strings, it checks if the specified substring exists in the string.
                {
                    int b = int.Parse(tok[1]);
                    stack.Push(b);
                }
                else if (tok[0] == "pop")
                {
                    if (stack.Count == 0)
                    {
                        sb.Append(-1);
                    }
                    else
                    {
                        sb.Append(stack.Pop());
                    }
                }
                else if (tok[0] == "size")
                    sb.Append(stack.Count);
                else if (tok[0] == "empty")
                {
                    int empty = (stack.Count > 0) ? 0 : 1;
                    sb.Append(empty);
                }
                else if (word.Contains("top"))
                {
                    if (stack.Count == 0)
                        sb.Append(-1);
                    else
                    {
                        sb.Append(stack.Peek());
                    }
                }
                if (tok[0] != "push")
                    Console.WriteLine(sb.ToString());
            }
        }
    }
}
