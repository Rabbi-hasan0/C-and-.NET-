using System;
using System.Linq;
namespace rabbi {
    class Test {
        void Car() {
            Console.WriteLine("My car name is BMW\n");
        }
        string Color = "red";
        public static void Main(string[] args) {
             Test cr = new Test();
             cr.Car();
             Console.WriteLine(cr.Color);
        }
    }
}
