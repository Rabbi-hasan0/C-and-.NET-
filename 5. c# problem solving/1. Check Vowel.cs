using System;
using System.Collections;
using System.Diagnostics;
using System.Linq;
class Program
{
    public static void Main(String[] args)
    {
        
        char[] arr = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
        foreach (char c in arr) {
            Console.Write(c + " = ");
            switch(c) {
                case 'a':
                    Console.WriteLine("Vowel");
                    break;
                case 'e':
                    Console.WriteLine("Vowel");
                    break;
                case 'i':
                    Console.WriteLine("Vowel");
                    break;
                case 'o':
                    Console.WriteLine("Vowel");
                    break;
                case 'u':
                    Console.WriteLine("Vowel");
                    break;
                default:
                    Console.WriteLine("Consonant");
                    break;
            }
                
                
        } Console.WriteLine();
    }
}
