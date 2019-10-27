using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WompattiApi.Models
{
    public partial class Answer
    {
        public long Id { get; set; }
        [Required]
        [Column("Answer")]
        public string Answer1 { get; set; }
        public string ExtraText { get; set; }
        public int AnswerSet { get; set; }
        public long QuestionId { get; set; }
        public long UserId { get; set; }

        [ForeignKey("QuestionId")]
        [InverseProperty("Answer")]
        public virtual Question Question { get; set; }
        [ForeignKey("UserId")]
        [InverseProperty("Answer")]
        public virtual User User { get; set; }
    }
}