using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooLogic.Data.Models
{
    public class Category : MetadataBaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Attachment CoverPhoto { get; set; }
    }
}
