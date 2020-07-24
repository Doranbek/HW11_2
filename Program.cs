using System;

namespace HW11_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Student student1 = new Student("Дмитрий Медведев Анатольевич", "CS2010", "JavaScript", 2, 55, "1965.09.14", "M");
            
            Student student2 = new Student("Сергей Собянин Семенович", "CS2011", "C#", 1, 54, "1966.03.03", "M");

            student1.GetFullName();
            
            student2.SetFullName("Михаил Мишустин Владимирович");

            student2.Info();
            
            student1.Transfer("CS2001", "C#");
           
            student1.Info();
            
            student1.Transfer("", "");  
            
            student1.Info();
            
            
            
        }
    }
}
