using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modell
{
    public class Book : Base
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Pages { get; set; }
        public Genre Genres { get; set; }
        public Language Languages { get; set; }
        public bool IsAvailable { get; set; }
        public override string ToString()
        {
            return $"{this.Title} {this.Author} {this.ReleaseDate} {this.Pages} {this.Genres} {this.Languages} {this.IsAvailable}";
        }
    }
}
