using System;

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
            TanjaSvard.Speak();
            Torbjorn.Speak();
            MattiasClass.SpeakTo();
            MasterSpeaker();
           
            Patrik.Speak();
            MasterSpeaker();
            KärbelIlias.Speak();
            AndreHolmlund.Speak();
        }

        static void MasterSpeaker()
        {
            Calle.Speak();
            PerlyGustafsson.Speak();
        }
    }
}
