public class Myclass{
    public static void Main(string [] args){
        string s = "10";
        double t = 10.5;
        int x = (int)(t); // Double to in korer time e eivabe hoi but string er time e hoi na
        int y = Convert.ToInt32(s);
        // int y = int.Parse(s);
        System.Console.WriteLine($"Sum = {x + y}");
    }
}
