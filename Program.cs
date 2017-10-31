using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            FredrikHaglund.Speak();
            Console.WriteLine(MarcusHultkrantz.Speak());
            AndreasBjörnlund.Speak();
            ErikJonson.Speak();
            Console.ReadLine();
            MasterSpeaker();
        }

        static void MasterSpeaker()
        {
            Calle.Speak();
        }
    }
}
