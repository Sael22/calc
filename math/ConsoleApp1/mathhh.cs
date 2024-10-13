using System;
using System.Collections;
using System.Diagnostics;
public class mathhh{
    public static void Main(String [] args){
      
        Console.WriteLine("Enter first number:");
   String a = Console.ReadLine();
           Console.WriteLine("Enter second number:");

      String b = Console.ReadLine();
      Console.WriteLine("Choose an operator 1(+) 2(-) 3(*) 4(/)");
      String op = Console.ReadLine();

        int aN = int.Parse(a);
        int bN = int.Parse(b);
        int oper = int.Parse(op);
    switch (oper)
    {
    case 1:
    Console.WriteLine(aN+bN);
    break;

    case 2:
    Console.WriteLine(aN-bN);
    break;

    case 3:
    Console.WriteLine(aN*bN);
    break;

    case 4:
    Console.WriteLine(aN/bN);
    break;

    }
    

    }

    
}