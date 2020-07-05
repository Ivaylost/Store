using Microsoft.AspNetCore.Identity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Store.Models
{
    public class Client : IdentityUser
    {
        public virtual ICollection<Order> Orders { get; set; }
    }
}
