using System.ComponentModel.DataAnnotations; 
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp_EFCore_CodeFirstStrategy.Models
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {  get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public int NumberPages { get; set; }

        public int? AutorId { get; set; }    
        public virtual Autor? autor { get; set; }
    }
}
