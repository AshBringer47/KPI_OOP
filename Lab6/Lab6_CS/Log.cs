using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Lab6_CS
{
    public class Log
    {
        public void LogException(Exception e)
        {
            string filename = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "log.txt"); // finds path to the directory with code.
            void LogToFile(StreamWriter file) // writes exception data to file.
            {
                file.Write("{0}:{1}\n\n", DateTime.Now, e);
            }
            if(!File.Exists(filename)) // if this code is executed for the first time.
            {
                using (StreamWriter file = new StreamWriter(filename))
                {
                    file.WriteLine("Creation date: {0}\nLogs for file: {1}", DateTime.Now, GetType().Name, "\n");
                    LogToFile(file); 
                }                    
            }
            else // if this code has already been executed.
            {
                using (StreamWriter file = File.AppendText(filename)) 
                    LogToFile(file);
            }
        }
    }
}
