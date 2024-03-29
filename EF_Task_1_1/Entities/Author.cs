﻿namespace EF_Task_1_1.Entities;

public class Author : BaseEntity
{
    // Properties
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Navigation Properties
    public ICollection<Book> Books { get; set; }
}