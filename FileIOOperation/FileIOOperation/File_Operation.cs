using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOOperation
{
    public class File_Operation
    {
        string path = @"C:\Users\HP\Desktop\RFP-288\FileIO\FileIO_Problem\FileIO_Oprations\FileIOOperation\FileIOOperation\Files\Kiran.txt";
        public void File_Exist()
        {
            if(File.Exists(path))
            {
                Console.WriteLine("The given file exist");
            }
            else
            {
                Console.WriteLine("The given file does not exist");
            }
        }
       
    }
}
