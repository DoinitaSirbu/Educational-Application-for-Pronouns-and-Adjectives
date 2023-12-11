using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ApEducationala4.Models
{
    public class PronounQuestion
    {
        [Key]
        public int Id { get; set; }

        public string Text { get; set; }
    }
}
