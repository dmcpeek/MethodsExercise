namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            string name = Methods.Name();
            string color = Methods.Color();
            string animal = Methods.Animal();
            string band = Methods.Band();

            Console.WriteLine($"My name is {name}. My favorite color is {color}. My favorite animal is a {animal} and my favorite band is {band}");
            Console.WriteLine("-------------------------------------------------------------------------------------------");

            int int1 = 5;
            int int2 = 10;
            Console.WriteLine($"{int1} + {int2} = {Methods.Addition(int1, int2)}");

            int1 = 17;
            int2 = 17;
            Console.WriteLine($"{int1} - {int2} = {Methods.Subtraction(int1, int2)}");

            int1 = 13;
            int2 = 13;
            Console.WriteLine($"{int1} * {int2} = {Methods.Multiply(int1, int2)}");

            int1 = 12;
            int2 = 4;
            Console.WriteLine($"{int1} / {int2} = {Methods.Divide(int1, int2)}");

            int1 = 13;
            int2 = 2;
            Console.WriteLine($"{int1} % {int2} = {Methods.Modulus(int1, int2)}");
        }
    }
}
