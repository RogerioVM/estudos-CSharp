using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch08Ex01
{
    interface ICup
    {
        string Color { get; }
        int Volume { get;}
        public void Wash();
        public void Refill();
    }
}
