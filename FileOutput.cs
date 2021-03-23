using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_Java_Animal
{
    public class FileOutput
    {
        StreamWriter streamOut = null;
        private String fileName;

        public FileOutput(String fileName)
        {
            this.fileName = fileName;
            var path = Path.Combine(Environment.CurrentDirectory, fileName);

            try
            {
                streamOut = new StreamWriter(path);
            } catch (FileNotFoundException e)
            {
                Console.WriteLine("File Open Error: " + fileName + " " + e);
            }
        }

        public void FileWrite(String line)
        {
            try
            {
                streamOut.Write(line + "\n");
            } catch (Exception e)
            {
                Console.WriteLine("File Write Error: " + fileName + " " + e);
            }
        }

        public void FileClose()
        {
            if (streamOut != null)
            {
                try
                {
                    streamOut.Close();
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.StackTrace);
                }
            }
        }
    }
}
