using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace Log_Viewer_Intergator
{
    internal class LogWorker
    {
        Configuration config = new Configuration();
        internal void DeleteAllLogsFromLogFolder()
        {
            string[] files = Directory.GetFiles(config.LogFileDirectory);

            foreach (string file in files)
            {
                File.Delete(file);
                Console.WriteLine($"{file} deleted.");
            }
        }
        internal void MergeLogsIntoOneFile()
        {
            string directoryPath = config.LogFileDirectory;
            string outputFilePath = Path.Combine(directoryPath, "BIG_DADDY.txt");
            string outputFilePathTrash = Path.Combine(directoryPath, "TRASH.txt");
            List<string> lines = new List<string>();
            foreach (string filePath in Directory.GetFiles(directoryPath))
            {
                lines.AddRange(File.ReadAllLines(filePath));
            }
            using (StreamWriter writerTrash = new StreamWriter(outputFilePathTrash))
            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                foreach (string line in lines)
                {
                    if(!line.Contains("[Test worker]") && !line.Contains("[qtp"))
                        writer.WriteLine(line);

                    else
                    {
                        writerTrash.WriteLine(line);
                    }
                }
            }
        }
    }
}
