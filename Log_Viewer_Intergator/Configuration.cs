using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Log_Viewer_Intergator
{
    internal class Configuration
    {
        public string LogFileDirectory { get; } = $"{AppDomain.CurrentDomain.BaseDirectory}LogFileDirectory";
        public string AWSBucket { get; } = $"myexpenesystembucket";
        public string AWSFolderLogs { get; } = $"invoices-logs";

    }
}
