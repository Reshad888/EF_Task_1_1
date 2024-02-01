namespace EF_Task_1_1.Entities;

public class BookType : BaseEntity
{
    // Properties
    public string Name { get; set; }

    // Navigation Properties
    public ICollection<Book> Books { get; set; }
}