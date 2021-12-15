using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCbasicsAssignment01.Models
{
    public class GuessingGame
    {
        public int Counter { get; set; }
        public int Score { get; set; }

        [Range(1,100)]
        [Required]
        public int TheGuess { get; set; }
    }
}
