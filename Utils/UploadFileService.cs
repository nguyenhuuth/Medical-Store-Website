using MedicalStore.Utils.Interface;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;

namespace MedicalStore.Utils
{
    public class UploadFileService : IUploadFileService
    {
        readonly string FolderUrl = "/wwwroot/public/images/";
        readonly string ImageUrl = "/public/images/";
        public static string[] ImageExtension = { "png", "jpg", "jpeg" };
        public bool CheckFileExtension(IFormFile file)
        {
            bool result = false;
            string fileExtension = file.FileName.ToLower().Split(".")[file.FileName.ToLower().Split(".").Length - 1];
            foreach (string extension in ImageExtension)
            {
                if (extension == fileExtension)
                {
                    result = true;
                }
            }
            return result;
        }

        public bool CheckFileSize(IFormFile file, int limit)
        {
            return file.Length < limit * 1024 * 1024;
        }

        public string Upload(IFormFile file)
        {
            string formatFolderUrl = "." + FolderUrl;
            string fileExtension = file.FileName.ToLower().Split(".")[file.FileName.ToLower().Split(".").Length - 1];
            string fortmatFileName = System.Guid.NewGuid().ToString() + "." + fileExtension;

            try
            {
                if (!Directory.Exists(formatFolderUrl))
                {
                    Directory.CreateDirectory(formatFolderUrl);
                }

                using (FileStream fileStream = System.IO.File.Create(formatFolderUrl + fortmatFileName))
                {
                    file.CopyTo(fileStream);
                    fileStream.Flush();
                }
                return ImageUrl + fortmatFileName;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return null;
        }
    }
}
