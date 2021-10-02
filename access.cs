using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authorization
{
    class access
    {
        private static List<(int id, string name, string password, bool access)> AccessBase = new List<(int id, string name, string password, bool access)>();
        public  void FillAccessBase()
        {
            
            for (int i = 1; i < 6; i++)
            {
                if (i%2==1) AccessBase.Add((i * 10000, "AAA4454545" + i.ToString(), (i * 71 ^ 731*280).ToString(), true));
                else AccessBase.Add((i * 10000, "AAA" + i.ToString(), (i * 71 ^ 731).ToString(), false));
            }
          
        }
        public static void SetRowAccessBase(string name, string password, bool access)
        {
            AccessBase.Add((AccessBase.Count, name, password,access)); 
        }

        public int id()
        {
            return (0);
        }
        public string nameaccess()
        {
            return ("nameaccess");
        }
        public int iduser()
        {
            return (10);
        }
        public bool stus() 
        {
            return (false);
        }
        
        public void ViewAccessBase()
        {
            var AB = AccessBase;
            string[] title = new string[4] { " ID ", " Name ", " Password ", " Admin access " };
            string[] SOut = new string[AB.Count + 4];
            for (int i = 0; i < AB.Count; i++)
            {
                while (title[0].Length < AB[i].id.ToString().Length) title[0] += " ";
                while (title[1].Length < AB[i].name.ToString().Length) title[1] += " ";
                while (title[2].Length < AB[i].password.ToString().Length) title[2] += " ";
                while (title[3].Length < AB[i].access.ToString().Length) title[3] += " ";
            }

            SOut[0] = '\u2554'.ToString();
            SOut[1] = '\u2551'.ToString() + title[0];
            SOut[2] = '\u255F'.ToString();
            SOut[SOut.Count() - 1] = '\u255A'.ToString();
            for (int i = 0; i < title[0].Length; i++)
            {
                SOut[0] += '\u2550'.ToString();
                if (i >= title[0].Length) SOut[1] += " ";
                SOut[2] += '\u2500'.ToString();
                SOut[SOut.Count() - 1] += '\u2550'.ToString();
            }
            for (int i2 = 1; i2 < title.Count(); i2++)
            {
                SOut[0] += '\u2564'.ToString();
                SOut[1] += '\u2502'.ToString() + title[i2];
                SOut[2] += '\u253C'.ToString();
                SOut[SOut.Count() - 1] += '\u2567'.ToString();
                for (int i = 0; i < title[i2].Length; i++)
                {
                    SOut[0] += '\u2550'.ToString();
                    if (i >= title[i2].Length) SOut[1] += " ";
                    SOut[2] += '\u2500'.ToString();
                    SOut[SOut.Count() - 1] += '\u2550'.ToString();
                }
            }

            SOut[0] += '\u2557'.ToString();
            SOut[1] += '\u2551'.ToString();
            SOut[2] += '\u2562'.ToString();
            SOut[SOut.Count() - 1] += '\u255D'.ToString();

            for (int i = 0; i < AB.Count; i++)
            {
                SOut[i + 3] = '\u2551'.ToString() + AB[i].id;
                for (int i2 = 0; i2 < 10; i2++) if (AB[i].id.ToString().Length + i2 < title[0].Length) SOut[i + 3] += " "; else break;
                SOut[i + 3] += '\u2502'.ToString() + AB[i].name;
                for (int i2 = 0; i2 < 10; i2++) if (AB[i].name.Length + i2 < title[1].Length) SOut[i + 3] += " "; else break;
                SOut[i + 3] += '\u2502'.ToString() + AB[i].password;
                for (int i2 = 0; i2 < 10; i2++) if (AB[i].password.Length + i2 < title[2].Length) SOut[i + 3] += " "; else break;
                SOut[i + 3] += '\u2502'.ToString() + AB[i].access;
                for (int i2 = 0; i2 < 10; i2++) if (AB[i].access.ToString().Length + i2 < title[3].Length) SOut[i + 3] += " "; else break;
                SOut[i + 3] += '\u2551'.ToString();
            }
            for (int i = 0; i < AB.Count + 4; i++) Console.WriteLine(SOut[i]);
        }
        
    }
}

