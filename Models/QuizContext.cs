using Microsoft.EntityFrameworkCore;
 
namespace Quizzes.Models
{
    public class QuizContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public QuizContext(DbContextOptions<QuizContext> options) : base(options) { }
        public DbSet<Quiz> quizzes {get;set;}
        public DbSet<User> users {get;set;}
        public DbSet<Question> questions {get;set;}
        public DbSet<UserAnswer> user_answers {get;set;}
        public DbSet<QuestionChoice> question_choices {get;set;}
    }
}