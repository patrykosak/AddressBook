using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AddressBook.Models
{
    public class Address
    {
        [Display(Name = "Twoja ulubiona ulica")]
        [Required(ErrorMessage ="Pole jest obowiązkowe")]
        public string Street { get; set; }
        [Display(Name = "Kod pocztowy")]
        public string ZipCode { get; set; }
        [Display(Name = "Miasto")]
        [StringLength(60,MinimumLength = 3)]
        public string City { get; set; }
        [Display(Name = "Numer")]
        public int Number { get; set; }
    }

}
