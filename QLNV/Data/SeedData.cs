using Microsoft.EntityFrameworkCore;
using QLNV.Data.Entities;

namespace QLNV.Data
{
  public static class SeedData
  {
    public static void DataSeeder(this ModelBuilder modelBuilder)
    {
      // tạo dữ liệu test cho bảng NhanVien
      var employee = new[]
      {
        new Employee { EmployeeId = 1, FullName = "thịnh", Department = "Sản Xuất", DateOfBirth = new DateTime(1997, 1, 1), Age = 28, PhoneNumber = "0123456789"},
        new Employee { EmployeeId = 2, FullName = "thịnh", Department = "Sản Xuất", DateOfBirth = new DateTime(1997, 1, 1), Age = 28, PhoneNumber = "0123456789"},
        new Employee { EmployeeId = 3, FullName = "thịnh", Department = "Sản Xuất", DateOfBirth = new DateTime(1997, 1, 1), Age = 28, PhoneNumber = "0123456789"},
        new Employee { EmployeeId = 4, FullName = "thịnh", Department = "Sản Xuất", DateOfBirth = new DateTime(1997, 1, 1), Age = 28, PhoneNumber = "0123456789"},
        new Employee { EmployeeId = 5, FullName = "thịnh", Department = "Sản Xuất", DateOfBirth = new DateTime(1997, 1, 1), Age = 28, PhoneNumber = "0123456789"},
        new Employee { EmployeeId = 6, FullName = "thịnh", Department = "Sản Xuất", DateOfBirth = new DateTime(1997, 1, 1), Age = 28, PhoneNumber = "0123456789"},
        new Employee { EmployeeId = 7, FullName = "thịnh", Department = "Sản Xuất", DateOfBirth = new DateTime(1997, 1, 1), Age = 28, PhoneNumber = "0123456789"},
        new Employee { EmployeeId = 8, FullName = "thịnh", Department = "Sản Xuất", DateOfBirth = new DateTime(1997, 1, 1), Age = 28, PhoneNumber = "0123456789"},
        new Employee { EmployeeId = 9, FullName = "thịnh", Department = "Sản Xuất", DateOfBirth = new DateTime(1997, 1, 1), Age = 28, PhoneNumber = "0123456789"},
        new Employee { EmployeeId = 10, FullName = "thịnh", Department = "Sản Xuất", DateOfBirth = new DateTime(1997, 1, 1), Age = 28, PhoneNumber = "0123456789"},
        new Employee { EmployeeId = 11, FullName = "thịnh", Department = "Sản Xuất", DateOfBirth = new DateTime(1997, 1, 1), Age = 28, PhoneNumber = "0123456789"},
        new Employee { EmployeeId = 12, FullName = "thịnh", Department = "Sản Xuất", DateOfBirth = new DateTime(1997, 1, 1), Age = 28, PhoneNumber = "0123456789"},
        new Employee { EmployeeId = 13, FullName = "thịnh", Department = "Sản Xuất", DateOfBirth = new DateTime(1997, 1, 1), Age = 28, PhoneNumber = "0123456789"},
        new Employee { EmployeeId = 14, FullName = "thịnh", Department = "Sản Xuất", DateOfBirth = new DateTime(1997, 1, 1), Age = 28, PhoneNumber = "0123456789"},
        new Employee { EmployeeId = 15, FullName = "thịnh", Department = "Sản Xuất", DateOfBirth = new DateTime(1997, 1, 1), Age = 28, PhoneNumber = "0123456789"},
        new Employee { EmployeeId = 16, FullName = "thịnh", Department = "Sản Xuất", DateOfBirth = new DateTime(1997, 1, 1), Age = 28, PhoneNumber = "0123456789"},
        new Employee { EmployeeId = 17, FullName = "thịnh", Department = "Sản Xuất", DateOfBirth = new DateTime(1997, 1, 1), Age = 28, PhoneNumber = "0123456789"},
        new Employee { EmployeeId = 18, FullName = "thịnh", Department = "Sản Xuất", DateOfBirth = new DateTime(1997, 1, 1), Age = 28, PhoneNumber = "0123456789"},
        new Employee { EmployeeId = 19, FullName = "thịnh", Department = "Sản Xuất", DateOfBirth = new DateTime(1997, 1, 1), Age = 28, PhoneNumber = "0123456789"},
        new Employee { EmployeeId = 20, FullName = "thịnh", Department = "Sản Xuất", DateOfBirth = new DateTime(1997, 1, 1), Age = 28, PhoneNumber = "0123456789"},
        new Employee { EmployeeId = 21, FullName = "thịnh", Department = "Sản Xuất", DateOfBirth = new DateTime(1997, 1, 1), Age = 28, PhoneNumber = "0123456789"},
        new Employee { EmployeeId = 22, FullName = "thịnh", Department = "Sản Xuất", DateOfBirth = new DateTime(1997, 1, 1), Age = 28, PhoneNumber = "0123456789"},
        new Employee { EmployeeId = 23, FullName = "thịnh", Department = "Sản Xuất", DateOfBirth = new DateTime(1997, 1, 1), Age = 28, PhoneNumber = "0123456789"},
        new Employee { EmployeeId = 24, FullName = "thịnh", Department = "Sản Xuất", DateOfBirth = new DateTime(1997, 1, 1), Age = 28, PhoneNumber = "0123456789"},
        new Employee { EmployeeId = 25, FullName = "thịnh", Department = "Sản Xuất", DateOfBirth = new DateTime(1997, 1, 1), Age = 28, PhoneNumber = "0123456789"},
        new Employee { EmployeeId = 26, FullName = "thịnh", Department = "Sản Xuất", DateOfBirth = new DateTime(1997, 1, 1), Age = 28, PhoneNumber = "0123456789"},
        new Employee { EmployeeId = 27, FullName = "thịnh", Department = "Sản Xuất", DateOfBirth = new DateTime(1997, 1, 1), Age = 28, PhoneNumber = "0123456789"},
        new Employee { EmployeeId = 28, FullName = "thịnh", Department = "Sản Xuất", DateOfBirth = new DateTime(1997, 1, 1), Age = 28, PhoneNumber = "0123456789"},
        new Employee { EmployeeId = 29, FullName = "thịnh", Department = "Sản Xuất", DateOfBirth = new DateTime(1997, 1, 1), Age = 28, PhoneNumber = "0123456789"},
        new Employee { EmployeeId = 30, FullName = "thịnh", Department = "Sản Xuất", DateOfBirth = new DateTime(1997, 1, 1), Age = 28, PhoneNumber = "0123456789"},
        new Employee { EmployeeId = 31, FullName = "thịnh", Department = "Sản Xuất", DateOfBirth = new DateTime(1997, 1, 1), Age = 28, PhoneNumber = "0123456789"},
        new Employee { EmployeeId = 32, FullName = "thịnh", Department = "Sản Xuất", DateOfBirth = new DateTime(1997, 1, 1), Age = 28, PhoneNumber = "0123456789"},
        new Employee { EmployeeId = 33, FullName = "thịnh", Department = "Sản Xuất", DateOfBirth = new DateTime(1997, 1, 1), Age = 28, PhoneNumber = "0123456789"},
        new Employee { EmployeeId = 34, FullName = "thịnh", Department = "Sản Xuất", DateOfBirth = new DateTime(1997, 1, 1), Age = 28, PhoneNumber = "0123456789"},
        new Employee { EmployeeId = 35, FullName = "thịnh", Department = "Sản Xuất", DateOfBirth = new DateTime(1997, 1, 1), Age = 28, PhoneNumber = "0123456789"},
        new Employee { EmployeeId = 36, FullName = "thịnh", Department = "Sản Xuất", DateOfBirth = new DateTime(1997, 1, 1), Age = 28, PhoneNumber = "0123456789"},
        new Employee { EmployeeId = 37, FullName = "thịnh", Department = "Sản Xuất", DateOfBirth = new DateTime(1997, 1, 1), Age = 28, PhoneNumber = "0123456789"},
        new Employee { EmployeeId = 38, FullName = "thịnh", Department = "Sản Xuất", DateOfBirth = new DateTime(1997, 1, 1), Age = 28, PhoneNumber = "0123456789"},
        new Employee { EmployeeId = 39, FullName = "thịnh", Department = "Sản Xuất", DateOfBirth = new DateTime(1997, 1, 1), Age = 28, PhoneNumber = "0123456789"},
        new Employee { EmployeeId = 40, FullName = "thịnh", Department = "Sản Xuất", DateOfBirth = new DateTime(1997, 1, 1), Age = 28, PhoneNumber = "0123456789"},
        new Employee { EmployeeId = 41, FullName = "thịnh", Department = "Sản Xuất", DateOfBirth = new DateTime(1997, 1, 1), Age = 28, PhoneNumber = "0123456789"},
        new Employee { EmployeeId = 42, FullName = "thịnh", Department = "Sản Xuất", DateOfBirth = new DateTime(1997, 1, 1), Age = 28, PhoneNumber = "0123456789"},
        new Employee { EmployeeId = 43, FullName = "thịnh", Department = "Sản Xuất", DateOfBirth = new DateTime(1997, 1, 1), Age = 28, PhoneNumber = "0123456789"},
        new Employee { EmployeeId = 44, FullName = "thịnh", Department = "Sản Xuất", DateOfBirth = new DateTime(1997, 1, 1), Age = 28, PhoneNumber = "0123456789"},
        new Employee { EmployeeId = 45, FullName = "thịnh", Department = "Sản Xuất", DateOfBirth = new DateTime(1997, 1, 1), Age = 28, PhoneNumber = "0123456789"},
        new Employee { EmployeeId = 46, FullName = "thịnh", Department = "Sản Xuất", DateOfBirth = new DateTime(1997, 1, 1), Age = 28, PhoneNumber = "0123456789"},
        new Employee { EmployeeId = 47, FullName = "thịnh", Department = "Sản Xuất", DateOfBirth = new DateTime(1997, 1, 1), Age = 28, PhoneNumber = "0123456789"},
        new Employee { EmployeeId = 48, FullName = "thịnh", Department = "Sản Xuất", DateOfBirth = new DateTime(1997, 1, 1), Age = 28, PhoneNumber = "0123456789"},
        new Employee { EmployeeId = 49, FullName = "thịnh", Department = "Sản Xuất", DateOfBirth = new DateTime(1997, 1, 1), Age = 28, PhoneNumber = "0123456789"},
        new Employee { EmployeeId = 50, FullName = "thịnh", Department = "Sản Xuất", DateOfBirth = new DateTime(1997, 1, 1), Age = 28, PhoneNumber = "0123456789"},
        new Employee { EmployeeId = 52, FullName = "Hùng", Department = "Kỹ Thuật", DateOfBirth = new DateTime(1990, 3, 20), Age = 35, PhoneNumber = "0912345678"},
        new Employee { EmployeeId = 53, FullName = "Mai", Department = "Nhân Sự", DateOfBirth = new DateTime(1998, 7, 8), Age = 27, PhoneNumber = "0934567890"},
        new Employee { EmployeeId = 54, FullName = "Tuấn", Department = "Sản Xuất", DateOfBirth = new DateTime(1992, 11, 15), Age = 33, PhoneNumber = "0976543210"},
        new Employee { EmployeeId = 55, FullName = "Hạnh", Department = "Marketing", DateOfBirth = new DateTime(1996, 4, 2), Age = 29, PhoneNumber = "0901122334"},
        new Employee { EmployeeId = 56, FullName = "Sơn", Department = "Kỹ Thuật", DateOfBirth = new DateTime(1994, 9, 21), Age = 31, PhoneNumber = "0988123456"},
        new Employee { EmployeeId = 57, FullName = "Vân", Department = "Kế Toán", DateOfBirth = new DateTime(1991, 12, 10), Age = 34, PhoneNumber = "0911765432"},
        new Employee { EmployeeId = 58, FullName = "Nam", Department = "Nhân Sự", DateOfBirth = new DateTime(1993, 6, 30), Age = 32, PhoneNumber = "0923456789"},
        new Employee { EmployeeId = 59, FullName = "Ly", Department = "Sản Xuất", DateOfBirth = new DateTime(1997, 8, 14), Age = 28, PhoneNumber = "0954321987"},
        new Employee { EmployeeId = 60, FullName = "Quang", Department = "Marketing", DateOfBirth = new DateTime(1999, 2, 5), Age = 26, PhoneNumber = "0965432109"},
        new Employee { EmployeeId = 61, FullName = "Nga", Department = "Kỹ Thuật", DateOfBirth = new DateTime(1995, 10, 19), Age = 30, PhoneNumber = "0932112345"},
        new Employee { EmployeeId = 62, FullName = "Phong", Department = "Kế Toán", DateOfBirth = new DateTime(1989, 1, 25), Age = 36, PhoneNumber = "0909876543"},
        new Employee { EmployeeId = 63, FullName = "Thu", Department = "Nhân Sự", DateOfBirth = new DateTime(1994, 7, 13), Age = 31, PhoneNumber = "0977334455"},
        new Employee { EmployeeId = 64, FullName = "Kiên", Department = "Sản Xuất", DateOfBirth = new DateTime(1992, 5, 18), Age = 33, PhoneNumber = "0944556677"},
        new Employee { EmployeeId = 65, FullName = "Yến", Department = "Marketing", DateOfBirth = new DateTime(1996, 3, 9), Age = 29, PhoneNumber = "0911223344"},
        new Employee { EmployeeId = 66, FullName = "Đạt", Department = "Kỹ Thuật", DateOfBirth = new DateTime(1993, 6, 3), Age = 32, PhoneNumber = "0988445566"},
        new Employee { EmployeeId = 67, FullName = "Trang", Department = "Nhân Sự", DateOfBirth = new DateTime(1998, 11, 27), Age = 27, PhoneNumber = "0922334455"},
        new Employee { EmployeeId = 68, FullName = "Dũng", Department = "Kế Toán", DateOfBirth = new DateTime(1991, 2, 17), Age = 34, PhoneNumber = "0955667788"},
        new Employee { EmployeeId = 69, FullName = "Hòa", Department = "Marketing", DateOfBirth = new DateTime(1990, 4, 4), Age = 35, PhoneNumber = "0978990011"},
        new Employee { EmployeeId = 70, FullName = "Phúc", Department = "Sản Xuất", DateOfBirth = new DateTime(1997, 12, 22), Age = 28, PhoneNumber = "0933557799"},
        new Employee { EmployeeId = 71, FullName = "Thảo", Department = "Kỹ Thuật", DateOfBirth = new DateTime(1999, 9, 1), Age = 26, PhoneNumber = "0911445566"},
        new Employee { EmployeeId = 72, FullName = "Cường", Department = "Kế Toán", DateOfBirth = new DateTime(1995, 8, 6), Age = 30, PhoneNumber = "0921445566"},
        new Employee { EmployeeId = 73, FullName = "Ngọc", Department = "Nhân Sự", DateOfBirth = new DateTime(1993, 3, 11), Age = 32, PhoneNumber = "0944667788"},
        new Employee { EmployeeId = 74, FullName = "Lâm", Department = "Marketing", DateOfBirth = new DateTime(1992, 10, 29), Age = 33, PhoneNumber = "0966998877"},
        new Employee { EmployeeId = 75, FullName = "Hải", Department = "Sản Xuất", DateOfBirth = new DateTime(1998, 1, 7), Age = 27, PhoneNumber = "0907788990"}

      };

      // kích hoạt nó chạy hết 50 dòng bằng foreach
      foreach (var item in employee)
      {
        modelBuilder.Entity<Employee>().HasData(item);
      }

    }
  }
}
