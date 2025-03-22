using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooLogic.Data.Models
{
    public class UserThreadComment : BaseEntity
    {
        public ZooLogicUser User { get; set; }

        public ZooLogicThread Thread { get; set; }

        public Comment Comment { get; set; }   
    }
}
