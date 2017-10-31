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
            Jesper.Speak();
            ErikJonson.Speak();
            MirAlbertioni.MirAlb();
            TanjaSvard.Speak();
            Torbjorn.Speak();
            MattiasClass.SpeakTo();
            MasterSpeaker();
            KlasHasselquist.Speak();
            MariaKällström.Speak();           
            Patrik.Speak();
            KärbelIlias.Speak();
            CorneliaKarlslund.Speak();
            Console.ReadLine();
            AndreHolmlund.Speak();
        }

        static void MasterSpeaker()
        {            
            Calle.Speak();
            PerlyGustafsson.Speak();
        }

        internal class TanjaSvard
        {
            public static void Speak()
            {
                Console.WriteLine("Tanja was here.");
            }
        }

        internal class Patrik
        {
            public static void Speak()
            {
                Console.WriteLine("Tanja was here.");
            }
        }

        internal class MirAlbertioni
        {
            public static void MirAlb()
            {
                Console.WriteLine("Tanja was here.");
            }
        }

        internal class MariaKällström
        {
            public static void Speak()
            {
                Console.WriteLine("Tanja was here.");
            }
        }
    }
}
