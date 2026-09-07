using System;

namespace DataAccess.DTOs
{
    public class BookDTO
    {
        public int BookId { get; set; }
        public string Isbn { get; set; }
        public DateTime PublicationDate { get; set; }
        public int CategoryId { get; set; }
        public string AuthorName { get; set; }
    }
}