using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCbasicsAssignment01.Utilities;
using MVCbasicsAssignment01.Models;

namespace MVCbasicsAssignment01.Controllers
{
    public class NumberGuessController : Controller
    {
        [HttpGet]
        [Route("GuessingGame")]
        public IActionResult NumberGuess()
        {
            GuessingGame GG = new GuessingGame();
            return View();
        }

        [HttpPost]
        [Route("GuessingGame")]
        public IActionResult NumberGuess(GuessingGame guessingGame)
        {
            //ViewBag.ShowCounter = NumberGuessUtility.Counter();
            //NumberGuess(theGuess);
            if (ModelState.IsValid)
            {
                ViewBag.GuessResult = NumberGuessUtility.GuessNumber(guessingGame.TheGuess);
            }
            return View();
        }
    }
}
