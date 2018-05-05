using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace Task_3
{
    static class FileSearch
    {
        public static void GetFile(string path, string fileName, bool flag)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(path);

                FileInfo[] files = dir.GetFiles();
                foreach (FileInfo f in files)
                {
                    if (fileName == f.Name)
                    {
                        Console.WriteLine("Файл найден в директории: {0}", path);
                        Console.WriteLine("Содержимое файла:");
                        using (FileStream fStream = new FileStream(path + fileName, FileMode.Open, FileAccess.Read))
                        {
                            byte[] array = new byte[fStream.Length];
                            fStream.Read(array, 0, array.Length);
                            string textFromFile = Encoding.Default.GetString(array);
                            Console.WriteLine(textFromFile);
                            fStream.Close();
                        }
                        string answer;
                        Console.WriteLine("Желаете сжать данный файл?(Y/N)");
                        answer = Console.ReadLine();
                        switch (answer)
                        {
                            case "Y":
                                CompressMethod(path + fileName, path + fileName + ".gz");
                                break;
                            case "N":
                                break;
                            default:
                                Console.WriteLine("Некорректный ввод");
                                break;
                        }
                        flag = false;
                        break;
                    }
                }
                if (flag)
                {
                    foreach (DirectoryInfo directory in dir.GetDirectories())
                    {
                        GetFile(path + directory.Name + @"\", fileName, flag);
                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void CompressMethod(string sourceFile, string destinationFile)
        {
            using (FileStream sFile = new FileStream(sourceFile, FileMode.Open, FileAccess.Read))
            {
                using (FileStream dFile = new FileStream(destinationFile, FileMode.Create, FileAccess.Write))
                {
                    using (GZipStream gzip = new GZipStream(dFile, CompressionMode.Compress))
                    {
                        Byte[] buffer = new Byte[sFile.Length];
                        sFile.Read(buffer, 0, buffer.Length);
                        gzip.Write(buffer, 0, buffer.Length);
                        Console.WriteLine("Сжатие файла {0} завершено.");
                    }
                }
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                string path;
                string fileName;
                Console.WriteLine(@"Ведите диск для поиска, например D:\");
                path = Console.ReadLine();
                Console.WriteLine("Ведите имя файла, например File.txt");
                fileName = Console.ReadLine();
                Console.WriteLine("Поиск файла...");
                FileSearch.GetFile(path, fileName, true);
                Console.WriteLine("Поиск окончен");
                Console.ReadKey();
            }
        }
    }
}
