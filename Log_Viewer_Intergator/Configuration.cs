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
        public string AWSBucket { get; } = "myexpenesystembucket";
        public string AWSFolderLogs { get; } = "invoices-logs";
        public static string AWSFolderImages { get; } = "images";
        public string[] ImagesPrefixes { get; } = new string[]
        {
            AWSFolderImages + "/.expenses-",
            AWSFolderImages + "/.invoices-"
        };
        public string LogFile { get; } = "BIG_DADDY.txt";
        public string TrashFile { get; } = "TRASH.txt";
        public string TestWorker { get; } = "[Test worker]";
        public string Qtp { get; } = "[qtp";
        public string AllLogs { get; } = "All logs";
        public string Expenses { get; } = "expenses";
        public string Invoices { get; } = "invoices";
        public string ImagesExpenses { get; } = "images_.expenses-";
        public string ImagesInvoices { get; } = "images_.invoices-";
        public string WARN { get; } = "WARN";
        public string INFO { get; } = "INFO";
        public string ERROR { get; } = "ERROR";
        public string TransferFailed { get; } = "transfer failed - action required";
        public string EnterText { get; } = "Enter text to search for:";
        public string Search { get; } = "Search";
        public string LogContent { get; } = "logContent.txt";
        public string ApplicationToOpen { get; } = "notepad.exe";
        public string Images { get; } = "Images";
        public string GenerateImages { get; } = "Generate images";
        public string GenerateLogs { get; } = "Generate logs";
        public string Zero { get; } = "0";
        public string InvoiceModuleLog { get; } = "-invoice-module.log";
    }
}
