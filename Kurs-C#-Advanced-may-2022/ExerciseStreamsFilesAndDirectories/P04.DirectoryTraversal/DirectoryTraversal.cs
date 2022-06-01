namespace DirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            string[] files = Directory.GetFiles(inputFolderPath);
            //разширение -> списък с файловете
            Dictionary<string, List<FileInfo>> extensionsInfo = new Dictionary<string, List<FileInfo>>();
            //за всеки файл ни трябва разширението
            foreach (string file in files)
            {
                //информация за файла -> разришението
                FileInfo fileInfo = new FileInfo(file);
                string extension = fileInfo.Extension;

                if (!extensionsInfo.ContainsKey(extension))
                {
                    extensionsInfo.Add(extension, new List<FileInfo>());
                }

                extensionsInfo[extension].Add(fileInfo);
            }


            //1. be ordered by the count of list descending
            //2. name extenstions ascending
            //запис: key(разширение) -> value (списък с файлове)

            foreach (var entry in extensionsInfo.OrderByDescending(entry => entry.Value.Count).ThenBy(entry => entry.Key))
            {
                //вземем на всяко разширение списъка с файловете

                string extension = entry.Key;
                Console.WriteLine(extension);  //TODO: put in stringBuilder
                List<FileInfo> filesInfo = entry.Value;
                //списък с файловете трябва да се сортира спрямо размета на файла
                filesInfo.OrderByDescending(file => file.Length);

                foreach (FileInfo fileInfo in filesInfo)
                {
                    //BYTES / 1024 -> KB
                    Console.WriteLine($"--{fileInfo.Name} - {fileInfo.Length / 1024:F3}kb"); //TODO: put in stringBuilder
                }
            }

            return ""; //TODO: return sb.toString();
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            //textContent да го напиша във файл с име reportFileName
            string pathReport = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + reportFileName;
            //"C:\Users\I353529\Desktop" + "\report.txt" -> "C:\Users\I353529\Desktop\report.txt"
            File.WriteAllText(pathReport, textContent);
        }
    }
}
