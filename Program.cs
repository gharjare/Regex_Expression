namespace RegularExpression1
{
    class program
    {
        public static void Main(string[] args)
        {
            Pattern pattern = new Pattern();
            Console.WriteLine("please enter the pattern");
            string upper = Console.ReadLine();

            bool value = pattern.ValidateUpper(upper);

            if (value)
            {
                Console.WriteLine("pattern is match");
            }
            else
            {
                Console.WriteLine("pattern is not match");
            }
        }
    }
}