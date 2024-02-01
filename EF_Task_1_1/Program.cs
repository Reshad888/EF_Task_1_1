// Context (Database) -> Library

// - BaseEntity Class -
// Id, Status, CreatedDate, ModifiedDate

// - Entities (Tables) -
// 1.Students -> Id, FirstName, LastName, SchoolNumber, Gender, BirthDay, PhoneNumber
// 2.Books -> Id, Name, PageCount
// 3.Authors -> Id, FirstName, LastName
// 4.BookTypes -> Id, Name
// 5.Operations -> StartDate, EndDate

// - Enum (Folder) -
// Gender -> Male, Female
// DataStatus -> Inserted, Updated, Deleted

// - Many to many -
// Student with Book

// - One to many -
// Author with Book
// BookType with Book

Console.WriteLine("Hello");