using EstateSales.Backend.Datas.Entities;
using Microsoft.EntityFrameworkCore;

namespace EstateSales.Backend.Context

{
    public class EstateContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Advertisement> Advertisements { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public EstateContext(DbContextOptions options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //advertisement-user kapcsolat 1:N
            modelBuilder.Entity<Advertisement>().HasOne(ad=>ad.User).WithMany(u=>u.Advertisements).
                HasForeignKey(ad=>ad.UserId).OnDelete(DeleteBehavior.Cascade);

            /* modelBuilder.Entity<Message>().HasOne(mes=>mes.User).WithMany(u=>u.Messages).HasForeignKey(msg=>msg.UserId)
                 .OnDelete(deleteBehavior: DeleteBehavior.Cascade);*/

            modelBuilder.Entity<User>() .HasMany(u => u.Messages).WithOne(m => m.User).HasForeignKey(m => m.UserId)
             .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Photo>().HasOne(photo=>photo.Advertisement).WithMany(ad=>ad.Photos).HasForeignKey(photo=>photo.AdvertisementId).
                OnDelete(deleteBehavior: DeleteBehavior.Cascade);


            

            base.OnModelCreating(modelBuilder);
        }
    }
}
