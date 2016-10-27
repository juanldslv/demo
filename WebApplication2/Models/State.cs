using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class State
    {
        [Key]
        public int StateId { get; set; }

        [Display(Name = "State Description")]
        [Required(ErrorMessage ="The Field {0} is required")]
        [StringLength(50, ErrorMessage ="The field {0} can contain maximun {1} and minimun {2} characters",MinimumLength =3)]
        public string Description { get; set; }

        public virtual ICollection<Voting> Votings { get; set; }
    }
}