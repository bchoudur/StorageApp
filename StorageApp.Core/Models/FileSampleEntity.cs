using System;
using System.ComponentModel.DataAnnotations;

namespace StorageApp.Core.Models
{
    /**
    NOTE: This is file is just for testing to make sure all the depencencies are working and that the main architecture is setup correctly and that every can communicate. I realize that the actual
    file model will be much more complex then this.
    */

    public class FileSampleEntity : IBaseEntity
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(255), Required]
        public string FileName { get; set; }
    }
}
