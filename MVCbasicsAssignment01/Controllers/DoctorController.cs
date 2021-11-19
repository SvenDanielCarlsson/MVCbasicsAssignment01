using Microsoft.AspNetCore.Mvc;
using MVCbasicsAssignment01.Models;
using MVCbasicsAssignment01.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCbasicsAssignment01.DoctorController
{
    
    public class DoctorController : Controller
    {
        [HttpGet]
        [Route("Doctor/FeverCheck")]
        public IActionResult Doctor()
        {
            Doctor doctor = new Doctor();
            return View(doctor);        //Pre-fill the form with values because I like it

        }

        [HttpPost]
        [Route("Doctor/FeverCheck")]
        public IActionResult Doctor(Doctor doctor)
        {
            if (ModelState.IsValid) { 
                ViewBag.DoctorTempTest = DoctorTest.FeverTest(doctor.PatientTemp, doctor.IsFahrenheit);
            }
            return View();
        }

    }
}
