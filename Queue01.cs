using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    //BackJoon Algorithm NO.10845
    //Queue
    internal class Queue01
    {
        static void Main(string[] args)
        {
           
            Queue<int> queue = new Queue<int>();
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                StringBuilder opt = new StringBuilder();
                string word = Console.ReadLine();
                string[] arr = word.Split(' ');
                if (arr[0] == "push")
                {
                    int a = int.Parse(arr[1]);
                    queue.Enqueue(a);
                }
                else if (arr[0] == "pop")
                {
                    if (queue.Count == 0)
                        opt.Append(-1);
                    else
                    {
                        int a = queue.Dequeue();
                        opt.Append(a);
                    }
                }
                else if (arr[0] == "size")
                {
                    opt.Append(queue.Count);
                }
                else if (arr[0] == "empty")
                {
                    if (queue.Count == 0)
                        opt.Append(1);
                    else
                        opt.Append(0);
                }
                else if (arr[0] =="front")
                {
                    if(queue.Count == 0)
                        opt.Append(-1);
                    else
                        opt.Append(queue.Peek());
                }
                else if (arr[0] == "back")
                {
                    if (queue.Count == 0)
                        opt.Append(-1);
                    else
                    {
                        int last = queue.ToArray()[queue.Count -1];
                        //Access the last element of the array
                        opt.Append(last);
                    }
                }
                if (arr[0] != "push")
                {
                    Console.WriteLine(opt.ToString());
                }
            }
        }

    }
}
