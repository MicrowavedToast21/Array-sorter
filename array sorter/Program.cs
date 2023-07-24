//```cs
using System;

public class ArraySorter 
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of elements in the array: ");
        int n = int.Parse(Console.ReadLine());

        int[] a = new int[n];
        int t;

        Console.WriteLine("Enter the actual elements(numbers) of the array: ");
        for (int i = 0; i < n; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }

            
        Console.WriteLine("Unsorted array:");
        foreach (int aa in a)
        {
            Console.Write(aa + " ");
        }

        bool swapped;
        do
        {
            swapped = false;
            for (int i = 0; i <= a.Length - 2; i++)
            {
                if (a[i] > a[i + 1])
                {
                    t = a[i + 1];
                    a[i + 1] = a[i];
                    a[i] = t;
                    swapped = true;
                }
            }
        }
        while (swapped);
        Console.Write("\n" + "Sorted array :");
        foreach(int aa in a)
            Console.Write(aa + " ");
        Console.Write("\n");
    }
}
//```cs
