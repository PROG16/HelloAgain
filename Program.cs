using HelloAgain.Students;
using System;

namespace HelloAgain
{
    public class Program
    {
        static void Main(string[] args)
        {
            FredrikHaglund.Speak();
            //TODO Mute Marcus
            Console.WriteLine(MarcusHultkrantz.Speak());
            AndreasBjörnlund.Speak();
            Console.ReadLine();
        }
    }
}
