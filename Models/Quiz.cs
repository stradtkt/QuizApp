using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Quizzes.Models
{
    public class Quiz : BaseEntity
    {
        [Key]
        public int quiz_id {get;set;}
        public string name {get;set;}
        public string desc {get;set;}
        public List<Question> Questions {get;set;}
        public Quiz()
        {
            Questions = new List<Question>();
            created_at = DateTime.Now;
            updated_at = DateTime.Now;
        }
    }
}