using System.ComponentModel.DataAnnotations.Schema;

namespace OrderOrquestration.Application.Shared.Domain.Entities
{
    public class ItemConfiguration
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Product { get; set; }
        public int ActionId { get; set; }
    }
}
