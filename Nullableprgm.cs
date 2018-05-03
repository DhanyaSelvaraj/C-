using System;

namespace Nullableprgm
{
    class Program
    {
        static void Main(string[] args)
        {
            bool? Major = null;
            if(Major==true)
            {
                Console.WriteLine("User is major");
            }
            else if(Major==false)
            {
                Console.WriteLine("user is nor major");
            }
            else
            {
                Console.WriteLine("user did not answer the question");
            }

        }
    }
}
