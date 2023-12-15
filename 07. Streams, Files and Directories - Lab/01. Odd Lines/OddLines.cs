
namespace OddLines
{
    using System;
    using System.IO;

    public class OddLines
    {
        static void Main()
        {
            //C:\Users\user\Desktop\SoftUni\C# Advanced\07. Streams, Files and Directories - Lab\01. Odd Lines
            string inputFilePath = @"C:\Users\user\Desktop\SoftUni\C# Advanced\07. Streams, Files and Directories - Lab\01. Odd Lines\input.txt";
            string outputFilePath = @"C:\Users\user\Desktop\SoftUni\C# Advanced\07. Streams, Files and Directories - Lab\01. Odd Lines\output.txt";
            ExtractOddLines(inputFilePath, outputFilePath);
        }
        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            using (var reader = new StreamReader(inputFilePath))
            {
                using (var writer = new StreamWriter(outputFilePath))
                {
                    int count = 0;
                    while (true)
                    {
                        string line = reader.ReadLine();
                        if (line == null)
                        {
                            break;
                        }
                        if (count % 2 == 1)
                        {
                            writer.WriteLine(line);
                        }
                        count++;
                    }
                }
            }
        }
    }
}
