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

      };

      // kích hoạt nó chạy hết 50 dòng bằng foreach
      foreach (var item in employee)
      {
        modelBuilder.Entity<Employee>().HasData(item);
      }

    }
  }
}
