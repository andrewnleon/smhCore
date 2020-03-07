using System;
using System.Collections.Generic;

namespace smhApi.Models
{
    public partial class AdminUsers
    {
        public int UserId { get; set; }
        public string UserEmail { get; set; }
        public string UserPsw { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserRole { get; set; }
    }
}
