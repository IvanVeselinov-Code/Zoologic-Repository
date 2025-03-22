using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooLogic.Data.Models
{
    public class ZooLogicThread : MetadataBaseEntity
    {
        public string Title  { get; set; }

        public string Content { get; set; }

        public Category Category { get; set; }

        public List<UserThreadReaction> Reactions { get; set; }

        public List<UserThreadComment> Comment { get; set; }
    }
}
