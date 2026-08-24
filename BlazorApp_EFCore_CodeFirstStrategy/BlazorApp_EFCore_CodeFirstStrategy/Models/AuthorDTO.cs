namespace BlazorApp_EFCore_CodeFirstStrategy.Models
{
    public class AuthorDTO
    {
        public int AuthorId {  get; set; }
        public string AuthorName { get; set; }
        public int NumberBooks { get; set; }
        public List<string> BookNames { get; set; }
    }
}
