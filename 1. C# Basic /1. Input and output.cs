using System.Runtime.InteropServices;

public class Myclass{
    public static void Main(string [] args){
        // Take input from the user
        string s = Console.ReadLine();  
        // Print the input string to the console
        Console.WriteLine($"Name: {s}");
/*-----------------------------------------------------------------*/
        // Interger input
        int n = int.Parse(Console.ReadLine());
        // Print the integer input to the console
        Console.WriteLine($"Age: {n}");
/*-----------------------------------------------------------------*/
        // Double input
        double d = double.Parse(Console.ReadLine());
        // But for avoid carshing, we can use TryParse method
        // Firstly take input as string then convert it in double it will be safe
        string input = Console.ReadLine();
        if (double.TryParse(input, out double number)) {
            Console.WriteLine("You entered: " + number);
        }
        else {
            Console.WriteLine("Invalid number entered.");
        }
/*-----------------------------------------------------------------*/
        // Char input
        char c = Console.ReadKey().KeyChar;
        // Print the character input to the console
        Console.WriteLine($"\nCharacter: {c}");
/*-----------------------------------------------------------------*/       
    }
}
