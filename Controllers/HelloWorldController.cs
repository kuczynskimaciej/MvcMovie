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
            Random rnd = new Random();

            List<QuestionModel> _listOfQuestions = new List<QuestionModel>();
            QuestionModel question1 = new QuestionModel();
            question1.Question = "Ile to jest 2+2?";
            question1.Answers = new List<AnswerModel>();
            question1.Answers.Add(new AnswerModel() { Answer = "1", IsCorrect = false });
            question1.Answers.Add(new AnswerModel() { Answer = "2", IsCorrect = false });
            question1.Answers.Add(new AnswerModel() { Answer = "3", IsCorrect = false });
            question1.Answers.Add(new AnswerModel() { Answer = "4", IsCorrect = true });

            QuestionModel question2 = new QuestionModel();
            question2.Question = "Co idzie ze sobą w parze?";
            question2.Answers = new List<AnswerModel>();
            question2.Answers.Add(new AnswerModel() { Answer = "Wódka", IsCorrect = true });
            question2.Answers.Add(new AnswerModel() { Answer = "Zakąska", IsCorrect = true });
            question2.Answers.Add(new AnswerModel() { Answer = "3", IsCorrect = false });
            question2.Answers.Add(new AnswerModel() { Answer = "4", IsCorrect = false });

            _listOfQuestions.Add(question1);
            _listOfQuestions.Add(question2);

            var countOfQuestions = _listOfQuestions.Count();
            var indexOfRandomQuestion = rnd.Next(countOfQuestions);
            var question = _listOfQuestions.ElementAt(indexOfRandomQuestion);

            return View(question);
        }
        [HttpPost]
        public IActionResult CheckAnswers(QuestionModel model)
        {
            return View(model);
        }
        public IActionResult AddAnswer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddAnswer(AnswerModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Welcome");
            }
            else
            {
                return View(model);
            }
        }
    }
}