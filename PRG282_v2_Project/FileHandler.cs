using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PRG282_v2_Project
{
    class FileHandler
    {
        private string path;

        public FileHandler(string path)
        {
            this.path = path;

            if (File.Exists(this.path) == false)
            {
                FileStream fs = new FileStream(this.path, FileMode.Create, FileAccess.Write);
                fs.Close();
            }
        }

        public List<string> Read()
        {
            List<string> temp = new List<string>();
            try
            {
                using (FileStream fs = new FileStream(this.path, FileMode.Open, FileAccess.Read))
                {
                    StreamReader sr = new StreamReader(fs);
                    string line = string.Empty;
                    while ((line = sr.ReadLine()) != null)
                    {
                        temp.Add(line);
                    }
                }
            }
            catch (FileNotFoundException FnfEx)
            {
                Console.WriteLine(FnfEx.Message);
            }
            return temp;
        }

        public void Write(string text)
        {
            try
            {

            }
            catch (FileNotFoundException FnfEx)
            {
                Console.WriteLine(FnfEx.Message);
            }
            using (FileStream fs = new FileStream(this.path, FileMode.Append, FileAccess.Write))
            {
                StreamWriter sw = new StreamWriter(fs);

                sw.WriteLine(text);
                sw.Close();
            }
        }
    }
}
