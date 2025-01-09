using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modell
{
    public class GenreList : List<Genre>
    {
        public GenreList() { }

        public GenreList(IEnumerable<Genre> list) : base(list) { }

        public GenreList(IEnumerable<Base> list) : base(list.Cast<Genre>().ToList()) { }
    }
}
