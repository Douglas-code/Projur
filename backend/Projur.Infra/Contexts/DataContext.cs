using Microsoft.EntityFrameworkCore;
using Projur.Domain.Entities;

namespace Projur.Infra.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("tb_user");
            modelBuilder.Entity<User>().HasKey(x => x.Id);

            modelBuilder.Entity<User>().Property(x => x.Id).HasColumnName("id").ValueGeneratedOnAdd();
            modelBuilder.Entity<User>().Property(x => x.Name).HasMaxLength(160).HasColumnType("varchar(160)").HasColumnName("name");
            modelBuilder.Entity<User>().Property(x => x.Surname).HasMaxLength(160).HasColumnType("varchar(160)").HasColumnName("surname");
            modelBuilder.Entity<User>().Property(x => x.Email).HasMaxLength(120).HasColumnType("varchar(120)").HasColumnName("email");
            modelBuilder.Entity<User>().Property(x => x.Schooling).HasColumnType("int").HasColumnName("schooling");
            modelBuilder.Entity<User>().Property(x => x.BirthDate).HasColumnType("date").HasColumnName("birth_date");
        }
    }
}
