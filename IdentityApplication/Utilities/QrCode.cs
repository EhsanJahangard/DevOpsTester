

using QRCoder;
using SixLabors.ImageSharp.Formats.Png;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp;

namespace IdentityApplication.Utilities;

public static class QrCode
{
    //public static string GenerateQrCode(this string text)
    //{
    //    using MemoryStream ms = new();
    //    QRCodeGenerator qrCodeGenerate = new();
    //    QRCodeData qrCodeData = qrCodeGenerate.CreateQrCode(text, QRCodeGenerator.ECCLevel.Q);
    //    QRCode qrCode = new(qrCodeData);
    //    using Bitmap qrBitMap = qrCode.GetGraphic(20);
    //    qrBitMap.Save(ms, ImageFormat.Png);
    //    string base64 = Convert.ToBase64String(ms.ToArray());
    //    return string.Format("data:image/png;base64,{0}", base64);
    //}

    public static string GenerateQrCode(this string text)
    {
        // Create QR code data
        QRCodeGenerator qrCodeGenerator = new QRCodeGenerator();
        QRCodeData qrCodeData = qrCodeGenerator.CreateQrCode(text, QRCodeGenerator.ECCLevel.Q);

        // Convert QR code data to ImageSharp Image
        using BitmapByteQRCode qrCode = new BitmapByteQRCode(qrCodeData);
        byte[] qrCodeBytes = qrCode.GetGraphic(20);

        using Image<Rgba32> qrImage = Image.Load<Rgba32>(qrCodeBytes);

        // Convert ImageSharp Image to Base64
        using MemoryStream ms = new MemoryStream();
        qrImage.Save(ms, new PngEncoder());
        string base64 = Convert.ToBase64String(ms.ToArray());

        return string.Format("data:image/png;base64,{0}", base64);
    }
}
