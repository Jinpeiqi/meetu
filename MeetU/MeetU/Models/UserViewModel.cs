﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeetU.Models
{
    public class UserViewModel
    {
        //
        // AspNetUsers
        //

        // Read
        public string UserId { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public int Number { get; set; }
        
        //
        // Profiles
        //

        // Read and Update
        public string NickName { get; set; }
        public string GivenName { get; set; }
        public string FamilyName { get; set; }
        public string Pricture { get; set; }
        public string Gender { get; set; }

        // Read 
        public DateTime CreatedAt { get; set; }
        public int LoginCount { get; set; }
    }
}