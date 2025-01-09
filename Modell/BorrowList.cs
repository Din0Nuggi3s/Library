using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modell
{
    public class BorrowList : List<Borrow>
    {
        public BorrowList() { }

        public BorrowList(IEnumerable<Borrow> list) : base(list) { }

        public BorrowList(IEnumerable<Base> list) : base(list.Cast<Borrow>().ToList()) { }
    }
}
