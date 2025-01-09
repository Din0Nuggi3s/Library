using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modell
{
    public class Person : Base
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public DateTime Birthdate { get; set; }
        public City Cities { get; set; }
        public Country Countries { get; set; }
        public override string ToString()
        {
            return $"{this.FName} {this.LName} {this.Birthdate} {this.Cities} {this.Countries}";
        }
    }
}
