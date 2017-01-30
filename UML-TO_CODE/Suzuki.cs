using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_TO_CODE
{
    class Suzuki : Car
    {
        private string model;
        private string company = "Suzuki";
        private int speed;
        public override string Company
        {
             get { 
                return company;
            }
        }
        public override string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }



        public override int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }

    }
}
