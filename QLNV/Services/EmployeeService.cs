using ClosedXML.Excel;
using EFCore.BulkExtensions;
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

    public EmployeeViewModel? FindEmployee(int employeeId)
    {
      var employee = _db.Employees.FirstOrDefault();

      if (employee == null)
      {
        return null;
      }

      EmployeeViewModel employeeViewModel = new EmployeeViewModel
      {
        EmployeeId = employee.EmployeeId,
        FullName = employee.FullName,
        Department = employee.Department,
        DateOfBirth = employee.DateOfBirth,
        Age = employee.Age,
        PhoneNumber = employee.PhoneNumber,
      };

      return employeeViewModel;
    }

    public bool UpdateEmployee(EmployeeViewModel employeeViewModel)
    {
      try
      {
        var employee = _db.Employees.Find(employeeViewModel.EmployeeId);

        if (employee == null)
        {
          return false;
        }

        employee.FullName = employeeViewModel.FullName;
        employee.Department = employeeViewModel.Department;
        employee.DateOfBirth = employeeViewModel.DateOfBirth;
        employee.Age = employeeViewModel.Age;
        employee.PhoneNumber = employeeViewModel.PhoneNumber;

        // lưu
        var result = _db.SaveChanges();
        return result > 0;

      }
      catch (Exception ex)
      {
        return false;
      }
    }

    public bool DeleteEmployee(int employeeId)
    {
      try
      {
        var employee = _db.Employees.Find(employeeId);

        if (employee == null)
        {
          return false;
        }

        _db.Employees.Remove(employee);
        // lưu
        var result = _db.SaveChanges();
        return result > 0;
      }
      catch (Exception ex)
      {
        return false;
      }
    }

    public async Task<bool> ImportEmployee(List<EmployeeViewModel> employees)
    {
      try
      {
        List<Employee> employeeToDB = new List<Employee>();

        foreach (var item in employees)
        {
          Employee employee = new Employee
          {
            FullName = item.FullName,
            Department = item.Department,
            DateOfBirth = item.DateOfBirth,
            Age = item.Age,
            PhoneNumber = item.PhoneNumber,
          };
          employeeToDB.Add(employee);
        }

        await _db.BulkInsertAsync(employeeToDB);
        return true;
      }
      catch (Exception ex)
      {
        return false;
      }
    }

    public async Task<Byte[]> ExportEmployee()
    {
      var data = await GetAllEmployees();
      using (var item = new XLWorkbook())
      {
        var worksheet = item.Worksheets.Add("Employee");

        // headers
        worksheet.Cell(1, 1).Value = "Employee Id";
        worksheet.Cell(1, 2).Value = "FullName";
        worksheet.Cell(1, 3).Value = "Department";
        worksheet.Cell(1, 4).Value = "DateOfBirth";
        worksheet.Cell(1, 5).Value = "Age";
        worksheet.Cell(1, 6).Value = "Phone Number";

        for (int i = 0; i < data.Count; i++)
        {
          // 1 -> NV001
          worksheet.Cell(i + 2, 1).Value = data[i].EmployeeIdView;
          worksheet.Cell(i + 2, 2).Value = data[i].FullName;
          worksheet.Cell(i + 2, 3).Value = data[i].Department;
          worksheet.Cell(i + 2, 4).Value = data[i].DateOfBirth;
          worksheet.Cell(i + 2, 5).Value = data[i].Age;
          worksheet.Cell(i + 2, 6).Value = data[i].PhoneNumber;
        }

        using (var stream = new MemoryStream())
        {
          item.SaveAs(stream);
          return stream.ToArray();
        }

      }
    }

  }
}
