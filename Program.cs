using System;

namespace HelloAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            FredrikHaglund.Speak();
            while (true)
            {
                Console.WriteLine(MarcusHultkrantz.Speak());
            }
            Console.WriteLine(Khalid.Speak());
            AndreasBjörnlund.Speak();
            ErikJonson.Speak();
            TanjaSvard.Speak();
            Torbjorn.Speak();
            MattiasClass.SpeakTo();
            Console.ReadLine();
            MasterSpeaker();
            KärbelIlias.Speak();
            CorneliaKarlslund.Speak();
        }

        static void MasterSpeaker()
        {
            Calle.Speak();
            PerlyGustafsson.Speak();
        }
    }
}
