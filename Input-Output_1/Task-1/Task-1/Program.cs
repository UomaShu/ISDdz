using System;
using System.IO;

class Test
{
    public static void Main()
    {
        
        string path = @"E:\\ISD\\Folder_";

            for (var i = 0; i < 100; i++)
            {
                DirectoryInfo di = Directory.CreateDirectory(path+i);
                Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(path));

              
                di.Delete();
                Console.WriteLine("The directory was deleted successfully.");
            }
       


    }
}