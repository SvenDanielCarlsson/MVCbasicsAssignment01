using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCbasicsAssignment01.Models;

namespace MVCbasicsAssignment01.Utilities
{
    public static class DoctorTest
    {

        public static string FeverTest(float TestFever, bool IsFahrenheit)
        {
            float degrees = TestFever;
            string unit = "Celsius";

            if (IsFahrenheit == true)
            {
                TestFever = (TestFever - 32) / 1.8F;
                unit = "Fahrenheit";
            }

            string msg = "no input";
            if (TestFever >= 50) { msg = $"{degrees} {unit} - Are you the devil?"; }
            else if (TestFever >= 39) { msg = $"{degrees} {unit} - You hava a high fever"; }
            else if (TestFever >= 37) { msg = $"{degrees} {unit} - You have a fever"; }
            else if (TestFever < 37 && TestFever >= 36) { msg = $"{degrees} {unit} - You don't have a fever"; }
            else if (TestFever < 18) { msg = $"{degrees} {unit} - Are you even there?"; }
            else if (TestFever < 35) { msg = $"{degrees} {unit} - You must be suffering from hypothermia!"; }
            else if (TestFever < 36) { msg = $"{degrees} {unit} - Temperature is alarmanly low"; }

            return msg;
        }
    }
}
