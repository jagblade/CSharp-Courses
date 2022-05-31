namespace EvenLines
{
    using System;
    using System.IO;
    using System.Linq;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            ProcessLines(inputFilePath);
        }

        public static void ProcessLines(string inputFilePath)
        {
            //1. прочетем четните редовете
            //2. заменим символите с @
            //3. reverse words

            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                int counter = -1; //брой редовете
                string line = reader.ReadLine(); //четем по 1 ред от файла

                while (line != null)
                {
                    counter++;
                    if (counter % 2 == 0)
                    {
                        //замяна
                        line = Replace(line);
                        //обърна в обратен ред
                        line = Reverse(line);
                        Console.WriteLine(line);
                    }

                    line = reader.ReadLine();
                }
            }
        }

        private static string Reverse(string line)
        {   //"@I was quick to judge him@ but it wasn't his fault@".Split()
            //["@I", "was", "quick", "to", "judge", "him@", "but", "it", "wasn't", "his", "fault@"].Reverse()
            //["fault@", "his", "wasn't", "it", "but", "him@", "judge", "to", "quick", "was", "@I"].Join(" ")
            //"fault@ his wasn't it but him@ judge to quick was @I"
            return string.Join(" ", line.Split().Reverse());
        }

        private static string Replace(string line) //върне реда със заместени символи
        {
            //-I was quick to judge him, but it wasn't his fault.
            //@I was quick to judge him@ but it wasn't his fault@
            return line.Replace("-", "@")
                 .Replace(",", "@")
                 .Replace(".", "@")
                 .Replace("!", "@")
                 .Replace("?", "@");
        }
    }
}
