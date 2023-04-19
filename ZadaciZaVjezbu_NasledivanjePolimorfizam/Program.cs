using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadaciZaVjezbu_NasledivanjePolimorfizam
{
    internal class Program
    {

        class Dessert
        {
            string name;
            double weight;
            int calories;
            public string Name { get => name; set => name = value; }
            public double Weight { get => weight; set => weight = value; }
            public int Calories { get => calories; set => calories = value; }

            public Dessert(string name, double weight, int calories)
            {
                this.name = name;
                this.weight = weight;
                this.calories = calories;
            }
            public override string ToString()
            {
                return "Ime desserta je: " + name + ", Teži: " + weight + "g." + " i ima: " + calories + " kalorija.";
            }
            public string getDessertType()
            {
                return "Dessert";
            }
        }

        class Cake : Dessert
        {
            bool containsGluten;
            string cakeType;

            public Cake(string name, double weight, int calories, bool containsGluten, string cakeType) : base(name, weight, calories)
            {
                this.cakeType = cakeType;
                this.containsGluten = containsGluten;
            }

            public bool ContainsGluten { get => containsGluten; set => containsGluten = value; }
            public string CakeType { get => cakeType; set => cakeType = value; }

            public override string ToString()
            {
                return "Ime torte je: " + this.Name + ", Teži: " + this.Weight + "g." + " i ima: " + this.Calories + " kalorija." + " Sadrzi gluten: " + containsGluten + ", vrsta kolaca je: " + cakeType;
            }
            public string getDessertType()
            {
                return "Cake " + cakeType + ".";
            }
        }
        class IceCream : Dessert
        {
            string flavour, color;

            public IceCream(string name, double weight, int calories, string flavour, string color) : base(name, weight, calories)
            {
                this.flavour = flavour;
                this.color = color;
            }

            public string Flavour { get => flavour; set => flavour = value; }
            public string Color { get => color; set => color = value; }

            public override string ToString()
            {
                return "Ime sladoleda je: " + this.Name + ", Teži: " + this.Weight + "g." + " i ima: " + this.Calories + " kalorija." + " Okus je: " + flavour + ", te boja kolaca je: " + color;
            }

            public string getDessertType()
            {
                return "Ice cream";
            }
        }

        class Person
        {
            string name, surname;
            int age;

            public string Name { get => name; set => name = value; }
            public string Surname { get => surname; set => surname = value; }
            public int Age { get => age; set => age = value; }

            public Person(string name, string surname, int age)
            {
                this.name = name;
                this.surname = surname;
                this.age = age;
            }

            public override bool Equals(object obj)
            {
                return obj is Person person &&
                       name == person.name &&
                       surname == person.surname &&
                       age == person.age;
            }

            public override string ToString()
            {
                return "Ime: " + this.Name + ", Prezime: " + this.Surname + ", Godine: " + this.Age;
            }

        }
        class Student : Person
        {
            string studentID;
            short academicYear;

            public Student(string name, string surname, int age, string studentID, short academicYear) : base(name, surname, age)
            {
                this.studentID = studentID;
                this.academicYear = academicYear;
            }

            public string StudentID { get => studentID; set => studentID = value; }
            public short AcademicYear { get => academicYear; set => academicYear = value; }

            public override bool Equals(object obj)
            {
                return obj is Student student &&
                       base.Equals(obj) &&
                       studentID == student.studentID;
            }

            public override string ToString()
            {
                return "Ime: " + this.Name + ", Prezime: " + this.Surname + ", Godine: " + this.Age;
            }
        }

        class Teacher : Person
        {
            string email, subject;
            double salary;

            public string Email { get => email; set => email = value; }
            public string Subject { get => subject; set => subject = value; }
            public double Salary { get => salary; set => salary = value; }
            public Teacher(string name, string surname, int age, string email, string subject, double salary) : base(name, surname, age)
            {
                this.email = email;
                this.subject = subject;
                this.salary = salary;
            }

            public void increaseSalary(int percentage)
            {
                this.salary *= (1 + (percentage / 100));
            } 

            public override string ToString()
            {
                return "Ime: " + this.Name + ", Prezime: " + this.Surname + ", Godine: " + this.Age + ", Predmet: " + this.Subject + "Placa:" + this.salary;
            }

            public override bool Equals(object obj)
            {
                return obj is Teacher teacher &&
                       base.Equals(obj) &&
                       email == teacher.email;
            }


        }
        static void Main(string[] args)
        {

            Teacher t1 = new Teacher("Ivo", "Andrić", 45, "ivoanric@gmail.com", "Matematika", 450.65);
            Teacher t2 = new Teacher("Milorad", "Katić", 35, "milorad@gmail.com", "Povijest", 415.34);
            Teacher t3 = new Teacher("Danijel", "Starić", 29, "ivoanric@gmail.com", "Informatika", 398.14);
            Student s1 = new Student("Dalibor", "Žužić", 18, "15237621523234", 1);
            Student s2 = new Student("Marko", "Petrić", 22, "57878947623567", 5);

            Console.ReadKey();

        }
    }
}
