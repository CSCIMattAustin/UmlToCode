using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_TO_CODE
{
    abstract class Car
    {
        public abstract string Company {get;}
        public abstract string Model {get; set;}
        public abstract int Speed {get; set;}

    }
}
