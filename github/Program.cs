namespace github
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, I made a change");

            int nummer = 4;
            nummer = adderaMedett(nummer);
            nummer = subtractMedtvå(nummer);
            Console.WriteLine(nummer);
        }

        public static int adderaMedett(int nummer)
        {
            nummer++;
            return nummer;
        }
        public static int subtractMedtvå(int nummer)
        {
            nummer = nummer-2;
            return nummer;
        }
    }
}
