using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ODATA_books_test.Models
{
    public class Press
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Category Category { get; set; }
    }
}
