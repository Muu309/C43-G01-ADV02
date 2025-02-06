using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Quic;
using System.Text;
using System.Threading.Tasks;

namespace ADV02
{
    internal class Helper
    {
        public static Queue<T> ReverseQueue<T>(Queue<T> queue)
        {
            Stack<T> Tempstack = new Stack<T>();
            while (queue.Count > 0)
            {
                Tempstack.Push(queue.Dequeue());

            }
            while (Tempstack.Count > 0)
            {
                queue.Enqueue(Tempstack.Pop());
            }

            return queue;
        }

        public static bool Pair(char open, char close)
        {
            if (open == '(' || close == ')')
            {
                return true;
            }
            if (open == '[' || close == ']')
            {
                return true;
            }
            if (open == '{' || close == '}')
            {
                return true;
            }
            return false;
        }

        public static bool Balanced(string str)
        {
            Stack<char> stack = new Stack<char>();
            int lenght = str.Length;

            for (int i = 0; i < lenght; i++)
            {
                if (str[i] == '(' || str[i] == '[' || str[i] == '{')
                {
                    stack.Push(str[i]);
                }
                else if (str[i] == ')' || str[i] == ']' || str[i] == '}')
                {
                    if (stack.Count == 0 || !Pair(stack.Peek(), str[i]))
                    {
                        return false;
                    }
                    else
                    {
                        stack.Pop();
                    }
                }
            }

            return stack.Count == 0 ? true : false;

        }

        public static int[] RemoveDuplicates(int[] arr)
        {
            List<int> uniqe = new List<int>();
            foreach (int i in arr)
            {
                if (!uniqe.Contains(i))
                {
                    uniqe.Add(i);
                }
            }
            return uniqe.ToArray();

        }

        public static int[] RemoveOddNums(int[] arr)
        {
            List<int> evenlist = new List<int>();
            foreach (int i in arr)
            {
                if (i % 2 == 0)
                {
                    evenlist.Add(i);
                }
            }
            return evenlist.ToArray();
        }

        public static void Target(Stack<int> stack, int target)
        {
            bool flag = false;
            int count = 0;

            foreach (int i in stack)
            {
                if (i == target)
                {
                    flag = true;
                    break;
                }
                count++;
            }
            if (flag)
            {
                Console.WriteLine($"Target is found and count is {count}");
            }
            else
            {
                Console.WriteLine("Target Not Found");
            }
        }
    }
}
