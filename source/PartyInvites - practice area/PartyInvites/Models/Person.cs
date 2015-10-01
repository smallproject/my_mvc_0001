using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class Person
    {
        [Required(ErrorMessage = "First name is required.")]
        public string firstname { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        public string lastname { get; set; }

        [Required(ErrorMessage = "Gender must be selected.")]
        public bool? gender { get; set; }

        [Required(ErrorMessage = "Birthdate must be filled.")]
        public DateTime birthdate { get; set; }
    }
}