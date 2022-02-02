using System;

namespace Program
{

    class ExString
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("============== FINDING THE LENGTH OF A STRING ==============");
            string s;
            Console.WriteLine($"Enter a String : ");
            s = Console.ReadLine();

            Console.WriteLine($"The length of the String is : {s.Length}\n");




            Console.WriteLine("============== Checking The Type of The String ==============");
            Console.WriteLine($"Enter a String : ");
            s = Console.ReadLine();

            int len = s.Length;

            if ((char)s[len - 1] == '.')
            {
                Console.WriteLine($"String \"{s}\" is Declarative Sentence");
            }
            else if ((char)s[len - 1] == '!')
            {
                Console.WriteLine($"String \"{s}\" is Exclamation Sentence\n");
            }
            else if ((char)s[len - 1] == '?')
            {
                Console.WriteLine($"String \"{s}\" is Interrogatory Sentence");
            }
            else
            {
                Console.WriteLine($"String \"{s}\" is not a  Sentence");
            }

            Console.WriteLine("============== Enter First Name And Last Name Seperated By Space ==============");
            Console.WriteLine("Enter your full name : ");
            string ss = Console.ReadLine();
            int size = ss.Length;
            int index = ss.IndexOf(" ");


            if (index != -1)
            {
                // Console.WriteLine($"{index}");
                // Console.WriteLine($"{len}");

                string firstName = ss.Substring(0, index);
                string lastName = ss.Substring(index + 1, size);
                Console.WriteLine($"{firstName} , {lastName}");
            }
            else
                Console.WriteLine($"{ss}");
        }
    }
}
