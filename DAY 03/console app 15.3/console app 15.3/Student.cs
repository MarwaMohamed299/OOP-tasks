using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.ass

  

{
    class Student
    {
        string Firstname;
        string Lastname;
        int Age;
        string address;
        int ssn;

        public Student()

        {
            this.ssn = 0;
            this.Firstname = null;
            this.Lastname = null;
            this.Age = 0;
            this.address = null;
        }

        public void SetSsn(int _ssn) { ssn = _ssn; }
        public int GetSsn() { return ssn; }

        public void SetFirstname(string _firstname) { Firstname = _firstname; }
        public string GetFirstname() { return Firstname; }

        public void SetLastname(string _lastname) { Lastname = _lastname; }
        public string GetLastname() { return Lastname; }

        public void SetAge(int _age)
        {


            {

                if (_age >= 18 || _age <= 30)
                {
                    Age = _age;
                }
                else
                {
                    Console.WriteLine("plz enter age");
                    SetAge(int.Parse(Console.ReadLine()));
                }

            }
        }
        public int GetAge() { return Age; }

        public void SetAddress(string _address)
        {
            while (address != "cairo" && address != "ismailia" && address
                    != "Zagazig")
            {
                Console.WriteLine("plz enter address");
                address = (Console.ReadLine());

            }

        }
        public string getaddress() { return address; }
        public string Prit()
        {
            return $"your student social number is " + this.ssn + "\nyour first name is " + Firstname + "\nyour last name is " + Lastname + "\nyour age is " + Age;

        }



    }

}
