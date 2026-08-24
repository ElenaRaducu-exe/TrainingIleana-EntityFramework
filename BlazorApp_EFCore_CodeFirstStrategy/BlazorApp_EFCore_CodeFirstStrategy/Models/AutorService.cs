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

        public Autor? GetAutorByID(int searchID)
        {
            return AutorsList.FirstOrDefault(a => a.Id == searchID); 
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
    }
}