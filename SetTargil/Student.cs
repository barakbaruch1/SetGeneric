using System;
using System.Collections.Generic;
using System.Text;

namespace SetTargil
{
    class Student
    {
        private static int counter;
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Grade { get; private set; }

        public Student()
        {
            counter++;
            Id = counter;
        }

        public Student(string name,int grade) : this()
        {
            Name = name;
            Grade = grade;
        }

        public override bool Equals(object obj)
        {
            Student otherStudent = obj as Student;
            if (otherStudent == null) return false;
            if (this.Id == otherStudent.Id)
                return true;
            return false;
        }

        public override string ToString()
        {
            return $"{Id} {Name} {Grade}";
        }

    }
}
