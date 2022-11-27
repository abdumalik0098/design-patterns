// nasledovanie
Student student = new Student();
student.fullName = "Oleg";
student.course = 3;

Console.WriteLine(student.fullName);
Console.WriteLine(student.course);

class Person
{
    public int PassportId;
    public string fullName;
}

class Student:Person
{
    public int course;
    public string kafedra;
}
