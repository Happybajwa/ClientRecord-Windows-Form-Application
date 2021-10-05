﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientRecord.Models
{
    class User
    {    
        [Key]
        public int UserId { get; set; }
        [Required]
        public string EmailId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }

        
        public string Password { get; set; }
    }
}
