using Microsoft.EntityFrameworkCore;
using QLNV.Data;
using QLNV.Data.Entities;
using QLNV.ViewModels;

namespace QLNV.Services
{
  public class EmployeeService
  {
    // tạo hàm dựng constructor
    // destructor (hàm hủy) => c# tự động
    private readonly QLNVDbContext _db;

    public EmployeeService(QLNVDbContext db)
    {
      _db = db;
    }

    // tạo task trong này
    // s ếch
    public async Task<List<EmployeeViewModel>> GetAllEmployees()
    {
      // linq theo kiểu method syntax
      return await _db.Employees
        .OrderBy(x => x.FullName)
        .Select(x => new EmployeeViewModel
        {
          EmployeeId = x.EmployeeId,
          FullName = x.FullName,
          Department = x.Department,
          DateOfBirth = x.DateOfBirth,
          Age = x.Age,
          PhoneNumber = x.PhoneNumber,
        }).ToListAsync();
    }

    public bool CreateEmployee(EmployeeViewModel employeeViewModel)
    {
      try
      {
        // khởi tạo một đối tượng từ DataAccessLayer
        Employee employee = new Employee
        {
          FullName = employeeViewModel.FullName,
          Department = employeeViewModel.Department,
          DateOfBirth = employeeViewModel.DateOfBirth,
          Age = employeeViewModel.Age,
          PhoneNumber = employeeViewModel.PhoneNumber,
        };

        // thêm
        _db.Employees.Add(employee);
        // lưu
        var result = _db.SaveChanges();
        return result > 0;
      }
      catch (Exception ex)
      {
        return false;
      }
    }

  }
}
