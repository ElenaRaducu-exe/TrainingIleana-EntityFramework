using BlazorApp_EFCore_CodeFirstStrategy.Data;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp_EFCore_CodeFirstStrategy.Models
{
    public class BookService
    {
        public AppDbContext DbContext { get; set; }
        public List<Book> BooksList { get; set; } = new(); 

        public BookService(AppDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public async Task<List<Book>> GetBooks()
        {
            BooksList = await DbContext.Books.ToListAsync();
            return BooksList;
        }

        public async Task<Book?> GetBookByIdAsync(int searchId)
        {
            return await DbContext.Books.FirstOrDefaultAsync(b => b.Id == searchId);
        }

        public async Task<List<BookDTO>> GetBookDTOs()
        {
            return await DbContext.Books.Select(book => new BookDTO
            {
                Id = book.Id,
                Title = book.Title,
                Year = book.Year,
                NumberPages = book.NumberPages,
                AutorName = book.autor.FullName
            }).ToListAsync(); 
        }

        public async Task<BookDTO?> GetBookDTOByIdAsync(int searchId)
        {
            return await DbContext.Books.Select(book => new BookDTO
            {
                Id = book.Id,
                Title = book.Title,
                Year = book.Year,
                NumberPages = book.NumberPages,
                AutorName = book.autor.FullName
            }).FirstOrDefaultAsync(b => b.Id == searchId);
        }

        public async Task RemoveBook(int id)
        {
            var bookToDetele = await DbContext.Books.FirstOrDefaultAsync(book => book.Id == id);
            DbContext.Books.Remove(bookToDetele);
            DbContext.SaveChanges();
        }

        public async Task UpdateBook()
        {
            DbContext.SaveChanges();
        }
    }
}
