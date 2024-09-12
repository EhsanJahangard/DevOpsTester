

using Microsoft.AspNetCore.Http;
using System.Drawing;

namespace IdentityApplication.Utilities;

public static class FileUtility
{
    public static bool IsImage(this IFormFile file)
    {
        var extension = Path.GetExtension(file.FileName).ToLower();

        if (extension == ".png" || extension == ".jpg" || extension == ".jpeg")
            return true;

        return false;
    }

    public static bool IsPdf(this IFormFile file)
    {
        var extension = Path.GetExtension(file.FileName).ToLower();

        if (extension == ".pdf")
            return true;

        return false;
    }

    public static bool IsExistFile(this string name, string directoryPath)
    {
        string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", directoryPath, name);

        return System.IO.File.Exists(path);
    }

    public static bool RemoveFile(this string name, string directoryPath)
    {
        try
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", directoryPath, name);

            if (System.IO.File.Exists(path) == true)
            {
                System.IO.File.Delete(path);
            }

            return true;
        }
        catch (Exception e)
        {
            return false;
        }
    }

    public static string SaveFile(this IFormFile file, string directoryPath)
    {
        var name = Guid.NewGuid() + Path.GetExtension(file.FileName);

        string savePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", directoryPath, name);

        using (var stream = new FileStream(savePath, FileMode.Create))
        {
            file.CopyTo(stream);
        }

        return name;
    }

    public static string SaveFile(this Image file, string directoryPath)
    {
        var name = Guid.NewGuid() + ".png";

        string savePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", directoryPath, name);

        file.Save(savePath);

        return name;
    }
}
