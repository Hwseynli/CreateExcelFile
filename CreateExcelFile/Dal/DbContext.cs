using CreateExcelFile.Models;

namespace CreateExcelFile.Dal
{
    public class DbContext
    {
        public List<Person> People { get; set;}
        public DbContext()
        {
            // Person listini burada yarada bilərik
            People = new List<Person>
            {
                new Person { ID = 1, FirstName = "Salam", LastName = "Sagol", FatherName = "Salamat", Birthday = new DateTime(2001, 1, 11) },
                new Person { ID = 2, FirstName = "Salam2", LastName = "Sagol2", FatherName = "Salamat2", Birthday = new DateTime(2002, 2, 12) },
                new Person { ID = 3, FirstName = "Salam3", LastName = "Sagol3", FatherName = "Salamat3", Birthday = new DateTime(2003, 3, 13) },
                new Person { ID = 4, FirstName = "Salam4", LastName = "Sagol4", FatherName = "Salamat4", Birthday = new DateTime(2004, 4, 14) },
                new Person { ID = 5, FirstName = "Salam5", LastName = "Sagol5", FatherName = "Salamat5", Birthday = new DateTime(2005, 5, 15) },
                new Person { ID = 3, FirstName = "Salam6", LastName = "Sagol6", FatherName = "Salamat6", Birthday = new DateTime(2006, 6, 16) },
            };
        }
    }
}

