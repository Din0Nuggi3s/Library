using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modell
{
    public class Genre : Base
    {
        public string GenreName { get; set; }

        public override string ToString()
        {
            return this.GenreName;
        }
    }
}
