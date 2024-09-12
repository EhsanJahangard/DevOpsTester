using SixLabors.ImageSharp.Formats.Png;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp;
using System.Drawing.Imaging;
using System.Text.RegularExpressions;
using System.IO;

namespace IdentityApplication.Utilities;

public static class Base64
{
    public static bool IsBase64String(this string value)
    {
        value = value.GetBase64FileData();
        value = value.Trim();
        return (value.Length % 4 == 0) && Regex.IsMatch(value, @"^[a-zA-Z0-9\+/]*={0,3}$", RegexOptions.None);

    }

    public static string GetBase64FileFormat(this string base64)
    {

        var res = base64.Split(',')[0];
        res = res.Split(';')[0];
        res = res.Split('/')[1];
        res = res.ToLower();

        return res;

    }

    public static string GetBase64FileData(this string base64)
    {
        return base64.Split(",")[1];
    }

    public static string SaveBase64FileData(this string base64, string dairectory, string name = "")
    {

        var data = base64.GetBase64FileData();
        var format = base64.GetBase64FileFormat();

        if (string.IsNullOrEmpty(name) == true)
        {
            name = Guid.NewGuid().ToString();
        }

        name = name + "." + format;

        string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", dairectory, name);

        byte[] bytes = Convert.FromBase64String(data);

        System.IO.FileStream stream = new FileStream(path, FileMode.CreateNew);
        System.IO.BinaryWriter writer = new BinaryWriter(stream);
        writer.Write(bytes, 0, bytes.Length);
        writer.Close();

        return name;

    }

    public static string FileToBase64(this string name, string dairectory)
    {

        string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", dairectory, name);

        // Check if the file exists
        if (!File.Exists(path))
        {
            return "";
        }

        // Read all bytes from the file
        byte[] bytes = File.ReadAllBytes(path);

        // Convert the byte array to a Base64 string
        string base64String = Convert.ToBase64String(bytes);

        // Return the Data URL
        return $"data:application/{Path.GetExtension(name).Substring(1)};base64,{base64String}";

    }

    //public static string ImageToBase64(this System.Drawing.Image image)
    //{

    //    MemoryStream m = new MemoryStream();

    //    image.Save(m, ImageFormat.Png);

    //    byte[] imageBytes = m.ToArray();

    //    string base64String = Convert.ToBase64String(imageBytes);

    //    return "data:application/png;base64," + base64String;

    //}

    public static string ImageToBase64(this Image image)
    {
        using var ms = new MemoryStream();
        image.Save(ms, new PngEncoder());
        byte[] imageBytes = ms.ToArray();
        string base64String = Convert.ToBase64String(imageBytes);
        return "data:image/png;base64," + base64String;
    }

    public static int GetBase64SizeKb(this string base64)
    {

        var data = base64.GetBase64FileData();

        return Convert.ToInt32((Math.Ceiling((double)data.Length / 4) * 3) / 1000.0);

    }
}
