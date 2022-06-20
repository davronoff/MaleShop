using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaleShop.Domains
{
    public class SiteIndexCollactions
    {
        [Required, Key]
        public Guid Id { get; set; }
        [Required]
        public DateTime CreateTime { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? CollactionName { get; set; }
        [Required]
        public string? Body { get; set; }
        [Required]
        public string? Image { get; set; }

    }
}
