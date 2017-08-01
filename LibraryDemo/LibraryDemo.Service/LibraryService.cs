using LibraryDemo.DTO;
using LibraryDemo.DAO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryDemo.Service
{
    [AutoMapServiceBehavior]
    public class LibraryService : ILibraryService
    {
        public List<BookDTO> GetAllBooks()
        {
            List<BookDTO> booksList = new List<BookDTO>();

            try
            {
                using (LibraryDemoEntities context = new LibraryDemoEntities())
                {
                    var allBooks = context.Books.Where(x => x.IsActive).ToList();
                    
                    foreach (var book in allBooks)
                    {
                        BookDTO bookDTO = new BookDTO();
                        bookDTO.Isbn = book.Isbn.Trim();
                        bookDTO.Title = book.Title.Trim();
                        bookDTO.AuthorName = book.Author.Name.Trim();
                        booksList.Add(bookDTO);
                    }
                }
            }
            catch (Exception ex)
            {
                // TODO - Implement logging
            }

            return booksList;
        }
    }
}
