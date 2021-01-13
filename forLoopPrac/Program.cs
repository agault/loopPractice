using System;
using System.Dynamic;

namespace forLoopPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            //For loop:
            for (var i=0; i<=10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            //Foreach loop:
       
            var name = "Ranger Danger";
            foreach (var character in name)
            {
                Console.WriteLine(character);
            }

            var numbers = new int[] {1, 2, 3, 4, 9};
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            //while loop:

            var j = 0;

            while (j <= 10)
            {
                if (j % 2 == 0)
                    Console.WriteLine(j);
                
                j++;
            }

            while (true)
            {
                Console.Write("Your name:");
                var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                    break;
                Console.WriteLine("@Echo: " + input);

            }
            

        } 
    }
}
