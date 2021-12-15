using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCbasicsAssignment01.Models;

namespace MVCbasicsAssignment01.Utilities
{
    public class NumberGuessUtility
    {
        public static int RandomNumber()   //run this when directed to GuessingGame route
        {
            int theNumber = new Random().Next(1, 100);
            int theNumberTest = 1;
            return theNumberTest;
        }
        public int Counter()
        {
            //int count = Counter;
            return 0;
        }

        public static string GuessNumber (int TheGuess) {
            int theNumber1 = RandomNumber(); //This wont work, new random number every call of fumction
            int theNumber = 2;  //inject randomnumber here ONCE
            string msg = "No input";

            if (TheGuess != theNumber)
            {
                //counter = 0; //Create this, in a models class folder?
                if (TheGuess > theNumber)
                {
                    //Let player know guess is too high
                    msg = "The guess is too high";
                }
                else if (TheGuess < theNumber)
                {
                    //Let player know guess is to low
                    msg = "The guess is too low";
                }
            }
            else if(TheGuess == theNumber)
            {
                //reset counter
                msg = "You won, but I'm not finished!";
                //reset counter, score, random number
            }

            return msg;
        }
    }
}
