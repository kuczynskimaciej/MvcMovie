﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class QuestionModel
    {
        public int CountOfRepetitionsOfQuestion { get; set; }
        public string Question { get; set; }
        public List<AnswerModel> Answers { get; set; }
    }
}
