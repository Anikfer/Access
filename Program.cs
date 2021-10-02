using System;

namespace Authorization
{
    class Program
    {
        static void Main(string[] args)
        {
            access A = new access();
            A.FillAccessBase();
            User U = new User();
            U.GetUser();
            U.GetUser();
            
            A.ViewAccessBase();
            Console.Read();

        }
    }
}
