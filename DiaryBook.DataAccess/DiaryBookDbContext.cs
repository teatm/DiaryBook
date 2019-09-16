using DiaryBook.DTO;
using Microsoft.EntityFrameworkCore;

namespace DiaryBook.DataAccess
{
    public class DiaryBookDbContext : DbContext
    {
        public DiaryBookDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=localhost;database=DiaryBookDB;user=;password=");
        }

        DbSet<Diary> Diaries { get; set; }
    }
}
