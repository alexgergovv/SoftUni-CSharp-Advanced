using System.IO;
namespace LineNumbers
{
    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"C:\Users\user\Desktop\SoftUni\C# Advanced\07. Streams, Files and Directories - Lab\02. Line Numbers\input.txt";
            string outputFilePath = @"C:\Users\user\Desktop\SoftUni\C# Advanced\07. Streams, Files and Directories - Lab\02. Line Numbers\output.txt";
            RewriteFileWithLineNumbers(inputFilePath, outputFilePath);
        }
        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {
            using var reader = new StreamReader(inputFilePath);
            using var writer = new StreamWriter(outputFilePath);
            int count = 1;

            while (true)
            {
                string line = reader.ReadLine();
                if (line == null)
                {
                    break;
                }
                writer.WriteLine($"{count}. {line}");

                count++;
            }
        }
    }
}

