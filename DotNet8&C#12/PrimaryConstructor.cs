using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet8_C_12
{
    public class PrimaryConstructor
    {
        public class Book(int id, string title, IEnumerable<decimal> ratings)
        {
            // It's also possible to have multiple constructors, and for that, it's necessary to use the this(…) keyword (which will call the main/primary constructor);
            public Book(int id, string title) : this(id, title, Enumerable.Empty<decimal>()) { }

            public Book() : this(99, "Demo book") { }

 
            // Id and Title are are read-only, and the values will be received via Primary Constructor;
            public int Id => id;
            public string Title => title.Trim();

            // In the Pages property it will be possible to read and write value;
            public int Pages { get; set; }

            public decimal AverageRating => ratings.Any() ? ratings.Average() : 0m;
        }

        //interface for both default and primary
        public interface IBookRepository
        {
            Task<List<Book>> GetAll();
        }

        // Dependency Injection with Primary Constructor example;
        //using primary constructor where repository direct initailize in class as contructor
        public class BookService(IBookRepository bookRepository)
        {
            public async Task<IEnumerable<Book>> GetAll()
            {
                return await bookRepository.GetAll();
            }
        }

        // Default Dependency Injection example;
        public class BookServiceDefault
        {
            private readonly IBookRepository _bookRepository;

            public BookServiceDefault(IBookRepository bookRepository)
            {
                _bookRepository = bookRepository;
            }

            public async Task<IEnumerable<Book>> GetAll()
            {
                return await _bookRepository.GetAll();
            }
        }
    }
}
    

