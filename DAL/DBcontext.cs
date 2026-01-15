using DAL.Entities;
using System.Data.Entity;

namespace DAL
{
    public class MyDbContext : DbContext
    {
        // Dùng chuỗi kết nối đầy đủ thay vì "name=..."
        public MyDbContext()
            : base("Data Source=DESKTOP-2HEK043;Initial Catalog=QLTrungTamTH;Integrated Security=True;MultipleActiveResultSets=True;Encrypt=True;TrustServerCertificate=True")
        {
            // Không tự tạo DB vì bạn đã có Script SQL rồi
            Database.SetInitializer<MyDbContext>(null);
        }

        public DbSet<Khoahoc> Khoahocs { get; set; }
        public DbSet<Lophoc> Lophocs { get; set; }
        public DbSet<Hocvien> Hocviens { get; set; }
        public DbSet<Giangvien> Giangviens { get; set; }
        public DbSet<Ghidanh> Ghidanhs { get; set; }
        public DbSet<Lichhoc> Lichhocs { get; set; }
        public DbSet<Ketqua> Ketquas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

