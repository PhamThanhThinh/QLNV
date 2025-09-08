using QLNV.Data;

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



  }
}
