

using Library;
Book book1 = new Book("C# Basics", "John Doe");
Book book2 = new Book("ASP.NET", "James");
Book book3 = new Book("CSS", "Ahmad");
StudentMember student1 = new StudentMember(1, "Ahmad");
TeacherMember teacher1 = new TeacherMember(1, "Sara");

StudentMember student2 = new StudentMember(2, "Khaled");
StudentMember student3 = new StudentMember(3, "Ali");
StudentMember student4 = new StudentMember(4, "Basel");


// Simulate borrowing and returning with penalty
Console.WriteLine("Senario 1 the student borrow book then return it after 4 days  with penalty = daysLate * 0.5");
Console.WriteLine("--------------------------------------------------------------------------------------------");
student1.BorrowBook(book1);
int lateDaysStudent = 4;
student1.ReturnBook(book1);
Console.WriteLine($"{student1.Name} returned '{book1.Title}' {lateDaysStudent} days late. Penalty= {student1.CalculateLateFee(lateDaysStudent)} JOD.");
Console.WriteLine("\n");
Console.WriteLine("Senario 2 the teacher borrow book then return it after 5 days with penalty = daysLate * 0.2 ");
Console.WriteLine("--------------------------------------------------------------------------------------------");
teacher1.BorrowBook(book3);
int lateDaysTeacher = 5;
teacher1.ReturnBook(book3);
Console.WriteLine($"{teacher1.Name} returned '{book1.Title}' {lateDaysTeacher} days late. Penalty= {teacher1.CalculateLateFee(lateDaysTeacher)} JOD.");

Console.WriteLine("\n");
Console.WriteLine("Senario 3 the student borrow book then other students or Teachers try to borrow the same book ");
Console.WriteLine("----------------------------------------------------------------------------------------------");
student2.BorrowBook(book2);
student3.BorrowBook(book2);
student4.BorrowBook(book2);
teacher1.BorrowBook(book2);

Console.ReadKey();

