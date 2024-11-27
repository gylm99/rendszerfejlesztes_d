using EstateSales.Backend.Datas.Entities;
using Microsoft.EntityFrameworkCore;

namespace EstateSales.Backend.Context

{
    public class EstateContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Advertisement> Advertisements { get; set; }
        public DbSet<Message> Messages { get; set; }
        public EstateContext(DbContextOptions options) : base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //advertisement-user kapcsolat 1:N
            modelBuilder.Entity<Advertisement>().HasOne(ad=>ad.User).WithMany(u=>u.Advertisements).
                HasForeignKey(ad=>ad.UserId).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Message>().HasOne(mes=>mes.User).WithMany(u=>u.Messages).HasForeignKey(msg=>msg.UserId)
                .OnDelete(deleteBehavior: DeleteBehavior.Cascade);


            modelBuilder.Entity<Advertisement>()
                .Property(a => a.PhotosPath)
                .HasConversion(
                    v => Newtonsoft.Json.JsonConvert.SerializeObject(v),
                    v => Newtonsoft.Json.JsonConvert.DeserializeObject<List<string>>(v)
                );


            base.OnModelCreating(modelBuilder);
        }
    }
}
