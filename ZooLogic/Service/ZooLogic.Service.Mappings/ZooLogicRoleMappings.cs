using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooLogic.Data.Models;
using ZooLogic.Service.Models;

namespace ZooLogic.Service.Mappings
{
    public static class ZooLogicRoleMappings
    {
        public static ZooLogicRole ToEntity(this ZooLogicRoleServiceModel model)
        {
            return new ZooLogicRole
            {
                Label = model.Label,
                Color = model.Color,
                Authority = model.Authority
            };
        }
        public static ZooLogicRoleServiceModel ToModel(this ZooLogicRole entity)
        {
            return new ZooLogicRoleServiceModel
            {
                Id = entity.Id,
                Label = entity.Label,
                Color = entity.Color,
                Authority = entity.Authority
            };
        }
    }
}
