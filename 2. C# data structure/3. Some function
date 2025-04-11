using System;
using System.Linq;  
/*
আমরা ব্যবহার করি কারণ LINQ (Language Integrated Query) এর মেথডগুলো এই namespace-এর ভেতরে থাকে।

যেমন: Max(), Min(), OrderBy(), OrderByDescending(), Where(), Select()

এইসব মেথড ব্যবহার করতে চাইলে অবশ্যই using System.Linq; উপরে লিখতে হবে। যদি না লেখো তাহলে numbers.Max() 
এই লাইনে কম্পাইলার error দিবে, কারণ Max() মেথডটা কোথা থেকে আসছে সেটা সে চিনতে পারবে না।
*/
class Thirteen{
    public static void Main(String [] args) {
/*-------------------------------------------------*/
        int[] a = {40, 20, 35, 10};
/*-------------------------------------------------*/
       // Sort array
        Array.Sort(a); //Sorts the array in ascending order
        Array.Reverse(a); //Reverses the array
        int mx = a.Max();
        int mn = a.Min();
        int sum = a.Sum();
        var sortedDesc = a.OrderByDescending(n => n); // sort by descending order
        // ekahne (var) bolte c++ er [auto] er moto kaj kore
        var sortedAsc = a.OrderBy(n => n); // sort by ascending order

        // evenNumbers er moddhe jodi 2 diye bhag hoy taile se take dhore rakhbe, na hole dhore rakhbe na.
        var evenNumbers = a.Where(n => n % 2 == 0);
        
        foreach(int i in evenNumbers) {
            Console.Write(i + " ");
        } Console.WriteLine();
/*-------------------------------------------------*/
    }
}
