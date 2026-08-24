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
    }
}
