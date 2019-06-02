using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Week7aWantsomeHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            //reading with File.ReadAllText
            string path = @"C:\Windows\win.ini";
            try
            {
                Console.WriteLine(File.ReadAllText(path));
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"Cannot find the file {path}");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine($"Invalid Directory in file path {path}");
            }
            catch (IOException)
            {
                Console.WriteLine($"Cannot open the file {path}");
            }

            //using StreamReader
            try
            {
                StreamReader reader = new StreamReader(path);
                Console.WriteLine(reader.ReadToEnd());
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine($"File not found: {e.Message}");
            }
            catch(DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(IOException e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
