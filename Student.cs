using System;
using System.Collections.Generic;
using System.Text;

namespace HW11_2
{
    class Student
    {
        private string firstName;
        private string lastName;
        private string patronymic;
        private string group;
        private string facultet;
        private int Cours { get; set; } = 1;
        private int age;
        private string DateOfBirth { get; set; }
        private string Gender { get; set; }
        public string FirstName
        {
            get { return firstName; }
            private set
            {
                if (value == "")
                {
                    Console.WriteLine("Значение FirstName пустое");
                }

                firstName = value;
            }
        }
        public string LastName
        {
            get { return lastName; }
            private set
            {
                if (value == "") Console.WriteLine("Значение LastName пустое");
                lastName = value;
            }
        }
        public string Patronymic
        {
            get { return patronymic; }
            private set
            {
                if (value == "") Console.WriteLine("Значение Patronymic пустое");
                patronymic = value;
            }
        }
        public string Group
        {
            get { return group; }
            private set
            {
                if (value == "") Console.WriteLine("Значение Group пустое");
                group = value;
            }
        }

        public string Facultet
        {
            get { return facultet; }
            private set
            {
                if (value == "") Console.WriteLine("Значение Facultet пустое");
                facultet = value;
            }
        }
        public int Age
        {
            get { return age; }
            private set
            {
                if (value < 17 || value > 99)
                {
                    value = 18;
                    Console.WriteLine("Возраст должен быть больше 16 и меньше 99");
                }
                age = value;
            }

        }
        public string FullName
        {
            get { return $"{LastName} {FirstName.Substring(0, 1)}.{Patronymic.Substring(0, 1)}."; }
        }

        public Student() { }

        public Student(string firstName, string lastName, string patronymic, string group,
                    string facultet, int cours, int age, string dateOfBirth, string gender)
        {
            FirstName = firstName;
            LastName = lastName;
            Patronymic = patronymic;
            Group = group;
            Facultet = facultet;
            Cours = cours;
            Age = age;
            DateOfBirth = dateOfBirth;
            Gender = gender;
        }
        public void SetFullName(string firstName, string lastName, string patronymic)
        {
            FirstName = firstName;
            LastName = lastName;
            Patronymic = patronymic;
        }
        public void GetFullName()
        {
            Console.WriteLine($"\nФамилия:{LastName}\nИмя:{FirstName}\nОтчество:{Patronymic}");
        }
        public void Info()
        {

            Console.WriteLine($"\nФИО студента:{FullName}\nГруппа:{Group}\nФакультет:{Facultet}"
                   + $"\nКурс:{Cours}\nВозраст:{Age} лет\nДата рождения:{DateOfBirth}\nПол:{Gender}");
        }

        public void Transfer(string group, string facultet)
        {
            Group = group;
            Facultet = facultet;
        }

    }
}
