using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RegistrySystem.ProjectFolder

{
    public enum SelectionScreen
    {
        MainMenu,
        BookTicket,
        ClearTicket,
        ReviewTicket,
        EndApplication
    }
    public class Utility
    {
        public static void ClearTicket()
        {
           
        }

        public static string RemoveVowels(string input)
        {
            char[] chars = new char[] {'B','A','D'};
            foreach (char c in chars)
            {
                input = input.Remove(c);
            }


            return input;

        }

        public static void UsingStringEquality()
        {
            string name1 = "A";
            string name2 = "B";

        }
    }

}
