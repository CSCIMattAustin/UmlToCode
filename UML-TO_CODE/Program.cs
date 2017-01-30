using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_TO_CODE
{
    class Program
    {
        static void Main(string[] args)
        {
            CarAssembler assemble = new CarAssembler();
            CarFactory factory = null;
            Console.WriteLine("Welcome to the Car Assembler");
            Console.WriteLine("Please choose one of the following options for car type:");
            Console.WriteLine("Toyota\nSuzuki\nquit");
            string car_choice = Console.ReadLine();
            if (car_choice == "Toyota")
            {
                Console.WriteLine("What model is your car?");
                string model = Console.ReadLine();
                Console.WriteLine("What is the top speed of your car?");
                string temp_top_speed = Console.ReadLine();
                int top_speed = Convert.ToInt32(temp_top_speed);
                factory = new ToyotaFactory(model, top_speed);
                assemble.AssemblerCar(factory);
            }
            else if (car_choice == "Suzuki")
            {
                Console.WriteLine("What model is your car?");
                string model = Console.ReadLine();
                Console.WriteLine("What is the top speed of your car?");
                string temp_top_speed = Console.ReadLine();
                int top_speed = Convert.ToInt32(temp_top_speed);
                factory = new SuzukiFactory(model, top_speed);
                assemble.AssemblerCar(factory);
            }
            Console.ReadKey();
        }
    }
}
