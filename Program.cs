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
            MarcusHultkrantz.Mute();
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
            AndreHolmlund.Speak();
            JohannesSmidelöv.GreetWorld();
            var dannysSingleton = DannyBoy.Instance;
            dannysSingleton.MakeTheSound();
            Console.ReadLine();
            
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
                Console.WriteLine("Mir was here.");
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
