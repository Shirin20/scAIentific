using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend.Models
{
    public class UserResearch
    {
        [Required]
        public string? ResearchArea { get; set; }
        
    }
}
    