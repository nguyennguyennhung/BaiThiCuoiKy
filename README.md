# BaiThiCuoiKy
Ứng dụng desktop quản lý trung tâm đào tạo (khoá học, lớp học, học viên, giảng viên, ghi danh, lịch học, kết quả học tập), xây dựng bằng C# WinForms.

Công nghệ sử dụng
- Ngôn ngữ: C#
- Nền tảng: .NET Framework 4.8, Windows Forms
- Truy xuất dữ liệu: Entity Framework 6 (Code First từ database có sẵn)
- Cơ sở dữ liệu: SQL Server (database QLTrungTamTH)

  BaiThiCuoiKy/
     DAL/
        DBcontext.cs        # MyDbContext - kết nối & DbSet cho 7 thực thể
         Entities/           # Model: Khoahoc, Lophoc, Hocvien, Giangvien, Ghidanh, Lichhoc, Ketqua
     FrmDangnhap.cs          # Màn hình đăng nhập
     FrmMain.cs              # Màn hình chính (menu điều hướng)
     FrmKhoahoc.cs           # Quản lý khoá học
     FrrmLophoc.cs           # Quản lý lớp học
     FrmHocvien.cs           # Quản lý học viên
     FrmGiangvien.cs         # Quản lý giảng viên
     FrmGhidanh.cs           # Quản lý ghi danh
     FrmLichhoc.cs           # Quản lý lịch học
     FrmKetqua.cs            # Quản lý kết quả học tập
     Program.cs              # Entry point (mở FrmDangnhap đầu tiên)
  Mô hình dữ liệu

7 thực thể chính, liên kết qua khoá ngoại:
- Khoahoc (Khoá học) ← Lophoc (Lớp học)
- Hocvien (Học viên) ↔ Lophoc qua Ghidanh (Ghi danh)
- Giangvien (Giảng viên) — phụ trách lớp / lịch học
- Lichhoc (Lịch học), Ketqua (Kết quả)

