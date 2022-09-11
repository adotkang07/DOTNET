using System;
using System.Collections.Generic;

namespace CopyRename
{
    class Program
    {
        static void Main(string[] args)
        {

            string fileName = string.Empty;
            var mainPath = @"SOURCE PATH";
    
            string sourcePath = mainPath;
            string targetPath = @"TARGET LOCATION"; 

            string newName = string.Empty;
            // Use Path class to manipulate file and directory paths.
            string sourceFile = string.Empty; //System.IO.Path.Combine(sourcePath, fileName);
            string destFile = string.Empty;

            if (System.IO.Directory.Exists(sourcePath))
            {
                string[] files = System.IO.Directory.GetFiles(sourcePath);

                // Copy the files and overwrite destination files if they already exist.
                foreach (string s in files)
                {
             
                    try
                    {

                        fileName = System.IO.Path.GetFileName(s);
        
                        newName = System.IO.Path.GetFileName(s).Replace("test_file", "test1_file");

                        destFile = System.IO.Path.Combine(targetPath, newName);
                        sourceFile = System.IO.Path.Combine(sourcePath, fileName);
                        System.IO.File.Copy(sourceFile, destFile, true);
                        
      
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(fileName);
                        continue;
                    }
                  
                    
                   
                    
                }

               
            }
            else
            {
                Console.WriteLine("Source path does not exist!");
            }

            // Keep console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
