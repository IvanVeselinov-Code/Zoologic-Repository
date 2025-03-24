using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooLogic.Data.Models;
using ZooLogic.Service.Models;

namespace ZooLogic.Service.Mappings
{
    public static class AttachmentMappings
    {
        public static Attachment ToEntity(this AttachmentServiceModel model)
        {
            return new Attachment
            {
                CloudUrl = model.CloudUrl
            };
        }
        public static AttachmentServiceModel ToModel(this Attachment entity)
        {
            return new AttachmentServiceModel
            {
                Id = entity.Id,
                CloudUrl = entity.CloudUrl
            };
        }
    }
}
