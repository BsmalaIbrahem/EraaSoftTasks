using System.Threading.Tasks;

namespace PresentationLayer.Helpers
{
    public static class FileHelper
    {
        public static string CreateFileName(string fileName)
        {
            fileName = Guid.NewGuid().ToString() + Path.GetExtension(fileName);
            return fileName;
        }

        public static string GetFilePath(string fileName, string folderName)
        {
            return Path.Combine(Directory.GetCurrentDirectory(), folderName, fileName);
        }

        public static async Task UploadFile(string filePath, IFormFile file)
        {
            using (var stream = System.IO.File.Create(filePath))
            {
                await file.CopyToAsync(stream);
            }
        }

        
    }
}
