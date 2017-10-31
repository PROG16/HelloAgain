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
            Console.WriteLine(Khalid.Speak());
            AndreasBjörnlund.Speak();
            ErikJonson.Speak();            
            MasterSpeaker();
            Console.ReadLine();
        }

        static void MasterSpeaker()
        {
            Calle.Speak();
        }
    }
}
