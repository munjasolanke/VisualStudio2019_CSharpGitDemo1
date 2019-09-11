using System;

namespace VisualStudio2019_CSharpGitDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Console.WriteLine("how many years of professional experience do you have");
            string input = Console.ReadLine();

            switch(int.Parse(input))
            {
                case 0:
                    Console.WriteLine("need lots of practrice");
                    break;

                case 1:
                    Console.WriteLine("looks like you need a little more");
                    break;

                case 2:
                    Console.WriteLine("you are doing good");
                    break;

                default:
                    Console.WriteLine("excellent");
                    break;
            }

        }
    }
}
