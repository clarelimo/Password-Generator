using System;
using System.Text;

namespace Password_Generator
{
    class Program
    {
        public static string pass;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the prefered string:");
            pass = Console.ReadLine();
            Console.WriteLine($"Your Password is: {RandomPassword()}");

        }
        public static string RandomString(int size)
        {

            char[] letters = pass.ToCharArray();
            string RandomPass = "";
            Random rnd = new Random();
            for (var i = 0; i < size; i++)
            {
                RandomPass += letters[rnd.Next(0, size)].ToString();
            }
            return RandomPass;

        }
        public static int RandomNumber(int min, int max)
        {
            Random rnd = new Random();
            return rnd.Next(min, max);
        }
        public static string RandomPassword()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(RandomString(4));
            sb.Append(RandomNumber(0, 9));
            sb.Append(RandomString(3));
            return sb.ToString();
        }
    }
}
