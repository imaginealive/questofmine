using System;

namespace capquest
{
    class Program
    {
        static void Main(string[] args)
        {
            var code = new Code();
            Console.Write("Enter Sum : ");
            var sum = double.Parse(Console.ReadLine());
            var answer = code.calculate(sum);
            Console.WriteLine(answer);
        }
    }
}
