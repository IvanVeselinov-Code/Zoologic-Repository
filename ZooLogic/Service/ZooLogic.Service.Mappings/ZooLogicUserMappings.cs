using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooLogic.Data.Models;
using ZooLogic.Service.Models;

namespace ZooLogic.Service.Mappings
{
    public static class ZooLogicUserMappings
    {
        public static ZooLogicUser ToEntity(this ZooLogicUserServiceModel model)
        {
            return new ZooLogicUser();
            
        }
        public static ZooLogicUserServiceModel ToModel(this ZooLogicUser entity)
        {
            return new ZooLogicUserServiceModel
            {
                ForumRole = entity.ForumRole.ToModel(),
                Email = entity.Email,
                Id = entity.Id,
                UserName = entity.UserName
            };
        }
    }
}
