using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ZooLogic.Service.Models
{
    public class ZooLogicUserServiceModel : IdentityUser
    {
        public ZooLogicRoleServiceModel ForumRole { get; set; }


    }
}
