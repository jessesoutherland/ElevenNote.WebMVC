using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Models
{
    public class NoteCreate
    {
        [Required]
        [MinLength(2), MaxLength(100)]
        public string Title { get; set; }
        [MaxLength(8000)]
        public string Content { get; set; }
    }
}
