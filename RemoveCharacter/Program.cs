using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            Console.WriteLine("Enter The Required Text");
            string text = Console.ReadLine();
            Console.WriteLine("Which Text do you want to remove? Enter Text number \n Smaller than"+ text.Length);
            
            int num = int.Parse(Console.ReadLine());
            if (num> text.Length)
            {
                Console.WriteLine("Enter a small number");
                goto start;
            }
            var result = text.Remove(num,1);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
