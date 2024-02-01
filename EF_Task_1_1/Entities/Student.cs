using EF_Task_1_1.Enums;
namespace EF_Task_1_1.Entities;

public class Student : BaseEntity
{
    // Properties
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string SchoolNumber { get; set; }
    public Gender Gender { get; set; }
    public DateTime BirthDay { get; set; }
    public string PhoneNumber { get; set; }

    // Navigation Properties
    public ICollection<Book> Books { get; set; }
}