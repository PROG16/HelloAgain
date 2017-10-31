namespace HelloAgain.Students
{
    public static class MarcusHultkrantz
    {
        public static string Speak()
        {
            var speak = "";
            for (int i = 0; i < 5; i++)
            {
                speak += "All hail MarcKussss!!!!";
            }
            return speak;
        }

        public static string Mute()
        {
            return Console.ReadLine();
        }
    }
}
