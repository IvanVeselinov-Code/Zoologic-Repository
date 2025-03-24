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
    internal class ReactionRepository : MetadataBaseGenericRepository<Reaction>
    {
        public ReactionRepository(ZooLogicDbContext dbContext, IHttpContextAccessor httpContextAccessor) : base(dbContext, httpContextAccessor)
        {
        }
    }
}
