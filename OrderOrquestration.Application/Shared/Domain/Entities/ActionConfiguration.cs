using System.ComponentModel.DataAnnotations.Schema;

namespace OrderOrquestration.Application.Shared.Domain.Entities
{
    public class ActionConfiguration
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
