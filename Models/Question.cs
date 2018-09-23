using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Quizzes.Models
{
    public class Question
    {
        [Key]
        public int question_id {get;set;}
        public string question {get;set;}
        public int quiz_id {get;set;}
        public Quiz Quiz {get;set;}
        public List<QuestionChoice> Choices {get;set;}
        public Question()
        {
            Choices = new List<QuestionChoice>();
        }
    }
}