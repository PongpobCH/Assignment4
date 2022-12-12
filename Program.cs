using System;

class Program
{
    
    
    static void Main()
    {
        
        int i = 0;
        Stack<string> stack = new Stack<string>(); 
        string input,input2;
        input = Console.ReadLine();
        
        
        stack.Push(input);

        input2 = Console.ReadLine();

        if(input2 != "2")
        {
            stack.Pop();
        }

        

        if(input != "exit")
        {
            
            Main();
            string value = stack.Pop();
            Console.WriteLine(value);
            
        }

        else
        {
   
            
        }

 
        
    
    }
    
       
}
