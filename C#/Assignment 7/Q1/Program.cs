using System;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace fileImplementation
{
    class program
    {
        public static void Main(string[] args)
        { // for printing all subfolders 
            string rootpath = @"D:\textfile";
            string[] dirs = Directory.GetDirectories(rootpath, "*", SearchOption.AllDirectories);
            Console.WriteLine("Printing all subfolders");
            Console.WriteLine("-----------------------");
            foreach (string dir in dirs)
            { 
                Console.WriteLine(dir);  
                //Console.WriteLine(Directory.GetCreationTime(dir));  
            }
            Console.WriteLine();

            // for printing all files
            var files = Directory.GetFiles(rootpath, "*.*", SearchOption.AllDirectories);
            Console.WriteLine("Printing all files");
            Console.WriteLine("-----------------------");
            foreach (string file in files)
            {

                Console.WriteLine(Path.GetFileName(file));
            }
            // using methods of File Class

                //File.WriteAllText(@"D:\textfile\textfile1.txt", "This is dummy text");
                //File.AppendAllText(@"D:\textfile\textfile1.txt", "This is File testing");
                //Console.WriteLine(File.GetLastAccessTime(@"D:\textfile\textfile1.txt").ToString());
                //Console.WriteLine(File.GetLastWriteTime(@"D:\textfile\textfile1.txt"));
                //StreamReader sr = File.OpenText(@"D:\textfile\textfile1.txt");
                //Console.WriteLine(sr.ReadLine());

            
        }
    }
}