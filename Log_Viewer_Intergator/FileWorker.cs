using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace Log_Viewer_Intergator
{
    internal class FileWorker
    {
        Configuration config = new Configuration();
        internal void DeleteAllFilesFromFilesFolder()
        {
            string[] files = Directory.GetFiles(config.LogFileDirectory);

            foreach (string file in files)
            {
                File.Delete(file);
            }
        }
        internal void MergeLogsIntoOneFile()
        {
            string directoryPath = config.LogFileDirectory;
            string outputFilePath = Path.Combine(directoryPath, config.LogFile);
            string outputFilePathTrash = Path.Combine(directoryPath, config.TrashFile);
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
                    if(!line.Contains(config.TestWorker) && !line.Contains(config.Qtp))
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
