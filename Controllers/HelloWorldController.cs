using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using MvcMovie.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome()
        {
            Dictionary<int, QuestionModel> _dictionaryOfQuestions= new Dictionary<int, QuestionModel>();
            QuestionModel question1 = new QuestionModel();
            question1.Question = "Ile to jest 2+2?";
            question1.Answers = new List<AnswerModel>();
            question1.Answers.Add(new AnswerModel() { Answer = "1", IsCorrect = false });
            question1.Answers.Add(new AnswerModel() { Answer = "2", IsCorrect = false });
            question1.Answers.Add(new AnswerModel() { Answer = "3", IsCorrect = true });
            question1.Answers.Add(new AnswerModel() { Answer = "4", IsCorrect = true });

            QuestionModel question2 = new QuestionModel();
            question2.Question = "Co idzie ze sobą w parze?";
            question2.Answers = new List<AnswerModel>();
            question2.Answers.Add(new AnswerModel() { Answer = "Wódka", IsCorrect = false });
            question2.Answers.Add(new AnswerModel() { Answer = "Zakąska", IsCorrect = false });
            question2.Answers.Add(new AnswerModel() { Answer = "", IsCorrect = true });
            question2.Answers.Add(new AnswerModel() { Answer = "4", IsCorrect = true });

            _dictionaryOfQuestions.Add(1, question1);
            _dictionaryOfQuestions.Add(2, question2);

            return View(_dictionaryOfQuestions.Values);
        }
        [HttpPost]
        public IActionResult Welcome([Bind("Question")] QuestionModel model)
        {
            return View();
        }
    }
}