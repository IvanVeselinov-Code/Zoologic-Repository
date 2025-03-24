using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooLogic.Service.Models
{
    public class ZooLogicRoleServiceModel : BaseServiceModel
    {
        public const string ZooLogicRoleDefaultAuthority = "User";
        public string Label { get; set; }

        public string Color{ get; set; }

        public string Authority { get; set; } = ZooLogicRoleDefaultAuthority;
    }
}
