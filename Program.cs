﻿namespace HelloAgain
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

            MattiasClass.SpeakTo();
            MasterSpeaker();
            MariaKällström.Speak();
           
            Patrik.Speak();
            MasterSpeaker();
            KärbelIlias.Speak();
            Console.ReadLine();
        }

        static void MasterSpeaker()
        {
            Calle.Speak();
            PerlyGustafsson.Speak();
        }
    }
}
