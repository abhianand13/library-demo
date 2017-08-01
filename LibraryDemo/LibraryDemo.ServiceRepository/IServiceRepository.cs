using LibraryDemo.ServiceRepository.LibraryService;
using System.Collections.Generic;

namespace LibraryDemo.ServiceRepository
{
    public interface IServiceRepository
    {
        List<BookDTO> GetAllBooks();
    }
}
