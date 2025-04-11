using System;
using System.Collections;
using System.Diagnostics;
using System.Linq;
class Program
{
    public static void Main(String[] args)
    {
        int[,] numbers = { {1, 4, 2}, {3, 6, 8} };
        for (int i = 0; i < 2; ++i) {
            for(int j = 0; j < 3; ++j) {
                Console.Write(numbers[i, j] + " ");
            } Console.WriteLine();
        } 
    }
}
