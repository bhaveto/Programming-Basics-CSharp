using System;
namespace password
{
    class password
    {
        static void Main(string[] args)
        {
            string pass = "s3cr3t!P@ssw0rd";
            string userPass = Console.ReadLine();
            if (pass == userPass)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}