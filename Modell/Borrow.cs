using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modell
{
    public class Borrow : Base
    {
        public Sub PersonSub { get; set; }
        public Book BookName { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime ReturnDate { get; set; }

    }
}
