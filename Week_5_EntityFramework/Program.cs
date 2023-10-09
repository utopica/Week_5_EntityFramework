
using Week_5_EntityFramework.Entities;

School _context = new();

_context.Students.AddRange(
    new Student { Id = Guid.NewGuid(), FirstName = "Elif", LastName = "Okumuş" },
    new Student { Id = Guid.NewGuid(), FirstName = "Sena", LastName = "Demir" }
    );

_context.SaveChanges();

//Read

var students = _context.Students.ToList();

foreach(var student in students)
{
    Console.WriteLine($"ID: {student.Id}, Name: {student.FirstName} {student.LastName}");
}

//Update

var studentToUpdate = _context.Students.FirstOrDefault(x => x.FirstName == "Sena");
if (studentToUpdate != null)
{
    studentToUpdate.LastName = "Yıldız";
    _context.SaveChanges();
}


//Delete

var studentToDelete = _context.Students.FirstOrDefault(x => x.FirstName == "Elif");
if (studentToDelete != null)
{
    _context.Students.Remove(studentToDelete);
    _context.SaveChanges();
}