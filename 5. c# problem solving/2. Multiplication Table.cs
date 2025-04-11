using System;
using System.Collections;
using System.Diagnostics;
using System.Linq;
class Program
{
    public static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] a = new int[]; 
        int i = 1;
        do {
            Console.WriteLine($"{n} * {i} = {n * i}");
            a[i - 1] = n * i;
            ++i;
        } while(i <= 10);

        for(i = 0; i < 10; ++i) {
            Console.WriteLine($"{n} * {i + 1} = {a[i]}");
        }


    }
}
