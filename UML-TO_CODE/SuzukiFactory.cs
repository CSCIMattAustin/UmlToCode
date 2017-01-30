using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_TO_CODE
{
    class SuzukiFactory : CarFactory
    {
        private string model;
        private int speed;
        public override Car GetCar()
        {
            Car suzuki = new Suzuki();
            suzuki.Model = model;
            suzuki.Speed = speed;
            return suzuki;
        }
        public SuzukiFactory(string m, int s)
        {
            model = m;
            speed = s;       

        }
        
    }
}
