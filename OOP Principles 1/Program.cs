using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Principles_1
{
    class Program
    {
        //5. Write a test class which constructs a Car and prints its details to the console.
        static void Main(string[] args)
        {
            Car car = new Car("Honda", "Accord", "Registration", 2015, 20000);
            Console.WriteLine(car);
        }
    }
}
