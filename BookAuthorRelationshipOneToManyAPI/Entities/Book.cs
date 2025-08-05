namespace BookAuthorRelationshipOneToManyAPI.Entities
{
    public class Book
    {

        public Guid Id { get; set; }

        public required string Name { get; set; }
        
        public required string NumberofPages { get; set; }
       
        public required long Quantity { get; set; }

        public Guid AuthorId { get; set; }

        public Author? Author { get; set; }

    }
}
