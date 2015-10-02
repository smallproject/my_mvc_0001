using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class Character
    {
        
        [Required(ErrorMessage = "Please provide name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please select from available race.")]
        public string Race { get; set; }

        public DateTime Birthdate { get; set; }

        public PrimaryAttributes primaryAttributes;
        public PhysicalAttributes physicalAttributes;
        public DerivedAttributes derivedAttributes;
        public OtherAttributes otherAttributes;
    }

    //TODO: Gaming attributes
    public class PrimaryAttributes
    {
        public decimal Agility { get; set; }
        public decimal Endurance { get; set; }
        public decimal Intelligence { get; set; }
        public decimal Luck { get; set; }
        public decimal Personality { get; set; }
        public decimal Speed { get; set; }
        public decimal Strength { get; set; }
        public decimal Willpower { get; set; }
    }

    public class DerivedAttributes
    {
        public decimal Health { get; set; }
        public decimal Magicka { get; set; }
        public decimal Fatigue { get; set; }
        public decimal Encumbrance { get; set; }
    }

    public class PhysicalAttributes
    {
        public decimal height { get; set; }
        public decimal weight { get; set; }
    }

    public class OtherAttributes
    {
        public bool Gender { get; set; }
        public decimal Bounty { get; set; }
        public decimal Reputation { get; set; }
        public int Slaves { get; set; }
    }
}