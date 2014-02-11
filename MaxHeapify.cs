using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MaxHeapify
{
    static void Main(string[] args)
    {
        int[] arr = { 3, 2, 6, 1, 0, 4, 7 };

        foreach (int i in arr)
            System.Console.Write(i + " ");

        for (int j = arr.Length - 1; j >= 0; j--)
        {
            Heapify(arr, j);
        }

        System.Console.WriteLine();
        foreach (int i in arr)
            System.Console.Write(i + " ");

        System.Console.Read();
    }

    public static void Heapify(int[] arr, int j)
    {
        int val = 2 * j + 1 < arr.Length ? 2 * j + 1 : -1;

        if (val != -1)
        {
            if (2 * j + 2 < arr.Length && arr[2 * j + 2] > arr[val])
                val = 2 * j + 2;

            if (arr[j] > arr[val])
                return;
            else
            {
                if (arr[j] != arr[val])
                {
                    arr[j] = arr[j] ^ arr[val];
                    arr[val] = arr[j] ^ arr[val];
                    arr[j] = arr[j] ^ arr[val];
                }

                Heapify(arr, val);
            }
        }
    }
}