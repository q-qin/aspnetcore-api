using System;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    /// <summary>
    /// BaseEntity
    /// </summary>
    public class BaseEntity
    {
        [Key]
        public string id { get; set; }
    }
}
