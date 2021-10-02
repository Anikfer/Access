using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authorization
{
    class User
    {
        /*
       //Неккоректное поведение программы  при применении данной подпрограммы.
       // К примеру добаление 4й переменной в строку в основном классе вызывает некорректное положение данных в строке
        private static string HideCharacter()
         
        {
           ConsoleKeyInfo key;
            string code = "";
            do
            {
                key = Console.ReadKey(true);
                if (Char.IsNumber(key.KeyChar))
                {
                    Console.Write("*");
                }
                code += key.KeyChar;
            } while (key.Key != ConsoleKey.Enter);
            return code;
        }
        */
        private static bool NotTrueCharacter(string St)
        {
            bool GorN = false;
            int i = 0;
            int iCh = 0;
            foreach (char Ch in St)
            {
                i++;
                iCh = (int)Ch;
                //Латиница A..Z , Латиница a..z, числа 0..9
                if ((iCh >= 65 && iCh <= 90) || (iCh >= 97 && iCh <= 122) || (iCh >= 48 && iCh <= 57))
                { }
                else
                {
                    Console.WriteLine($"Ошибка в {i} символе");
                    GorN = true;
                }
            }
            if (GorN)
            {
                Console.WriteLine("Возможны только символы Латиницы большие А-Z , малые a-z, и цифры 0-9.");
                Console.WriteLine("Для выхода закройте программу или попробуйте ввести правильный логин");
            }
            return GorN;
        }
        
        string Name = "";
        string Password = "";
        ConsoleKeyInfo Access;

        public void GetUser()
        {
            do
            {
                Console.Write("Введите Логин=");
                Name = Console.ReadLine();
            }
            while (NotTrueCharacter(Name));
            if (Name != "")
            {
                do
                {
                    Console.Write("Введите Пароль=");
                    Password = Console.ReadLine();
                    Console.WriteLine();
                }
                while (NotTrueCharacter(Password));
            }
            Console.Write("Уровень доступа Admin. Ведите символ Y/N или y/n=");
            do
            {
                Access = Console.ReadKey(true);
                if (Access.KeyChar == 'Y') Console.Write("Y");
                if (Access.KeyChar == 'N') Console.Write("Y");
                if (Access.KeyChar == 'y') Console.Write("y");
                if (Access.KeyChar == 'n') Console.Write("n");
            }
            while (Access.KeyChar!='Y'&& Access.KeyChar != 'N' && Access.KeyChar != 'y' && Access.KeyChar != 'n');
            Console.WriteLine();
            if (Access.KeyChar == 'Y' || Access.KeyChar == 'y') access.SetRowAccessBase(Name, Password, true);
            else access.SetRowAccessBase(Name, Password, false);

        }
           
        public int id()
        {
            int Id = -1;
            return (Id);
        }

        public string name()
        {
            return (Name);
        }

        public string password()
        {
            return (Password);
        }

    }
}
