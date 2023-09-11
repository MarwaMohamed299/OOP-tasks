
using System;
using System.Collections;

class mystack
{

    
    public static  void Main()
    {

      
        Stack my_stack = new Stack();

        
        my_stack.Push("oral surgery");
        my_stack.Push("oral medicine");
        my_stack.Push("biology");
        my_stack.Push("fixed prodthodontics");

        Console.WriteLine(" subjects present in" +
                    " my_stack: {0}", my_stack.Count);

      
        Console.WriteLine("first upper subject in my_stack"
                        + " is: {0}", my_stack.Pop());

        Console.WriteLine(" elements present in" +
                    " my_stack: {0}", my_stack.Count);

        
        Console.WriteLine("first element of my_stack " +
                            "is: {0}", my_stack.Peek());


        Console.WriteLine("Total subjects present " +
                "in my_stack: {0}", my_stack.Count);

    }
}
