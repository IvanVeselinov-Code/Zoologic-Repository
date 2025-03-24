using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ZooLogic.Data.Models;
using ZooLogic.web.Data;

namespace ZooLogic.Data.Repositories
{
    public abstract class BaseGenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity
    {

        protected readonly ZooLogicDbContext _dbContext;

        protected BaseGenericRepository(ZooLogicDbContext dbContext)
        {
           this._dbContext = dbContext;
        }

        public virtual async Task<TEntity> CreateAsync(TEntity entity)
        {
            await this._dbContext.AddAsync(entity); 
            await this._dbContext.SaveChangesAsync();
            return entity;
        }

        public virtual async Task<TEntity> DeleteAsync(TEntity entity)
        {
            this._dbContext.Remove(entity);
            await this._dbContext.SaveChangesAsync();
            return entity;
        }

        public virtual async Task<TEntity> UpdateAsync(TEntity entity)
        {
            this._dbContext.Update(entity);
            await this._dbContext.SaveChangesAsync();
            return entity;
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            return this._dbContext.Set<TEntity>().AsQueryable<TEntity>();
        }

        public virtual IQueryable<TEntity> GetAllAsNoTracking()
        {
            return this._dbContext.Set<TEntity>().AsNoTracking();
        }
    }
}
