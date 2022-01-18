using System;

namespace BinarySTreeArrays
{
    class Program
    {

        public static int[] key = { 0, 1, 2, 3 };
        public static int[] value = { 50, 20, 60, 70 };
        public static int[] left = { 1, -1, -1, -1 };
        public static int[] right = { 2, -1, 3, -1 };
        public static int[] p = { -1, 0, 0, 2 };
        public static int x = 0;
        
        static void InsertNode(int k)
        {
            Array.Resize(ref key, key.Length + 1);
            Array.Resize(ref value, value.Length + 1);
            Array.Resize(ref left, left.Length + 1);
            Array.Resize(ref right, right.Length + 1);
            Array.Resize(ref p, p.Length + 1);

            int len = value.Length - 1;

            key[len] = len;
            value[len] = k;
            left[len] = -1;
            right[len] = -1;

            for (int i = 0; i < len; i++)
            {
                if (value[len] < value[i])
                {
                    if (left[i] == -1)
                    {
                        p[len] = i;
                        left[i] = len;
                        break;
                    }
                }
                if (value[len] > value[i])
                {
                    if (right[i] == -1)
                    {
                        p[len] = i;
                        right[i] = len;
                        break;
                    }
                }
            }

        }
        static void DeleteNode(int k)
        {

            int pr = p[k];

            if (left[k] == -1 && right[k]==-1)  // 1
            {
                if (left[pr]==k)
                {
                    left[pr] = -1;
                }
                else if (right[pr] == k)
                {
                    right[pr] = -1;
                }
            }

            else if(left[k] == -1 || right[k] == -1) // 2
            {
                if (left[k] == -1)
                {
                    if (left[pr] == k)
                    {
                        left[pr] = right[k];
                    }
                    else 
                    {
                        right[pr] = right[k]; 
                    }
                    p[right[k]] = pr;
                }
                else
                {
                    if (left[pr] == k)
                    {
                        left[pr] = left[k];
                    }
                    else
                    {
                        right[pr] = left[k];
                    }
                    p[left[k]] = pr;
                }
            }

            key[k] = -2;
            value[k] = -2;
            left[k] = -2;
            right[k] = -2;
            p[k] = -2;

        }

        /*    static int Search(ref int [] key, ref int[] value, ref int[] left, ref int[] right, int k)
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (value[i] == k)
                    {
                        return value[i];
                    }
                    else if (k < value[i])
                        return Search(ref key, ref value, ref  left[i],ref  right, k);
                    else if (k > value[i])
                        return Search(right[i], k);
                }

            }*/


       static int Walk(int x)
        {
            if (x != -1)
            {
               
                Walk(right[x]);
                Console.WriteLine($"Key:{key[x]}, Value:{value[x]}");
                Walk(left[x]);
            }
         
            return x;
        }


    static void Print()
        {
            Console.WriteLine("\t\t*******************");
            for (int i = 0; i < value.Length; i++)
            {
                Console.WriteLine($"Key:{key[i]}, Value:{value[i]}, Left:{left[i]}, Right:{right[i]}, Parent:{p[i]}");
            }
        }

        static void Main(string[] args)
        {

           // InsertNode(10);
           // Print();

            //InsertNode(ref key, ref value, ref left, ref right, ref p, 30);
            //InsertNode(ref key, ref value, ref left, ref right, ref p, 90);
            //InsertNode(ref key, ref value, ref left, ref right, ref p, 55);

            Walk(x);

           // DeleteNode(2);
           // Print();



        }
    }
}
