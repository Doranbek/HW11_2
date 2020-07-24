using System;
using System.Collections.Generic;
using System.Text;

namespace HW11_2
{
    class Student
    {
        private string fullName;
        private string group;
        private string facultet;
        private int Cours { get; set; } = 1;
        private int age=18;
        private string DateOfBirth { get; set; }
        private string Gender { get; set; }
               
        public string FullName
        {
            get { return fullName; }
            private set
            {                
                if (value != "") fullName = value;
                else Console.WriteLine("Значение FullName пустое");            
            }
        }

        public string Group
        {
            get { return group; }
            private set
            {
                if (value == "") Console.WriteLine("Значение Group пустое");
                else group = value;
            }
        }

        public string Facultet
        {
            get { return facultet; }
            private set
            {
                if (value == "") Console.WriteLine("Значение Facultet пустое");
                else facultet = value;
            }
        }
        
        public int Age
        {
            get { return age; }
            private set
            {
                if (value < 17 || value > 99)
                {
                    
                    Console.WriteLine("Возраст должен быть больше 16 и меньше 99");
                }
                else age = value;
            }

        }       

        public Student() { }

        public Student(string fullName, string group, string facultet, int cours, int age, string dateOfBirth, string gender)
        {
            FullName = fullName;
            Group = group;
            Facultet = facultet;
            Cours = cours;
            Age = age;
            DateOfBirth = dateOfBirth;
            Gender = gender;
        }
       
        public void SetFullName(string fullName)
        {
            FullName = fullName;
        }
        
        public void GetFullName()
        {
            Console.WriteLine($"\nФИО: {FullName}");
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
