﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WompattiApi.Models
{
    public partial class Answer
    {
        [Key]
        public long Id { get; set; }
        [Column("Answer")]
        public int Answer1 { get; set; }
        public string ExtraText { get; set; }
        public int AnswerSet { get; set; }
        public long QuestionId { get; set; }
        public long UserId { get; set; }
        [Column(TypeName = "date")]
        public DateTime Timestamp { get; set; }

        [ForeignKey(nameof(QuestionId))]
        [InverseProperty("Answer")]
        public virtual Question Question { get; set; }
        [ForeignKey(nameof(UserId))]
        [InverseProperty("Answer")]
        public virtual User User { get; set; }
    }
}