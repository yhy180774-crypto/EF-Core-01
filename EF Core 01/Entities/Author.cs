using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_01.Entities
{
  
        public class Author
        {
            public int AuthorId { get; set; }

            public string FirstName { get; set; }

            public string LastName { get; set; }

            public string Email { get; set; }

            public string Biography { get; set; }

            public DateTime DateOfBirth { get; set; }

            public ICollection<Book> Books { get; set; }
        }
    }

