using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooLogic.Data.Models
{
    public class ZooLogicRole : MetadataBaseEntity
    {
        public const string ZooLogicRoleDefaultAuthority = "User";
        public string Label { get; set; }

        public string Color{ get; set; }

        public string Authority { get; set; } = ZooLogicRoleDefaultAuthority;
    }
}
