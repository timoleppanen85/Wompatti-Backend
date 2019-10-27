using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WompattiApi.Models
{
    public partial class Admin
    {
        public long Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Username { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Salt { get; set; }
        [Required]
        [StringLength(50)]
        public string Hash { get; set; }
    }
}