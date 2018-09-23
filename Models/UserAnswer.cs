using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Quizzes.Models
{
    public class UserAnswer
    {
        [Key]
        public int user_answer_id {get;set;}
        public int user_id {get;set;}
        public int choice_id {get;set;}
        public int question_id {get;set;}
        public Question Question {get;set;}
        public QuestionChoice Choices {get;set;}
        public User User {get;set;}
        public bool is_right {get;set;}
    }
}