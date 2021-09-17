using System;

class Program {
  public static void Main (string[] args) {
  
    Console.WriteLine ("Enter temperature in Celsius:") ;
    double celsius = Convert.ToDouble(Console.ReadLine());


 double fahrenheit = celsius * 1.8 + 32;
 Console.WriteLine ("Fahrenheit equivalent for " + celsius + " degree celsius is " + fahrenheit ); 

  if (fahrenheit < 32)
  Console.WriteLine("This temperature is below freezing  temperature of 32 degree Fahrenheit");
  if (fahrenheit > 212)
  Console.WriteLine("This temperature is above boiling point temperature of 212 degree Fahrenheit");


  }
}