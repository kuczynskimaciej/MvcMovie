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
            QuestionModel question = new QuestionModel();
            question.Question = "Ile to jest 2+2?";
            question.Answers = new List<AnswerModel>();
            question.Answers.Add(new AnswerModel() { Answer = "1", IsCorrect = false });
            question.Answers.Add(new AnswerModel() { Answer = "2", IsCorrect = false });
            question.Answers.Add(new AnswerModel() { Answer = "3", IsCorrect = false });
            question.Answers.Add(new AnswerModel() { Answer = "4", IsCorrect = true });

            return View(question);
        }
        [HttpPost]
        public IActionResult Welcome([Bind("Question")] QuestionModel model)
        {
            return View();
        }
    }
}