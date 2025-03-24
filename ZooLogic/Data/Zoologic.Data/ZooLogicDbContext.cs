using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ZooLogic.Data.Models;

namespace ZooLogic.web.Data
{
    public class ZooLogicDbContext : IdentityDbContext<ZooLogicUser>
    {
        public DbSet<Attachment> Attachments { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ZooLogicThread> Threads { get; set; }
        public DbSet<Reaction> Reactions { get; set; }

        public DbSet<ZooLogicRole> ForumRoles { get; set; }

        public ZooLogicDbContext(DbContextOptions<ZooLogicDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<UserThreadReaction>()
                .HasOne(utr => utr.Thread)
                .WithMany(t => t.Reactions)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(builder);
        }
    }
}
