using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarInventory
{
    class Car
    {
        public string year, make, colour, milage;

            public Car(string _year, string _make, string _colour, string _milage)
        {
            year = _year;
            make = _make;
            colour = _colour;
            milage = _milage;
        }
    }
}
