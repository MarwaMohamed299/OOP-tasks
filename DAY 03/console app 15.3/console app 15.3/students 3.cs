using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
namespace Dcoder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            
            students_3[] stu = new students_3[3];
            for (int i = 0; i < stu.Length; i++)
            {
                stu[i] = new students_3();
                Console.WriteLine("Fname" + i);
                stu[i].setFirstname(Console.ReadLine());
                Console.WriteLine("Lname" + i);
                stu[i].setLastname(Console.ReadLine());
                Console.WriteLine("Age" + i);
                stu[i].setAge(int.Parse(Console.ReadLine()));
                Console.WriteLine("ID" + i);
                stu[i].setId(int.Parse(Console.ReadLine()));
            
            }

            for (int i = 0; i < stu.Length; i++)
            {
                Console.WriteLine(stu[i].getFirstname());
                Console.WriteLine(stu[i].getLastname());
                Console.WriteLine(stu[i].getAge());
                Console.WriteLine(stu[i].getId());
            }
        }
    }

    public class students_3
    {

        private int Id;
        private string Firstname;
        private string Lastname;
        private int age;

        public void setFirstname(string _FirstName)
        {
            this.Firstname = _FirstName;
        }
        public void setLastname(string _Lastname)
        {
            this.Lastname = _Lastname;
        }
        public void setId(int _Id)
        {
            this.Id = _Id;
        }
        public void setAge(int _Age)
        {
            this.age = _Age;
        }
        public string getFirstname()
        {
            return this.Firstname;
        }
        public string getLastname()
        {
            return this.Lastname;
        }
        public int getId()
        {
            return this.Id;
        }
        public int getAge()
        {
            return this.age;
        }
    }
}