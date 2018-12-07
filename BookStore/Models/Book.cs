namespace BookStore.Models
{
    public class Book
    {
        private string _title;

        public Book(string isbn, string title, string authorName)
        {
            Isbn = isbn;
            _title = title;
            AuthorName = authorName;
        }
        public string Title{ get { return _title; }}
        public string Isbn { get; }
        public decimal Price { get; set; }
        public string AuthorName { get; set; }
    }

    public class Novel: Book
    {
        public Novel(string isbn, string title, string authorName) : base(isbn, title, authorName)
        {
                
        }
        public string Genre { get; set; }
    }
}
