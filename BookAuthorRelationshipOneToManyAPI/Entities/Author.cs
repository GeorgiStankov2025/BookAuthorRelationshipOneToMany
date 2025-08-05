namespace BookAuthorRelationshipOneToManyAPI.Entities
{
    public class Author
    {
        public Guid Id { get; set; }

        public required string Name { get; set; }

        public List<Book>? Books { get; set; }

    }
}
