using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modell
{
    public class BookList : List<Book>
    {
        public BookList() { }

        public BookList(IEnumerable<Book> list) : base(list) { }

        public BookList(IEnumerable<Base> list) : base(list.Cast<Book>().ToList()) { }

    }
}
