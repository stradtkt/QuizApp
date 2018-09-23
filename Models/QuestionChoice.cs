using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Quizzes.Models
{
    public class QuestionChoice
    {
        [Key]
        public int choice_id {get;set;}
        public int question_id {get;set;}
        public Question Question {get;set;}
        public bool is_right_choice {get;set;}
        public string choice {get;set;}
    }
}