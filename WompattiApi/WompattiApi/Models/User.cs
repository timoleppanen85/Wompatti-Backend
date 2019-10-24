using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WompattiApi.Models
{
    public partial class User
    {
        public User()
        {
            Answer = new HashSet<Answer>();
        }

        public long Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Username { get; set; }
        [StringLength(50)]
        public string Firstname { get; set; }
        [StringLength(50)]
        public string Lastname { get; set; }
        public string Photo { get; set; }

        [InverseProperty("User")]
        public virtual ICollection<Answer> Answer { get; set; }
    }
}