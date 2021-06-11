using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace HelloWorld.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter who the card is from")]
        public string From { get; set; }

        [Required(ErrorMessage = "Please enter the recipient")]
        public string To { get; set; }

        [Required(ErrorMessage = "Please enter your message")]
        public string Message { get; set; }
    }
}
