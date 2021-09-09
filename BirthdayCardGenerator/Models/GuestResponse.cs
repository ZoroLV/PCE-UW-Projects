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
<<<<<<< HEAD
        public string To { get; set; }

=======
        public string To { get; set; }

>>>>>>> a02dca0fec6044e282fd93be39d2a8b5fec46374
        [Required(ErrorMessage = "Please enter your message")]
        public string Message { get; set; }
    }
}
