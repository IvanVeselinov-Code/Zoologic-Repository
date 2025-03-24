using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooLogic.Service.Models
{
    public abstract class MetadataBaseServiceModel : BaseServiceModel
    {
        public ZooLogicUserServiceModel CreatedBy { get; set; }

        public DateTime CreatedOn { get; set; }

        public ZooLogicUserServiceModel UpdatedBy { get; set; }

        public DateTime UpdatedOn { get; set; }

        public ZooLogicUserServiceModel DeletedBy { get; set; }
        public DateTime DeletedOn { get; set; }
    }
}
