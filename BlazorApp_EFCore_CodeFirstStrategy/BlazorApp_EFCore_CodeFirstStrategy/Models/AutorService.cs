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

        public Autor? GetAutorByName(string name)
        {
            return AutorsList.FirstOrDefault(a => a.FullName == name); 
        }

        public Autor? GetAutorByID(int searchID)
        {
            return AutorsList.FirstOrDefault(a => a.Id == searchID); 
        }
    }
}