using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqJoinFirstPractice
{
    public class Author
    {

        public string Name { get; set; }
        public int AuthorId { get; set; }
    }

    public class Book
    {
        public int BookId { get; set; }

        public string Title { get; set; }

        public int AuthorId { get; set; }
    }
}
