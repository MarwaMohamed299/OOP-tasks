using System;
namespace STUDENTS
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[3];
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student();

                Console.WriteLine("Enter first Name: ");
                students[i].SetfName(Console.ReadLine());

                Console.WriteLine("Enter last Name: ");
                students[i].SetLName(Console.ReadLine());

                Console.WriteLine("Enter Age between SSN :");
                students[i].SetSsn(Int32.Parse(Console.ReadLine()));

                int age = -1;
                while (age < 18 || age > 30)
                {
                    Console.WriteLine("Enter Age between 18 & 30 :");
                    age = Int32.Parse(Console.ReadLine());
                    students[i].Setage(age);
                }

                string city = "";
                while (city != "Alex" && city != "Ism" && city != "Cairo" && city != "Zagazig")
                {
                    Console.WriteLine("Enter City MUST Be (Alex,Ism,Cairo,Zagazig)");
                    city = Console.ReadLine();
                    students[i].Setaddress(city);
                }
            }
            for (int i = 0; i < students.Length; i++)
            {
                students[i].Print();
            }
        }
    }
}