using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using PartyInvites.Models;


namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        //public ActionResult Index()
        //{
        //    return View();
        //}


        //public string Index()
        //{
        //    return "Hello World";
        //}

        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View();
        }


        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                // TODO : Email response to the party organizer
                return View("Thanks", guestResponse);
            }
            else
            {
                // there is a validation error
                return View();
            }
        }

        [HttpGet]
        public ViewResult PersonForm()
        {
            return View();
        }


        public ViewResult PersonForm(Person person)
        {
            if (ModelState.IsValid)
            {
                return View("MadePerson", person);
            }
            return View();
        }

        [HttpGet]
        public ViewResult CharacterNameRaceForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult CharacterNameRaceForm(Character character)
        {
            if (ModelState.IsValid)
            {
                return View("CharacterAttributeForm",character);
            }
            return View();
        }

        public ViewResult CharacterAttributeForm()
        {
            return View();
        }
    }
}
