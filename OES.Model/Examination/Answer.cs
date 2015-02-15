﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OES.Model.Examination
{
    public class Answer : BaseEntity 
    {
        public Answer()
        {
            AnswerId = GenerateKey();
        }
        [Key]
        public string AnswerId { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string AnswerText { get; set; }

        [Required]
        public bool IsCorrectAnswer { get; set; }

        public string QuestionId { get; set; }

        [ForeignKey("QuestionId")]
        public Question Question { get; set; }

    }
}
