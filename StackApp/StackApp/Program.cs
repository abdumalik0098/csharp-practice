using System;

namespace StackApp
{
    class Program
    {
       

        public static void Push(ref int[] arr, ref int ind, int val)
        {
            if (ind == arr.Length-1)
            {
                Console.WriteLine("Stack over flow");
            }
            else
            {
                arr[ind] = val;
                Console.WriteLine(arr[ind]);
                ind = ind + 1;
            }
        }
        public static void Pop(ref int[] arr, ref int ind)
        {
            if (ind == 0)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                ind = ind - 1;
                Console.WriteLine(arr[ind]);
            }
        }
        static void Main(string[] args)
        {
            int[] stk = new int[10];
            int ind = 0;
            Push(ref stk,ref ind, 23);
            Push(ref stk, ref ind, 3);
            Push(ref stk, ref ind, 73);
            Push(ref stk, ref ind, 54);
            Push(ref stk, ref ind, 8);
            Push(ref stk, ref ind, 573);
            Push(ref stk, ref ind, 753);
            Push(ref stk, ref ind, 658);
            Pop(ref stk, ref ind);
            Pop(ref stk, ref ind);
            Pop(ref stk, ref ind);
            Pop(ref stk, ref ind);
            Pop(ref stk, ref ind);

        }
    }
}
