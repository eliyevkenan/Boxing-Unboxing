     using System;

namespace ConsoleApp66
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Student student1=new Student();
            student1.FullName = "Mahmud Esgerov";
            Student student2=new Student();
            student2.FullName = "Cavid Ehmdeov";
            Student student3=new Student();
            student3.FullName = "Emrah Memmedov";

            Group group1 = new Group(GroupType.Desing);
            group1.students=new Student[3];
            Group group2=new Group(GroupType.Programming);
            group2.students=new Student[1];
            Group group3=new Group(GroupType.System);
            group3.students=new Student[2];

            foreach (Student students in group1.students)
            {
                Console.WriteLine(value: $"FullName:{students.FullName} --- GroupNo:{group1.No}");
            }
            foreach (Student students in group2.students)
            {
                Console.WriteLine(value: $"FullName:{students.FullName} --- GroupNo:{group2.No}");
            }
            foreach (Student students in group3.students)
            {
                Console.WriteLine(value: $"FullName:{students.FullName} --- GroupNo:{group3.No}");
            }
        }
    }
}
