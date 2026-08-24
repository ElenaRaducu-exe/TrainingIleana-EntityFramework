using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations; 
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorApp_EFCore_CodeFirstStrategy.Models
{
    public class Autor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string FullName { get; set; }

        public virtual ICollection<Book> Books { get; set; } = new List<Book>();
    }
}
