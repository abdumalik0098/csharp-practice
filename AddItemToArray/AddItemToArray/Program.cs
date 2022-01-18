using System;

namespace AddItemToArray
{
    class Program
    {
        static void InsertItem(ref int[] array, int value, int index)
        {
            int[] newArr = new int[array.Length + 1];
            newArr[index] = value;

            for (int i = 0; i < index; i++)
                newArr[i] = array[i];

            for (int i = index; i < array.Length; i++)
                newArr[i + 1] = array[i];

            array = newArr;
            Print(ref array);
        }

        static void DelItem(ref int[] array,int index)
        {
            int[] newArr = new int[array.Length - 1];

            for (int i = 0; i < index; i++)
                newArr[i] = array[i];

            for (int i = index; i < newArr.Length; i++)
                newArr[i] = array[i+1];

            array = newArr;
            Print(ref array);
        }

        static void AddFirst(ref int[] arr, int value)
        {
            InsertItem(ref arr, value, 0);
        }
        static void AddLast(ref int[] arr, int value)
        {
            InsertItem(ref arr, value, arr.Length);
        }

        static void Print(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] mylist = { 12, 4, 9, 10 };
            Print(ref mylist);

            InsertItem(ref mylist, 98, 2);
            AddFirst(ref mylist, 36);
            AddLast(ref mylist, 201);
            DelItem(ref mylist, 3);

        }
    }
}
