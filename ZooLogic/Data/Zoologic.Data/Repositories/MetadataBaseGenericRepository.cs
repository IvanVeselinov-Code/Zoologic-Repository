using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using ZooLogic.Data.Models;
using ZooLogic.web.Data;

namespace ZooLogic.Data.Repositories
{
    public abstract class MetadataBaseGenericRepository<TEntity> : BaseGenericRepository<TEntity> where TEntity : MetadataBaseEntity
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        protected MetadataBaseGenericRepository(ZooLogicDbContext dbContext, IHttpContextAccessor httpContextAccessor) : base(dbContext)
        {
            this._httpContextAccessor = httpContextAccessor;
        }

        public MetadataBaseGenericRepository(ZooLogicDbContext dbContext) : base(dbContext)
        {
        }

        public override async Task<TEntity> CreateAsync(TEntity entity)
        {
            entity.CreatedOn = DateTime.UtcNow;
            entity.CreatedBy = await this.GetUser();
            return await base.CreateAsync(entity);
        }
        public override async Task<TEntity> EditAsync(TEntity entity)
        {
            entity.UpdatedOn = DateTime.UtcNow;
            entity.UpdatedBy = await this.GetUser();
            return await base.EditAsync(entity);
        }

        public override async Task<TEntity> DeleteAsync(TEntity entity)
        {
            entity.DeletedOn = DateTime.UtcNow;
            entity.DeletedBy = await this.GetUser();
            return await base.DeleteAsync(entity);
        }

        private async Task<ZooLogicUser> GetUser()
        {
            string? userId = this._httpContextAccessor?.HttpContext?.User?.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            return await this._dbContext.Users.SingleOrDefaultAsync(user =>  user.Id == userId);
        }
    }
}
