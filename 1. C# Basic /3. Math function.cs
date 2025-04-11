// class Thirteen{
//     public static void Main(String [] args) {
//         int x = int.Parse(Console.ReadLine());
//         int y = int.Parse(Console.ReadLine());
//         int mx = Math.Max(x, y);
//         int mn = Math.Min(x, y);
//         int sqr = Convert.ToInt32(Math.Sqrt(mx + mn));
//         Console.WriteLine($"{mx} {mn} {sqr}");
//     }
// }
class Thirteen
{
    public static void Main(string[] args)
    {
        bool isValidX = int.TryParse(Console.ReadLine(), out int x);
        bool isValidY = int.TryParse(Console.ReadLine(), out int y);

        if (!isValidX || !isValidY)
        {
            Console.WriteLine("Invalid input. Please enter valid integers.");
            return;
        }

        int mx = Math.Max(x, y);
        int mn = Math.Min(x, y);
        int sqr = Convert.ToInt32(Math.Sqrt(mx + mn));

        Console.WriteLine($"Max: {mx}, Min: {mn}, Square Root: {sqr}");
    }
}
