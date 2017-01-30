using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_TO_CODE
{
    class ToyotaFactory : CarFactory
    {
        private string model;
        private int speed;
        public override Car GetCar()
        {
            Car toyota = new Suzuki();
            toyota.Model = model;
            toyota.Speed = speed;
            return toyota;
        }
        public ToyotaFactory(string m, int s)
        {
            model = m;
            speed = s;

        }
    }
}
