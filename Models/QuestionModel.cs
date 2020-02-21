using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class QuestionModel
    {
        public string Question { get; set; }
        public List<AnswerModel> Answers { get; set; }
    }
}
