using Microsoft.EntityFrameworkCore;
using QLNV.Data;
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
          FullName = x.FullName,
          Department = x.Department,
          DateOfBirth = x.DateOfBirth,
        }).ToListAsync();
    }
  }
}
