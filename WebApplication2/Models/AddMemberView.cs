using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class AddMemberView
    {
        public int GroupId { get; set; }
        [Required(ErrorMessage="The field {0} is requerid")]
        public int UserId { get; set; }
    }
}