using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using ZooLogic.Data.Models;
using ZooLogic.web.Data;

namespace ZooLogic.Data.Repositories
{
    public class CommentRepository : MetadataBaseGenericRepository<Comment>
    {
        public CommentRepository(ZooLogicDbContext dbContext, IHttpContextAccessor httpContextAccessor) : base(dbContext, httpContextAccessor)
        {
        }
    }
}
