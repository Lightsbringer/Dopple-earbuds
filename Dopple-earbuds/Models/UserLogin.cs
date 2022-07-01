using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.View_Model
{
    
    public class UserLogin
    {
        [Required(ErrorMessage = "A user id is required")]
        public int UserID { get; set; }

        [Required(ErrorMessage ="please insert your password")]
        [DataType(DataType.Password)]
        public String Password { get; set; }
    }
}
