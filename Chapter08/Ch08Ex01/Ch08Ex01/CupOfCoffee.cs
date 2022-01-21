using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch08Ex01
{
    class CupOfCoffee : HotDrink, ICup
    {

        public string BeanType;

        string ICup.Color => "Red";

        int ICup.Volume => 1;

        public void Refill() { }
        public void Wash() { }
    }
}
