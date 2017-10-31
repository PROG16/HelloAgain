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
<<<<<<< HEAD
            Console.WriteLine(Khalid.Speak());
=======
            AndreasBjörnlund.Speak();
<<<<<<< HEAD
>>>>>>> a11dfecc04b02dff56f9d68586c07bd4bc586886
=======
            ErikJonson.Speak();
>>>>>>> 6e401ca1c452c41a46587757d6b7514127c2637d
            Console.ReadLine();
            MasterSpeaker();
        }

        static void MasterSpeaker()
        {
            Calle.Speak();
        }
    }
}
