using System.Text.Json.Serialization;

namespace BookAuthorRelationshipOneToManyAPI.Entities
{
    public class Author
    {
        public Guid Id { get; set; }

        public required string Name { get; set; }

        [JsonIgnore]

        public List<Book>? Books { get; set; }

    }
}
