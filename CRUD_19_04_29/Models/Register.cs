using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUD_19_04_29.Models
{
    public class Register
    {
        [Required]
        [Key]
        public int CODE { get; set; }
        [Required]
        public int IDENT { get; set; }
        [Required]
        [Display(Name = "User Name")]
        [StringLength(50, ErrorMessage = "Please, your name must be 50 characters or less")]
        public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        [StringLength(50, ErrorMessage = "Please, your address must be 50 characters or less")]
        public string Address { get; set; }
       

    }

  


}