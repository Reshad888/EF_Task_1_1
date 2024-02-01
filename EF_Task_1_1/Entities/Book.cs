namespace EF_Task_1_1.Entities;

public class Book : BaseEntity
{
    // Properties
    public string Name { get; set; }
    public int PageCount { get; set; }

    // Foreign Keys
    public int AuthorId { get; set; }
    public int BookTypeId { get; set; }

    // Navigation Properties
    public Author Author { get; set; }
    public BookType BookType { get; set; }
    public ICollection<Student> Students { get; set; }
}