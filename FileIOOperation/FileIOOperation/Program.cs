using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOOperation
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                File_Operation file_Operation = new File_Operation();

                Console.WriteLine("1-Check file exist or note");
                Console.WriteLine("CHOOSE ABOVE OPTION");
                int option=Convert.ToInt32(Console.ReadLine());
                bool check = true;
                switch (option)
                {
                    case 1:
                        file_Operation.File_Exist();
                        break;
                    
                }
            }
        }
    }
}
