using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSiteP1.Models
{
    [Table("Class")]
    public class Classes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ClassId { get; set; }
        [Display(Name = "Class Name")]
        public string ClassName { get; set; }
        [Display(Name = "Class Description")]
        public string ClassDescription { get; set; }
        [Display(Name = "Class Price")]
        public decimal ClassPrice { get; set; }
    }
}
