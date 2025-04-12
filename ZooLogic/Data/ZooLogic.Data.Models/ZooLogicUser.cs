using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ZooLogic.Data.Models
{
    public class ZooLogicUser : IdentityUser
    {
        public ZooLogicRole? ForumRole { get; set; }


    }
}
