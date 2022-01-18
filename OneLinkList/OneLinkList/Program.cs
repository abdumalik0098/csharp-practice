using System;

namespace OneLinkList
{
    class Program
    {
        static void Insert(ref int [] data, ref int [] next, int k, int p)
        {
            Array.Resize(ref data, data.Length+1);
            Array.Resize(ref next, next.Length+1);
            int len = data.Length-1;

            data[len] = k;
            next[p-1] = len;
            next[len] = p;

            Print(ref data, ref next);
        }
        static void AddLast(ref int [] data, ref int [] next, int k)
        {
            Array.Resize(ref data, data.Length+1);
            Array.Resize(ref next, next.Length+1);
            int len = data.Length-1;

            data[len] = k;
            for (int i = 0; i < next.Length; i++)
                if (next[i] == -1)
                    next[i] = len;
            next[len] = -1;

            Print(ref data, ref next);
        }
        static void AddFirst(ref int [] data, ref int [] next, ref int [] head, int k)
        {
            Array.Resize(ref data, data.Length+1);
            Array.Resize(ref next, next.Length+1);
            int len = data.Length-1;
            data[len] = k;
           // int tp = len;

            for (int i = 0; i < next.Length; i++)
            {
                if (next[i] == head[0])
                {
                    next[len] = head[0];
                    head[0] = len;
                }

            }

            

            Print(ref data, ref next);
        }
        static void Delete(ref int [] next, int p)
        {
            next[p-1] = p+1;
            next[p] = -2;
        }



        static void Print(ref int [] data, ref int[] next)
        {
            int k = 0;
            int d = 0;
            Console.WriteLine("\ndata: ");
            foreach (int item in data)
            {
                Console.Write($"Ind={k++}:"+item + " ");
            }
            Console.WriteLine("\nnext: ");
            foreach (int item in next)
            {
                Console.Write($"Ind={d++}:" + item + " ");
            }
            Console.WriteLine("\n\t\t**********************");
        }
        static void Main(string[] args)
        {
            int[] head = { 0 };
            int[] data = { 52, 23, -7, 6, 87 };
            int[] next = { 1, 2, 3, 4, -1 };
            Insert(ref data, ref next, 71, 2);
            AddLast(ref data, ref next, 43);
            AddFirst(ref data, ref next, ref head, 15);
            
            Delete(ref next, 3);
           
        }
    }
}
