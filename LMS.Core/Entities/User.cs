using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Entities
{

    public class  User:IdentityUser
    {
     
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        // public string Email { get; set; }
        // public string Role { get; set; }


        public Course? Course { get; set; }
        public ICollection<Document>? Documents { get; set; }= new List<Document>();  

    }
}
