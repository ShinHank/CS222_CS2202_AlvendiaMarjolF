using System;

public class LabAct1
{
    public static void Main(string[] args)
    {
        Pentagon p1 = new Pentagon(0);
        Console.WriteLine("Pentagon p1");
        p1.Display();
        Pentagon p2 = new Pentagon(5);
        Console.WriteLine("Pentagon p2");
        p2.Display();
       
    }
    
    public class Pentagon
    {
        private double side;
        
        public Pentagon(double side = 0){
            this.side = side;
        }
        
        public double GetPerimeter(){
        return side * 5;   
        }

        public double GetArea(){
        double s = side * side;
        return (Math.Sqrt(5 * (5 + (2 * Math.Sqrt(5)))) * s)/4;
        }
    
        public void Display(){
        Console.WriteLine("-------------------------");    
        Console.WriteLine($"Side length:  {this.side}");
        Console.WriteLine($"Perimeter:  {GetPerimeter():F3}");
        Console.WriteLine($"Area: {GetArea():F3}");
        Console.WriteLine();
        }
    }
}
