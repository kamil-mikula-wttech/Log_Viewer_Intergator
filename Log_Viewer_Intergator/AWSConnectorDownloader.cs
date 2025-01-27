using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Log_Viewer_Intergator
{
    internal class AWSConnectorDownloader
    {
        Configuration config = new Configuration();
        internal async Task TryDownloadLogsFromAWS(DateTime data)
        {
            var bucketName = config.AWSBucket;
            var s3Client = new AmazonS3Client(RegionEndpoint.EUNorth1);
            string month = data.Month.ToString();
            string day = data.Day.ToString();
            month = (month.Length == 2) ? month : string.Join(String.Empty, config.Zero, month);
            day = (day.Length == 2) ? day : string.Join(String.Empty, config.Zero, day);
            var folderPrefix = config.AWSFolderLogs + $"/{data.Year}-{month}-{day}";
            try
            {
                while (true)
                {
                    DownloadLogsForOneDay(bucketName, s3Client, folderPrefix);
                    if ((data.DayOfYear < DateTime.Today.DayOfYear) || data.Year < DateTime.Today.Year) folderPrefix = UpDayByOne(ref data);
                    else break;
                }
            }
            catch (Exception ex)
            {
                //Em maybe in future will add logging logs into log viewer
            }
        }
        internal async Task TryDownloadImageFilesFromAWS(DateTime data)
        {
            var bucketName = config.AWSBucket;
            var s3Client = new AmazonS3Client(RegionEndpoint.EUNorth1);
            string folderPrefix;
            string currentPrefix = String.Empty;
            try
            {
                while (true)
                {
                    string month = data.Month.ToString();
                    string day = data.Day.ToString();
                    month = (month.Length == 2) ? month : string.Join(String.Empty, config.Zero, month);
                    day = (day.Length == 2) ? day : string.Join(String.Empty, "0", day);

                    foreach (string str in config.ImagesPrefixes)
                    {
                        currentPrefix = str;
                        folderPrefix = currentPrefix + $"{data.Year}-{month}-{day}";
                        DownloadImagesForOneDay(bucketName, s3Client, folderPrefix);

                    }
                    if ((data.DayOfYear < DateTime.Today.DayOfYear) || data.Year < DateTime.Today.Year) folderPrefix = UpDayByOneDayImage(ref data, currentPrefix);
                    else break;
                }
            }
            catch (Exception ex)
            {
                //Throw exception to log logview. idk if needed lol
            }
        }


        private string UpDayByOne(ref DateTime data)
        {
            data = data.AddDays(1);
            string month = data.Month.ToString();
            string day = data.Day.ToString();
            month = (month.Length == 2) ? month : string.Join(String.Empty, config.Zero, month);
            day = (day.Length == 2) ? day : string.Join(String.Empty, config.Zero, day);
            return config.AWSFolderLogs + $"/{data.Year}-{month}-{day}";
        }
        private string UpDayByOneDayImage(ref DateTime data, string folder)
        {
            data = data.AddDays(1);
            string month = data.Month.ToString();
            string day = data.Day.ToString();
            month = (month.Length == 2) ? month : string.Join(String.Empty, config.Zero, month);
            day = (day.Length == 2) ? day : string.Join(String.Empty, config.Zero, day);
            return folder + $"{data.Year}-{month}-{day}";
        }


        private async Task DownloadLogsForOneDay(string bucketName, AmazonS3Client s3Client, string folderPrefix)
        {
            var listObjectsRequest = new ListObjectsV2Request
            {
                BucketName = bucketName,
                Prefix = folderPrefix
            };

            ListObjectsV2Response listObjectsResponse;
            do
            {
                listObjectsResponse = await s3Client.ListObjectsV2Async(listObjectsRequest);

                foreach (var s3Object in listObjectsResponse.S3Objects)
                {
                    if (s3Object.Key.EndsWith(config.InvoiceModuleLog))
                    {
                        string safeFileName = ReplaceAllUnsafeChars(s3Object.Key); 
                        string destinationPath = Path.Combine(config.LogFileDirectory, safeFileName);

                        var getObjectRequest = new GetObjectRequest
                        {
                            BucketName = bucketName,
                            Key = s3Object.Key
                        };

                        using (var getObjectResponse = await s3Client.GetObjectAsync(getObjectRequest))
                        using (var fileStream = new FileStream(destinationPath, FileMode.Create, FileAccess.Write, FileShare.Read))
                        {
                            await getObjectResponse.ResponseStream.CopyToAsync(fileStream);
                            fileStream.Flush();
                        }
                    }
                }
                listObjectsRequest.ContinuationToken = listObjectsResponse.NextContinuationToken;
            } while (listObjectsResponse.IsTruncated);

        }

        private string ReplaceAllUnsafeChars(string key)
        {
            return key.Replace(":", "_").Replace("/", "_").Replace(" ", "_");
        }

        private async Task DownloadImagesForOneDay(string bucketName, AmazonS3Client s3Client, string folderPrefix)
        {
            var listObjectsRequest = new ListObjectsV2Request
            {
                BucketName = bucketName,
                Prefix = folderPrefix
            };

            ListObjectsV2Response listObjectsResponse;
            do
            {
                listObjectsResponse = await s3Client.ListObjectsV2Async(listObjectsRequest);

                foreach (var s3Object in listObjectsResponse.S3Objects)
                {
                    if (s3Object.Key == folderPrefix)
                    {
                        string safeFileName = ReplaceAllUnsafeChars(s3Object.Key);
                        string destinationPath = Path.Combine(config.LogFileDirectory, safeFileName);

                        var getObjectRequest = new GetObjectRequest
                        {
                            BucketName = bucketName,
                            Key = s3Object.Key
                        };

                        using (var getObjectResponse = await s3Client.GetObjectAsync(getObjectRequest))
                        using (var fileStream = new FileStream(destinationPath, FileMode.Create, FileAccess.Write, FileShare.Read))
                        {
                            await getObjectResponse.ResponseStream.CopyToAsync(fileStream);
                            fileStream.Flush();
                        }
                    }
                }
                listObjectsRequest.ContinuationToken = listObjectsResponse.NextContinuationToken;
            } while (listObjectsResponse.IsTruncated);

        }
    }
}
