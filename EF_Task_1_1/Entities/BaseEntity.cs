namespace EF_Task_1_1.Entities;

public abstract class BaseEntity
{
    // Properties
    public int Id { get; set; }
    public string? Status { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set;}

    // Constructor
    public BaseEntity()
    {
        CreatedDate = DateTime.Now;
    }
}