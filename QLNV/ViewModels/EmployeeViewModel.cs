using System.ComponentModel.DataAnnotations;

namespace QLNV.ViewModels
{
  public class EmployeeViewModel
  {
    // 1 2 3 4 5...
    public int EmployeeId { get; set; }

    // tạo thêm trường dữ liệu tùy chỉnh
    // ví dụ: EMP0001,EMP0002, NV001, NV002, NV01...NV10
    public string EmployeeIdView
    { 
      get
      {
        //return "NV" + EmployeeId.ToString();
        return "NV" + EmployeeId.ToString().PadLeft(4, '0');
      }
    }

    [Required]
    public string FullName { get; set; }

    [Required]
    // phòng ban
    public string Department { get; set; }

    [Required]
    // ngày sinh
    public DateTime DateOfBirth { get; set; }

    [Required]
    // tuổi
    public int Age { get; set; }

    [Required]
    // số điện thoại
    public string PhoneNumber { get; set; }
  }
}
