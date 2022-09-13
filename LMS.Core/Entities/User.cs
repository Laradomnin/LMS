using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Core.Entities
{

    public class User:IdentityUser
    {
        //private User()
        //{
        //    FirstName = null!;
        //    LastName = null!;
        //    Email = null!;
        //    Role = null!;
          
        //}

        public User ( string firstName, string lastName, string email, string role)
        {
          
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Role = role;
        }
        //public int Id { get; set; } 
        public string FirstName { get; set; }  
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }

        
        public Course? Course { get; set; }
        public ICollection<Document>? Documents { get; set; }= new List<Document>();  

    }
}
