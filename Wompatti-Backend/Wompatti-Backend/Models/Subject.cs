using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wompatti_Backend.Models
{
    public partial class Subject
    {
        public Subject()
        {
            Question = new HashSet<Question>();
        }

        public long Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        [Required]
        public string Header1 { get; set; }
        [Required]
        public string Header2 { get; set; }
        [Required]
        public string Header3 { get; set; }
        public string Header4 { get; set; }
        [Required]
        public bool? Visible { get; set; }

        [InverseProperty("Subject")]
        public virtual ICollection<Question> Question { get; set; }
    }
}