using System;

 class HelloWorld
{
    static bool iseven(int n){
        return (n%2==0);
    
    }
    
     static void Main()
    
    {
        int n=21;
       if(iseven(n)==(true)) Console.WriteLine("Number is Even");
        else Console.WriteLine("Number is odd");
        
        
    }
}