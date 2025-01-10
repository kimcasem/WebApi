using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Domain.Entities
{
    [Table("Users")]
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? EmailAddress { get; set; }
        public string? Gender { get; set; }
        public string? Birthdate {  get; set; }
        public int? Age { get; set; }
    }
}
