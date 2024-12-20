using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Log_Viewer_Intergator
{
    internal class AWSConnectorDownloader
    {
        Configuration config = new Configuration();
        internal async Task TryDownloadLogsFromAWS(DateTime data)
        {
            var bucketName = config.AWSBucket;
            var s3Client = new AmazonS3Client(RegionEndpoint.EUNorth1);
            var folderPrefix = config.LogFileDirectory + $"/{data.Year}-{data.Month}-{data.Day}";
            try
            {
                while (true)
                {
                    DownloadLogsForOneDay(bucketName, s3Client, folderPrefix);
                    if(data.DayOfYear < DateTime.Today.DayOfYear) folderPrefix = UpDayByOne(ref data);
                    else  break;
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
            return config.AWSFolderLogs + $"/{data.Year}-{data.Month}-{data.Day}";
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
                    if (s3Object.Key.EndsWith("-invoice-module.log"))
                    {
                        string safeFileName = s3Object.Key.Substring(folderPrefix.Length + 1).Replace(":", "_");
                        string destinationPath = Path.Combine(config.LogFileDirectory, safeFileName);

                        var getObjectRequest = new GetObjectRequest
                        {
                            BucketName = bucketName,
                            Key = s3Object.Key
                        };

                        using (var getObjectResponse = await s3Client.GetObjectAsync(getObjectRequest))
                        using (var fileStream = new FileStream(destinationPath, FileMode.Create, FileAccess.Write,FileShare.Read))
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
