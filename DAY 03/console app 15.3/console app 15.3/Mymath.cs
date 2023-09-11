using System.ComponentModel;
using System.Numerics;
using System.Runtime.InteropServices;
using System;

namespace calculator

{

    public class Calculator
    {
        static void Main(string[] args)
        {


            operat cal = new operat();
            do
            {

                Console.Write("Enter 1st number:");
                cal.setFirstnumber(int.Parse(Console.ReadLine()));

                Console.Write("Enter 2nd number:");
                cal.setSecondnumber(int.Parse(Console.ReadLine()));

                Console.Write("Enter (/,+,-,*):");
                cal.setOperation(Console.ReadLine()[0]);
                switch (cal.getOperation())
                {
                    case '+':

                        Console.WriteLine("the Answer: " + cal.Add());
                        break;
                    case '-':
                        Console.WriteLine("the Answer: " + cal.Sub());

                        break;
                    case '*':
                        Console.WriteLine("the Answer: " + cal.Mul());

                        break;
                    case '/':
                        Console.WriteLine("the Answer: " + cal.Div());

                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }

                Console.Write("Do u want to continue y/n):");

            } while (Console.ReadLine()[0] == 'y');
        }

    }

    class operat
{

    float Firstnum;
    float Secondnum;
    char oper;
    float result;


    public void setFirstnumber(float num1)
    { this.Firstnum = num1; }
    public void setSecondnumber(float num2)
    { this.Secondnum = num2; }
    public void setOperation(char o)
    {
        if (o == '*' || o == '+' || o == '-' || o == '/')
        {
            this.oper = o;
        }
        else
        {
            Console.WriteLine("wrong operator try another one" + o);
        }
    }
    public float getResult()
    {
        return result;

    }
    public char getOperation()
    {
        return oper;
    }
    public float getFirstnumber()
    {
        return Firstnum;
    }

    public float getsecondnumber()
    { return Secondnum; }


    public float Add() { return Firstnum + Secondnum; }
    public float Sub() { return Firstnum - Secondnum; }
    public float Mul() { return Firstnum * Secondnum; }
    public float Div() { return Firstnum / Secondnum; }

}
    
}



