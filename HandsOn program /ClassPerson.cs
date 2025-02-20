using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Class person, student and teacher
/* Create a new C # project with three classes plus another class to test the logic in your code. The main classes of the program are the following classes:

Person
Student
Professor
The Student and Teacher classes inherit from the Person class.

The Student class will include a public Study() method that will write I'm studying on the screen.

The Person class must have two public methods Greet() and SetAge(int age) that will assign the age of the person.

The Teacher class will include a public Explain() method that will write I'm explaining on the screen.

Also create a public method ShowAge() in the Student class that writes My age is: x years old on the screen.

You must create another test class called StudentProfessorTest with a Main method to do the following:
Output:
Hello!
Hello!
My age is 21 years old
I'm studying
Hello!
I'm explaining */

Create a new Person and make him say hello
Create a new Student, set an age, say hello, and display her age on the screen.
Create a new Teacher, set an age, say hello and start the explanation.
namespace c_training
{
    public class ClassPerson
    {
        protected int age;
        public void Greet()
        {
            Console.WriteLine("Hello!");
        }
        public void SetAge(int age)
        {
            this.age = age;
        }
    }
    public class Student : ClassPerson
    {
        public void Study()
        {
            Console.WriteLine("I'm studying");
        }
        public void ShowAge()
        {
            Console.WriteLine($"My age is: {age} years old");
        }
    }
    public class Professor : ClassPerson
    {
        public void Explain()
        {
            Console.WriteLine("I'm explaining");
        }
    }
}

// Object 
ClassPerson person = new ClassPerson();
person.Greet();

Student student = new Student();
student.Greet();
student.SetAge(21);
student.ShowAge();
student.Study();

Professor teacher = new Professor();
teacher.Greet();
teacher.SetAge(40);
teacher.Explain();
