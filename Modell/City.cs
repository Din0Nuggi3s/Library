using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modell
{
    public class City : Base
    {
        public string CityName { get; set; }
        public override string ToString()
        {
            return this.CityName;
        }
    }
}
