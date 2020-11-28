using System.ComponentModel.DataAnnotations;

namespace ServiceA.Domain
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
