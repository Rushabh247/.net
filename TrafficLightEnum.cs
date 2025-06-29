

using System;


public class HelloWorld
{
    public enum TrafficLight{
   Red,
   Yellow,
   Green
    
}
    public static void ShowAction(TrafficLight signal){
       switch (signal){
           case TrafficLight.Red :  Console.WriteLine("Signal : Red -> STOP");
           break;
         case TrafficLight.Yellow :  Console.WriteLine("Signal : Yellow -> Get Ready");
           break;
         case TrafficLight.Green :  Console.WriteLine("Signal : Green -> Go");
           break;
           
           
       } 
        
        
    }
    public static void Main(string[] args)
    {
        ShowAction(TrafficLight.Red);
         ShowAction(TrafficLight.Yellow);
          ShowAction(TrafficLight.Green);
        
        
    }
}