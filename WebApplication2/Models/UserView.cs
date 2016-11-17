using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class UserView
    {

        public int UserId { get; set; }
        [DataType(DataType.EmailAddress)]
        [Display(Name = "E-Mail")]
        [Required(ErrorMessage = "The Field {0} is required")]
        [StringLength(100, ErrorMessage = "The field {0} can contain maximun {1} and minimun {2} characters", MinimumLength = 7)]
        public string UserName { get; set; }
        [StringLength(50, ErrorMessage = "The field {0} can contain maximun {1} and minimun {2} characters", MinimumLength = 2)]
        [Display(Name = "First name")]
        [Required(ErrorMessage = "The Field {0} is required")]
        public string FirstName { get; set; }
        [StringLength(50, ErrorMessage = "The field {0} can contain maximun {1} and minimun {2} characters", MinimumLength = 2)]
        [Display(Name = "Last name")]
        [Required(ErrorMessage = "The Field {0} is required")]
        public string LastName { get; set; }
        [StringLength(20, ErrorMessage = "The field {0} can contain maximun {1} and minimun {2} characters", MinimumLength = 7)]
        [Required(ErrorMessage = "The Field {0} is required")]
        public string Phone { get; set; }
        [StringLength(100, ErrorMessage = "The field {0} can contain maximun {1} and minimun {2} characters", MinimumLength = 10)]
        [Required(ErrorMessage = "The Field {0} is required")]
        public string Address { get; set; }
        public string Grade { get; set; }
        public string Group { get; set; }
        
        public HttpPostedFileBase Photo { get; set; }
    }
}
 