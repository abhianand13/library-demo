using LibraryDemo.ServiceRepository.LibraryService;
using System.Collections.Generic;
using System.ComponentModel.Composition;

namespace LibraryDemo.ServiceRepository
{
    [Export(typeof(IServiceRepository))]
    public class ServiceRepository : IServiceRepository
    {
        public List<BookDTO> GetAllBooks()
        {
            List<BookDTO> booksList = new List<BookDTO>();
            using (LibraryServiceClient client = new LibraryServiceClient())
            {
                booksList = client.GetAllBooks();
            }
            return booksList;
        }
    }
}
