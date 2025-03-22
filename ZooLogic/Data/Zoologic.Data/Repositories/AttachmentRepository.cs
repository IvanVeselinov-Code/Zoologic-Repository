using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZooLogic.Data.Models;
using ZooLogic.web.Data;

namespace ZooLogic.Data.Repositories
{
    public class AttachmentRepository : BaseGenericRepository<Attachment>
    {
        public AttachmentRepository(ZooLogicDbContext dbContext) : base(dbContext)
        {
        }
    }
}
