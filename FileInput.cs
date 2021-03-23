using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adv_Java_Animal
{
    public class FileInput
    {
        private StreamReader streamIn = null;
        private String fileName;

        public FileInput(String filename)
        {
            this.fileName = filename;

            try
            {
                streamIn = new StreamReader(fileName);
            } catch (FileNotFoundException e)
            {
                Console.WriteLine("File Open Error: " + fileName + " " + e);
            }
 
        }

        public void FileRead()
        {
            String line;

            try
            {
                while ((line = streamIn.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            } catch (Exception e)
            {
                Console.WriteLine("File Read Error: " + fileName + " " + e);
            }
        }

        public String FileReadLine()
        {
            try
            {
                String line = streamIn.ReadLine();
                return line;
            } catch (Exception e)
            {
                Console.WriteLine("File Read Line Error: " + fileName + " " + e);
                return null;
            }
        }

        public void FileClose()
        {
            if (streamIn != null)
            {
                try
                {
                    streamIn.Close();
                } catch (IOException e) {
                    Console.WriteLine(e.StackTrace);
                }
            }
        }
    }
}
