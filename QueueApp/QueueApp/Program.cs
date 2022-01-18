using System;

namespace QueueApp
{
    class Program
    {
        public static int[] myque = new int[10];
        public static int next = 0;
        public static int last = 0;
        public static void Enqueue(int val)
        {
            if ((next+1) % myque.Length == last)
            {
                Console.WriteLine("Stop");
            }
            else
            {
                myque[next] = val;
                Console.WriteLine(myque[next]);
                next = (next + 1) % myque.Length;
                Console.WriteLine(next);
            }
        }
        public static int Dequeue()
        {
            int val;
            if (next == last)
            {
                Console.WriteLine("Stop 2");
                return 0;
            }
            val = myque[last];
            last = (last + 1) % myque.Length;
            Console.WriteLine(val);
            return val;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Queue App");
            Enqueue(12);
            Enqueue(13);
            Enqueue(14);
            Enqueue(14);
            Enqueue(14);
            Enqueue(14);
            Enqueue(14);
            Enqueue(14);
            Enqueue(14);
            //Enqueue(14); //stop
            Dequeue();
            Dequeue();
        }
    }
}
