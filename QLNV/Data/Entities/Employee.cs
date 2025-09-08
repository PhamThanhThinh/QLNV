using System.ComponentModel.DataAnnotations;

namespace QLNV.Data.Entities
{
  public class Employee
  {
    [Key]
    public int EmployeeId { get; set; }
    public string FullName { get; set; }

    // phòng ban
    public string Department { get; set; }

    // ngày sinh
    public DateTime DateOfBirth { get; set; }

    // tuổi
    public int Age { get; set; }

    // số điện thoại
    public string PhoneNumber { get; set; }

  }
}
