using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_TO_CODE
{
    class CarAssembler
    {
        public void AssemblerCar(CarFactory factory)
        {
            Car newcar = factory.GetCar();
            Console.WriteLine("You chose a {0}", newcar.Model);
            Console.WriteLine("Your top speed is {0}", newcar.Speed);
        }
    }
}
