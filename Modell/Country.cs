using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modell
{
    public class Country : Base
    {
        public string CountryName { get; set; }
        public override string ToString()
        {
            return this.CountryName;
        }
    }
}
