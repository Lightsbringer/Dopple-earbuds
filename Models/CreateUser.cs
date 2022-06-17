using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class CreateUser
    {
        public int CompanyId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

    }
}
