using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebSiteP1.Models
{
    [Table("UserClass")]
    public class UserClasses
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string ClassId { get; set; }
        public string UserId { get; set; }
    }

    public class UserClasses2
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ClassId { get; set; }
    }
}
