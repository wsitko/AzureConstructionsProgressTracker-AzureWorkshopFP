using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web;
using System.Configuration;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;

namespace AzureConstructionsProgressTracker.Features.ProgressTracking
{
    public class FilesStorageService
    {
        private const string ContainerName = "constructionprogressfiles";
        
        public async Task<string> UploadFile(string fileName, HttpPostedFileBase file)
        {
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(ConfigurationManager.AppSettings["StorageConnectionString"]);
            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();
            CloudBlobContainer container = blobClient.GetContainerReference("test");
            await container.CreateIfNotExistsAsync();
            await container.SetPermissionsAsync(new BlobContainerPermissions  {     PublicAccess =  BlobContainerPublicAccessType.Blob   });
            CloudBlockBlob blockBlob = container.GetBlockBlobReference(fileName);
            await blockBlob.UploadFromStreamAsync(file.InputStream);
            return blockBlob.Uri.ToString();



            // TODO: 
            // https://azure.microsoft.com/en-us/documentation/articles/storage-dotnet-how-to-use-blobs/#programmatically-access-blob-storage
            // - Add proper nuget
            // - Connect to storage
            // - create container
            // - upload blob
            // - return URL
            //throw new NotImplementedException();
        }
    }
}