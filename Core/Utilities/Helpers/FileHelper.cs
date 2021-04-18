using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using Core.Utilities.Results;

namespace Core.Utilities.Helpers
{
    public class FileHelper
    {
        public static string Add(IFormFile file)
        {
            var sourcepath = Path.GetTempFileName();
            if (file.Length > 0)
            {
                using (var fileStream = new FileStream(sourcepath, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
            }
            var result = NewPath(file);
            File.Move(sourcepath, @"wwwroot" + result);
            return result;
        }

        public static IResult Delete(string path)
        {
            try
            {
                File.Delete(path);
            }
            catch (Exception ex)
            {
                return new ErrorResult("Dosya silinemedi: " + ex.ToString());
            }

            return new SuccessResult();
        }

        public static string Update(string sourcePath, IFormFile file)
        {
            var result = NewPath(file);
            if (sourcePath.Length > 0)
            {
                using (var fileStream = new FileStream(result, FileMode.Create))
                {
                    file.CopyTo(fileStream);
                }
            }
            File.Delete(sourcePath);
            return result;
        }


        public static string NewPath(IFormFile file)
        {
            FileInfo fileInfo = new FileInfo(file.FileName);
            string fileExtension = fileInfo.Extension;
            var newPath = Guid.NewGuid().ToString() + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + "_" + DateTime.Now.Year + fileExtension;
            string result = $@"\uploads\{newPath}";
            return result;
        }
    }
}
