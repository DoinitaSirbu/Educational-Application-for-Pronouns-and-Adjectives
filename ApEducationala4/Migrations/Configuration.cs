namespace ApEducationala4.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using static ApEducationala4.DbTesteContext;

    internal sealed class Configuration : DbMigrationsConfiguration<ApEducationala4.DbTesteContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ApEducationala4.DbTesteContext context)
        {
            // Pronoun Questions
            var pronounQuestions = new List<PronounQuestion>
            {
                new PronounQuestion { TextIntrebare = "1.Ce este un pronume?" },
                new PronounQuestion { TextIntrebare = "2.Care este pronumele personal de persoana a doua singular în cazul nominativ?" },
                new PronounQuestion { TextIntrebare = "3.Completează spațiul liber: 'Maria și __________ suntem prietene bune.'" },
                new PronounQuestion { TextIntrebare = "4.Care este pronumele posesiv corespunzător pronumelui 'el' în cazul genitiv?" },
                new PronounQuestion { TextIntrebare = "5.Ce pronume interogativ poate fi folosit pentru a întreba despre numărul de obiecte?" },
                new PronounQuestion { TextIntrebare = "6.Completează spațiul liber: 'Tu și __________ sunteți elevi buni.'" },
                new PronounQuestion { TextIntrebare = "7.Care este pronumele reflexiv corespunzător pronumelui 'ei' în cazul acuzativ?" },
                new PronounQuestion { TextIntrebare = "8.Completează spațiul liber: 'El a spus că __________ va veni la petrecere.'" },
                new PronounQuestion { TextIntrebare = "9.Ce pronume demonstrativ poate fi folosit pentru a indica un obiect apropiat?" },
                new PronounQuestion { TextIntrebare = "10.Completează spațiul liber: 'Eu și __________ suntem vecini de cartier.'" }
            };
            context.PronounQuestions.AddOrUpdate(
                q => q.TextIntrebare,
                pronounQuestions.ToArray()
            );
            context.SaveChanges();
            var pronounAnswers = new List<PronounAnswer>
            {
                // Răspunsurile pentru întrebarea 1
                new PronounAnswer { Answer = "Un pronume este o parte de vorbire care înlocuiește un substantiv.", IsCorrect = true,  Id = pronounQuestions[0].Id },
                new PronounAnswer { Answer = "Un pronume este un adjectiv posesiv.", IsCorrect = false, Id = pronounQuestions[0].Id },
                new PronounAnswer { Answer = "Un pronume este un adverb.", IsCorrect = false, Id = pronounQuestions[0].Id },

                // Răspunsurile pentru întrebarea 2
                new PronounAnswer { Answer = "Tu",  IsCorrect = false, Id = pronounQuestions[1].Id },
                new PronounAnswer { Answer = "El",  IsCorrect = false, Id = pronounQuestions[1].Id },
                new PronounAnswer { Answer = "Voi", IsCorrect = true,  Id = pronounQuestions[1].Id },

                // Răspunsurile pentru întrebarea 3
                new PronounAnswer { Answer = "noi", IsCorrect = false, Id = pronounQuestions[2].Id },
                new PronounAnswer { Answer = "el",  IsCorrect = false, Id = pronounQuestions[2].Id },
                new PronounAnswer { Answer = "eu",  IsCorrect = true,  Id = pronounQuestions[2].Id },

                // Răspunsurile pentru întrebarea 4
                new PronounAnswer { Answer = "lui", IsCorrect = true, Id = pronounQuestions[3].Id },
                new PronounAnswer { Answer = "ei", IsCorrect = false, Id = pronounQuestions[3].Id },
                new PronounAnswer { Answer = "nostru", IsCorrect = false, Id = pronounQuestions[3].Id },

                // Răspunsurile pentru întrebarea 5
                new PronounAnswer { Answer = "Câte?", IsCorrect = true, Id = pronounQuestions[4].Id },
                new PronounAnswer { Answer = "Cine?", IsCorrect = false, Id = pronounQuestions[4].Id },
                new PronounAnswer { Answer = "Cum?", IsCorrect = false,Id = pronounQuestions[4].Id },

                // Răspunsurile pentru întrebarea 6
                new PronounAnswer { Answer = "el", IsCorrect = false, Id = pronounQuestions[5].Id },
                new PronounAnswer { Answer = "ei", IsCorrect = false, Id = pronounQuestions[5].Id },
                new PronounAnswer { Answer = "voi", IsCorrect = true, Id = pronounQuestions[5].Id },

                 // Răspunsurile pentru întrebarea 7
                new PronounAnswer { Answer = "se", IsCorrect = true, Id = pronounQuestions[6].Id },
                new PronounAnswer { Answer = "eu", IsCorrect = false, Id = pronounQuestions[6].Id },
                new PronounAnswer { Answer = "noi", IsCorrect = false, Id = pronounQuestions[6].Id },

                // Răspunsurile pentru întrebarea 8
                new PronounAnswer { Answer = "eu", IsCorrect = true, Id = pronounQuestions[7].Id },
                new PronounAnswer { Answer = "el", IsCorrect = false, Id = pronounQuestions[7].Id },
                new PronounAnswer { Answer = "ea", IsCorrect = false, Id = pronounQuestions[7].Id },

                // Răspunsurile pentru întrebarea 9
                new PronounAnswer { Answer = "acesta", IsCorrect = true, Id = pronounQuestions[8].Id },
                new PronounAnswer { Answer = "acela", IsCorrect = false, Id = pronounQuestions[8].Id },
                new PronounAnswer { Answer = "alții", IsCorrect = false, Id = pronounQuestions[8].Id },

                // Răspunsurile pentru întrebarea 10
                new PronounAnswer { Answer = "el", IsCorrect = false, Id = pronounQuestions[9].Id },
                new PronounAnswer { Answer = "tu", IsCorrect = false, Id = pronounQuestions[9].Id },
                new PronounAnswer { Answer = "noi", IsCorrect = true, Id = pronounQuestions[9].Id },

            };
            context.PronounAnswers.AddOrUpdate(
                a => new { a.Answer, a.Id },
                pronounAnswers.ToArray()
            );

            context.SaveChanges();

            var adjectiveQuestions = new List<AdjectiveQuestion>
            {
                new AdjectiveQuestion { TextIntrebare = "1.Ce este un adjectiv?" },
                new AdjectiveQuestion { TextIntrebare = "2.Care este forma de gradul superlativ absolut a adjectivului “bun”?" },
                new AdjectiveQuestion { TextIntrebare = "3.Completează spațiul liber: 'Ana este __________ decât Maria.'" },
                new AdjectiveQuestion { TextIntrebare = "4.Care este adjectivul posesiv corespunzător pronumelui 'noi' în cazul acuzativ?" },
                new AdjectiveQuestion { TextIntrebare = "5.Ce adjectiv interogativ poate fi folosit pentru a întreba despre calitatea unei persoane?" },
                new AdjectiveQuestion { TextIntrebare = "6.Completează spațiul liber: 'Acest câine este __________ decât celălalt.'" },
                new AdjectiveQuestion { TextIntrebare = "7.Care este adjectivul posesiv corespunzător pronumelui 'ei' în cazul dativ?" },
                new AdjectiveQuestion { TextIntrebare = "8.Completează spațiul liber: 'El a cumpărat __________ cărți.'" },
                new AdjectiveQuestion { TextIntrebare = "9.Ce adjectiv demonstrativ poate fi folosit pentru a indica un obiect apropiat?" },
                new AdjectiveQuestion { TextIntrebare = "10.Completează spațiul liber: 'Acele flori sunt __________.'" }
            };
            context.AdjectiveQuestions.AddOrUpdate(
                q => q.TextIntrebare,
                adjectiveQuestions.ToArray()
            );

            // Adjective Answers
            var adjectiveAnswers = new List<AdjectiveAnswer>
            {
                // Răspunsurile pentru întrebarea 1
                new AdjectiveAnswer { Answer = "Un adjectiv este o parte de vorbire care exprimă o calitate a unui substantiv.", IsCorrect = true, Id = adjectiveQuestions[0].Id },
                new AdjectiveAnswer { Answer = "Un adjectiv este un verb.", IsCorrect = false, Id = adjectiveQuestions[0].Id },
                new AdjectiveAnswer { Answer = "Un adjectiv este un adverb.", IsCorrect = false, Id = adjectiveQuestions[0].Id },

                // Răspunsurile pentru întrebarea 2
                new AdjectiveAnswer { Answer = "Cea mai bună", IsCorrect = true, Id = adjectiveQuestions[1].Id },
                new AdjectiveAnswer { Answer = "Bunissim", IsCorrect = false, Id = adjectiveQuestions[1].Id },
                new AdjectiveAnswer { Answer = "Foarte bun", IsCorrect = false, Id = adjectiveQuestions[1].Id },

                // Răspunsurile pentru întrebarea 3
                new AdjectiveAnswer { Answer = "mai înaltă", IsCorrect = true, Id = adjectiveQuestions[2].Id },
                new AdjectiveAnswer { Answer = "mai scurtă", IsCorrect = false, Id = adjectiveQuestions[2].Id },
                new AdjectiveAnswer { Answer = "mai frumoasă", IsCorrect = false, Id = adjectiveQuestions[2].Id },

                // Răspunsurile pentru întrebarea 4
                new AdjectiveAnswer { Answer = "noastre", IsCorrect = true, Id = adjectiveQuestions[3].Id },
                new AdjectiveAnswer { Answer = "al tău", IsCorrect = false, Id = adjectiveQuestions[3].Id },
                new AdjectiveAnswer { Answer = "lor", IsCorrect = false, Id = adjectiveQuestions[3].Id },

                // Răspunsurile pentru întrebarea 5
                new AdjectiveAnswer { Answer = "Cum?", IsCorrect = false, Id = adjectiveQuestions[4].Id },
                new AdjectiveAnswer { Answer = "Ce?", IsCorrect = false, Id = adjectiveQuestions[4].Id },
                new AdjectiveAnswer { Answer = "Cine?", IsCorrect = true, Id = adjectiveQuestions[4].Id },

                // Răspunsurile pentru întrebarea 6
                new AdjectiveAnswer { Answer = "mai mare", IsCorrect = true, Id = adjectiveQuestions[5].Id },
                new AdjectiveAnswer { Answer = "mai mic", IsCorrect = false, Id = adjectiveQuestions[5].Id },
                new AdjectiveAnswer { Answer = "mai rapid", IsCorrect = false, Id = adjectiveQuestions[5].Id },

                // Răspunsurile pentru întrebarea 7
                new AdjectiveAnswer { Answer = "ei", IsCorrect = true, Id = adjectiveQuestions[6].Id },
                new AdjectiveAnswer { Answer = "ea", IsCorrect = false, Id = adjectiveQuestions[6].Id },
                new AdjectiveAnswer { Answer = "nostru", IsCorrect = false, Id = adjectiveQuestions[6].Id },

                // Răspunsurile pentru întrebarea 8
                new AdjectiveAnswer { Answer = "multe", IsCorrect = true, Id = adjectiveQuestions[7].Id },
                new AdjectiveAnswer { Answer = "acele", IsCorrect = false, Id = adjectiveQuestions[7].Id },
                new AdjectiveAnswer { Answer = "nouă", IsCorrect = false, Id = adjectiveQuestions[7].Id },

                // Răspunsurile pentru întrebarea 9
                new AdjectiveAnswer { Answer = "acest", IsCorrect = true, Id = adjectiveQuestions[8].Id },
                new AdjectiveAnswer { Answer = "acela", IsCorrect = false, Id = adjectiveQuestions[8].Id },
                new AdjectiveAnswer { Answer = "alții", IsCorrect = false, Id = adjectiveQuestions[8].Id },

                // Răspunsurile pentru întrebarea 10
                new AdjectiveAnswer { Answer = "frumoase", IsCorrect = true, Id = adjectiveQuestions[9].Id },
                new AdjectiveAnswer { Answer = "mici", IsCorrect = false, Id = adjectiveQuestions[9].Id },
                new AdjectiveAnswer { Answer = "diferite", IsCorrect = false, Id = adjectiveQuestions[9].Id },
            };

            context.AdjectiveAnswers.AddOrUpdate(
                a => a.Answer,
                adjectiveAnswers.ToArray()
            );

            context.SaveChanges();
        } 
    }
}
