using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STUDENTS
{
    struct Student
    {
        int Ssn;
        public void SetSsn(int _Ssn)
        {
            this.Ssn = _Ssn;
        }
        public int GetSsn()
        {
            return this.Ssn;
        }
        string fName;
        public void SetfName(string fName)
        {
            this.fName = fName;
        }
        public string GetfName()
        {
            return this.fName;
        }

        string LName;
        public void SetLName(string LName)
        {
            this.LName = LName;
        }
        public string GetLName()
        {
            return this.LName;
        }
        int Age;
        public void Setage(int Age)
        {
            this.Age = Age;
        }
        public int GetAge()
        {
            return this.Age;
        }
        string Address;
        public void Setaddress(string Address)
        {
            this.Address = Address;
        }
        public string GetAddress()
        {
            return this.Address;
        }



        public void Print()
        {
            Console.WriteLine($"Name => {fName} {LName} \nSSN => {Ssn} \nAge => {Age} \nAddress => {Address}");
        }
        public string PrintV2()
        {
            return $"Name => {fName} {LName} \nSSN => {Ssn} \nAge => {Age} \nAddress => {Address}";
        }
    }
}