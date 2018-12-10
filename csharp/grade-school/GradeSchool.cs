using System;
using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{
    private readonly List<Student> _students = new List<Student>();

    public void Add(string student, int grade)
    {
        _students.Add(new Student(student, grade));
    }

    public IEnumerable<string> Roster()
    {
        return _students
            .OrderBy(s => s.Grade)
            .ThenBy(s => s.Name)
            .Select(s => s.Name);
    }

    public IEnumerable<string> Grade(int grade)
    {
        return _students
            .Where(s => s.Grade == grade)
            .OrderBy(s => s.Grade)
            .ThenBy(s => s.Name)
            .Select(s => s.Name);
    }
}

public class Student
{
    public String Name;
    public int Grade;

    public Student(string name, int grade)
    {
        Name = name;
        Grade = grade;
    }
}