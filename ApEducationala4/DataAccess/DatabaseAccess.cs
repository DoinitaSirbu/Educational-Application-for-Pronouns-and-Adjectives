using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Entity;


namespace ApEducationala4.Forms
{
    public class DatabaseAccess 
    {
        public DataTable GetAdjectiveAnswers()
        {
            using (var context = new DbTesteContext())
            {
                var answers = context.AdjectiveAnswers.Select(a => new { a.Answer, a.IsCorrect }).ToList();
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Answer", typeof(string));
                dataTable.Columns.Add("IsCorrect", typeof(bool)); 

                foreach (var answer in answers)
                {
                    dataTable.Rows.Add(answer.Answer, answer.IsCorrect); 
                }

                return dataTable;
            }
        }

        public DataTable GetAdjectiveQuestions()
        {
            using (var context = new DbTesteContext())
            {
                var questions = context.AdjectiveQuestions.Select(q => q.TextIntrebare).ToList();
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("TextIntrebare", typeof(string));
                foreach (var question in questions)
                {
                    dataTable.Rows.Add(question);
                }
                return dataTable;
            }
        }
        public DataTable GetPronounAnswers()
        {
            using (var context = new DbTesteContext())
            {
                var answers = context.PronounAnswers.Select(a => new { a.Answer, a.IsCorrect }).ToList();
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Answer", typeof(string));
                dataTable.Columns.Add("IsCorrect", typeof(bool)); 

                foreach (var answer in answers)
                {
                    dataTable.Rows.Add(answer.Answer, answer.IsCorrect); 
                }

                return dataTable;
            }
        }

        public DataTable GetPronounQuestions()
        {
            using (var context = new DbTesteContext())
            {
                var questions = context.PronounQuestions.Select(q => q.TextIntrebare).ToList();
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("TextIntrebare", typeof(string));
                foreach (var question in questions)
                {
                    dataTable.Rows.Add(question);
                }
                return dataTable;
            }
        }
    }
}
