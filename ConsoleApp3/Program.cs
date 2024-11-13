namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Result is: " + SumNumbers(firstNumber, secondNumber));
        }

        public static int SumNumbers(int num01, int num02)
        {
            return num01 + num02;
        }
    }
}
