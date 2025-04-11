using System;
using System.Linq;
class Program
{
    public static void Main(String[] args)
    {
        /* 
        Take integer array as input:
                5
                1 2 3 4 5
        */
        int size = int.Parse(Console.ReadLine());

        int[] a = Console.ReadLine()
                           .Split(' ')
                           .Select(int.Parse)
                           .ToArray();

        foreach (int i in a) {
            Console.Write(i + " ");
        } Console.WriteLine();
/*--------------------------------------------------------*/    
        /* Take string array as input:
                5
                1 2 3 4 5
        */
        int len = int.Parse(Console.ReadLine());

        string[] str = Console.ReadLine().Split(' ');

        foreach (string s in str) {
            Console.Write(s + " ");
        } Console.WriteLine(); 
/*--------------------------------------------------------*/ 
        
        char[] arr = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
        foreach (char c in arr) {
            Console.Write(c + " ");
            if(c >= 'A' && c <= 'Z') {
                Console.WriteLine("Upper");
            } else {
                Console.WriteLine("Lower");
            }
        } Console.WriteLine();
    }
}
