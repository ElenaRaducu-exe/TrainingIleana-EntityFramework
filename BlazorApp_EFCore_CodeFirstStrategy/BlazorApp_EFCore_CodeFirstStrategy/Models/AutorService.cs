using BlazorApp_EFCore_CodeFirstStrategy.Data;
using Microsoft.EntityFrameworkCore; 

namespace BlazorApp_EFCore_CodeFirstStrategy.Models
{
    public class AutorService
    {
        public AppDbContext _dbContext { get; set; }
        public List<Autor> AutorsList { get; set; } = new(); 

        public AutorService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AutorsInit()
        {
            AutorsList = await _dbContext.Autors.ToListAsync();
        }
        public async Task<List<Autor>> GetAutors()
        {
            await AutorsInit(); 
            return AutorsList; 
        }

        // in memory data filter
        public Autor? GetAutorByName(string name)
        {
            return AutorsList.FirstOrDefault(a => a.FullName == name); 
        }

        // database level data filter 
        public async Task<Autor?> GetAutorByNameAsync(string name)
        {
            return await _dbContext.Autors.FirstOrDefaultAsync(a => a.FullName == name);
        }

        public async Task<Autor> GetAutorByID(int searchID)
        {
            return _dbContext.Autors.FirstOrDefault(a => a.Id == searchID);
        }

        public async Task<List<AuthorDTO>> GetAuthorDTOs()
        {
            return await _dbContext.Autors.Select(author => new AuthorDTO
            {
                AuthorId = author.Id,
                AuthorName = author.FullName, 
                NumberBooks = author.Books.Count(), 
                BookNames = author.Books.Select(book => book.Title).ToList()
            }).ToListAsync();
        }

        public async Task RemoveAutor(int id)
        {
            var autorToDelete = await _dbContext.Autors.FirstOrDefaultAsync(author => author.Id == id);

            List<Book> booksToDelete = await _dbContext.Books.Select(book => new Book
            {
                Id = book.Id,
                Year = book.Year,
                NumberPages = book.NumberPages,
                AutorId = id, 
                Title = book.Title
            }).ToListAsync();

            if (booksToDelete.Count() > 0)
            {
                foreach(var book in booksToDelete)
                {
                    _dbContext.Books.Remove(book);
                    _dbContext.SaveChanges();
                }

                _dbContext.Autors.Remove(autorToDelete);
                _dbContext.SaveChanges();
            }
            else if (autorToDelete.Books.Count() == 0)
            {
                _dbContext.Autors.Remove(autorToDelete);
                _dbContext.SaveChanges();
            }
        }

        public async Task UpdateAutor()
        {
            _dbContext.SaveChanges(); 
        }

        public async Task<List<Autor>> GetAutorsFiltered(string filterTerm)
        {
            return await _dbContext.Autors.Where(a => a.FullName.Contains(filterTerm)).ToListAsync(); 
        }
    }
}