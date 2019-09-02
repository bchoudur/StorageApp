using System.ComponentModel.DataAnnotations;

namespace StorageApp.Core.Models
{
    class BaseEntity : IBaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
