namespace OperatorExercise
{
    public class Program
    {
        
        public static double AreaOfCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int sum = a + b;
            int difference = a - b; 
            int product = a * b;
            int quotient = a / b;
            int remainder = a % b;
            
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}.");

            Console.WriteLine("Input the radius of a circle: ");
            double radius = double.Parse(Console.ReadLine());
            double area = AreaOfCircle(radius);
            
            Console.WriteLine($"The area of your circle is {area}. Wow, that's a beautiful circle.\n\n Press any key to continue...");
        }
    }
}
