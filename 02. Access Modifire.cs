using System;
using System.Linq;
namespace rabbi {
    class Vichel {
        public void Car() {    // Other calss method given must public cause Access modifire using...
            Console.WriteLine("My Car is Mercidies");
        }
    }
    class Vichel1 {
        public void Car1() {    // Other calss method given must public cause Access modifire using...
            Console.WriteLine("My Car is Mercidies");
        }
    }
    class Test {
        void Car() {
            Console.WriteLine("My car name is BMW");
        }
        string Color = "red\n";
        string Name = "Rabbi";
        public static void Main(string[] args) {
             Test cr = new Test();
             cr.Car();
             Console.WriteLine(cr.Color);
             Console.WriteLine(cr.Name);
             Vichel ob = new Vichel();
             ob.Car();
             Vichel1 ob1 = new Vichel1();
             ob1.Car1();
        }
    }
}

