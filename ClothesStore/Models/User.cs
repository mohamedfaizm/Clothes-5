using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClothesStore.Models
{
    public class User
    {
        public int userID { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public String HomeAddress { get; set; }
        public string Email { get; set; }

        //public virtual ICollection<> Orders { get; set; }
    }
}