using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modell
{
    public class SubList : List<Sub>
    {
        public SubList() { }

        public SubList(IEnumerable<Sub> list) : base(list) { }

        public SubList(IEnumerable<Base> list) : base(list.Cast<Sub>().ToList()) { }
    }
}
