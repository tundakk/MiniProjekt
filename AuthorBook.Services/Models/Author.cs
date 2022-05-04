namespace AuthorBook.Services.Models
{
    public class Author
    {
        //navngivning for EF - skal hedder id, ID eller Id eller classname+id
        public int AuthorId { get; set; } //PK
        public string Name { get; set; }
        public int Age { get; set; }
        public string Password { get; set; }
        public bool IsAlive { get; set; }

    }
}
