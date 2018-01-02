using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentNo17
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "lord of the rings";
            Console.WriteLine(name.CapitalizeFirstLetter());
        }
    }

    public static class MyExtensions
    {
        public static string CapitalizeFirstLetter(this string value)
        {
            char[] letters = value.ToLower().ToCharArray();
            if (letters.Length >= 1)
            {
                if (char.IsLower(letters[0]))
                {
                    letters[0] = char.ToUpper(letters[0]);
                }
            }
            for (int i = 1; i < letters.Length; i++)
            {
                if (letters[i - 1] == ' ')
                {
                    if (char.IsLower(letters[i]))
                    {
                        letters[i] = char.ToUpper(letters[i]);
                    }
                }
            }
            return new string(letters);
        }
    }
}
