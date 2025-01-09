using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modell
{
    public class Sub : Person
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int PhoneNum { get; set; }
        public override string ToString()
        {
            return $" {this.UserName} {this.Email} {this.Password} {this.PhoneNum} ";
        }
    }
}
