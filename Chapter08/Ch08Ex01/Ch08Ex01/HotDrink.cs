using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch08Ex01
{
    abstract class HotDrink
    {
        public string Milk { get; set; }
        public string Sugar { get; set; }

        public void Drink() { }
        public void AddMilk() { }
        public void AddSugar() { }
    }
}
