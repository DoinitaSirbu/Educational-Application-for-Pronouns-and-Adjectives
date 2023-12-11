using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApEducationala4
{

    public class DbTesteContext : DbContext
    {
        public DbTesteContext() : base("DbTesteContext")
        {
            if (!Database.Exists("DbTesteContext"))
            {
                Database.SetInitializer(new DropCreateDatabaseAlways<DbTesteContext>());
            }
        }

        public DbSet<AdjectiveQuestion> AdjectiveQuestions { get; set; }
        public DbSet<AdjectiveAnswer> AdjectiveAnswers { get; set; }
        public DbSet<PronounQuestion> PronounQuestions { get; set; }
        public DbSet<PronounAnswer> PronounAnswers { get; set; }

        public class AdjectiveQuestion
        {
            public int Id { get; set; }
            public string TextIntrebare { get; set; }
        }

        public class AdjectiveAnswer
        {
            public int Id { get; set; }
            public string Answer { get; set; }
            public bool IsCorrect { get; set; }
        }
        public class PronounQuestion
        {
            public int Id { get; set; }
            public string TextIntrebare { get; set; }
        }

        public class PronounAnswer
        {
            public int Id { get; set; }
            public string Answer { get; set; }
            public bool IsCorrect { get; set; }
        }
    }

}
