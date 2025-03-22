using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooLogic.Data.Models
{
    public abstract class MetadataBaseEntity : BaseEntity
    {
        public ZooLogicUser CreatedBy { get; set; }

        public DateTime CreatedOn { get; set; }

        public ZooLogicUser UpdatedBy { get; set; }

        public DateTime UpdatedOn { get; set; }

        public ZooLogicUser DeletedBy { get; set; }
        public DateTime DeletedOn { get; set; }
    }
}
