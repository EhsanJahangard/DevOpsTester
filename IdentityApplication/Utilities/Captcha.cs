//using System.Drawing.Imaging;
//using System.Drawing;
using System.Text;
using SixLabors.Fonts;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using SixLabors.ImageSharp.Drawing.Processing;

namespace IdentityApplication.Utilities;

public static class Captcha
{
    const string Letters = "123456789";

    public static string GenerateCaptchaCode()
    {
        Random rand = new Random();
        int maxRand = Letters.Length - 1;

        StringBuilder sb = new StringBuilder();

        for (int i = 1; i <= 5; i++)
        {
            int index = rand.Next(maxRand);
            sb.Append(Letters[index]);
        }

        return sb.ToString();
    }

    public static bool ValidateCaptcha(string code, string captchaEncode)
    {

        var encode = PasswordHelper.EncodePasswordMd5(code);

        if (encode == captchaEncode)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    //public static Image GenerateCaptchaImage(int width, int height, string captchaCode)
    //{

    //    System.Drawing.Bitmap baseMap = new Bitmap(width, height);
    //    System.Drawing.Graphics graph = Graphics.FromImage(baseMap);

    //    Random rand = new Random();
    //    width -= 15;
    //    height -= 10;
    //    graph.Clear(GetRandomLightColor());
    //    DrawCaptchaCode();

    //    //DrawDisorderLine();

    //    AdjustRippleEffect();

    //    MemoryStream ms = new MemoryStream();

    //    baseMap.Save(ms, ImageFormat.Png);

    //    return baseMap;

    //    //return new CaptchaResult { CaptchaCode = captchaCode, CaptchaByteData = ms.ToArray(), Timestamp = DateTime.Now };

    //    int GetFontSize(int imageWidth, int captchCodeCount)
    //    {
    //        var averageSize = imageWidth / captchCodeCount;

    //        return Convert.ToInt32(averageSize);
    //    }

    //    Color GetRandomDeepColor()
    //    {
    //        int redlow = 160, greenLow = 100, blueLow = 160;

    //        return Color.FromArgb(rand.Next(redlow), rand.Next(greenLow), rand.Next(blueLow));
    //    }

    //    Color GetRandomLightColor()
    //    {
    //        int low = 180, high = 255;

    //        int nRend = rand.Next(high) % (high - low) + low;
    //        int nGreen = rand.Next(high) % (high - low) + low;
    //        int nBlue = rand.Next(high) % (high - low) + low;

    //        return Color.FromArgb(nRend, nGreen, nBlue);
    //    }

    //    void DrawCaptchaCode()
    //    {
    //        SolidBrush fontBrush = new SolidBrush(Color.Black);
    //        int fontSize = GetFontSize(width, captchaCode.Length);
    //        Font font = new Font(FontFamily.GenericSerif, fontSize, FontStyle.Bold, GraphicsUnit.Pixel);
    //        for (int i = 0; i < captchaCode.Length; i++)
    //        {
    //            fontBrush.Color = GetRandomDeepColor();

    //            int shiftPx = fontSize / 6;

    //            float x = i * fontSize + rand.Next(-shiftPx, shiftPx) + rand.Next(-shiftPx, shiftPx);
    //            int maxY = height - fontSize;
    //            if (maxY < 0) maxY = 0;
    //            float y = rand.Next(0, maxY);

    //            graph.DrawString(captchaCode[i].ToString(), font, fontBrush, x + 13, y + 5);
    //        }
    //    }

    //    //void DrawDisorderLine()
    //    //{
    //    //    Pen linePen = new Pen(new SolidBrush(Color.Black), 3);
    //    //    for (int i = 0; i < rand.Next(3, 5); i++)
    //    //    {
    //    //        linePen.Color = GetRandomDeepColor();

    //    //        Point startPoint = new Point(rand.Next(0, width), rand.Next(0, height));
    //    //        Point endPoint = new Point(rand.Next(0, width), rand.Next(0, height));
    //    //        graph.DrawLine(linePen, startPoint, endPoint);

    //    //        Point bezierPoint1 = new Point(rand.Next(0, width), rand.Next(0, height));
    //    //        Point bezierPoint2 = new Point(rand.Next(0, width), rand.Next(0, height));

    //    //        graph.DrawBezier(linePen, startPoint, bezierPoint1, bezierPoint2, endPoint);
    //    //    }
    //    //}

    //    void AdjustRippleEffect()
    //    {
    //        short nWave = 6;
    //        int nWidth = baseMap.Width;
    //        int nHeight = baseMap.Height;

    //        Point[,] pt = new Point[nWidth, nHeight];

    //        double newX, newY;
    //        double xo, yo;

    //        for (int x = 0; x < nWidth; ++x)
    //        {
    //            for (int y = 0; y < nHeight; ++y)
    //            {
    //                xo = ((double)nWave * Math.Sin(2.0 * 3.1415 * (float)y / 125.0));
    //                yo = ((double)nWave * Math.Cos(2.0 * 3.1415 * (float)x / 125.0));

    //                newX = (x + xo);
    //                newY = (y + yo);

    //                if (newX > 0 && newX < nWidth)
    //                {
    //                    pt[x, y].X = (int)newX;
    //                }
    //                else
    //                {
    //                    pt[x, y].X = 0;
    //                }


    //                if (newY > 0 && newY < nHeight)
    //                {
    //                    pt[x, y].Y = (int)newY;
    //                }
    //                else
    //                {
    //                    pt[x, y].Y = 0;
    //                }
    //            }
    //        }

    //        Bitmap bSrc = (Bitmap)baseMap.Clone();

    //        BitmapData bitmapData = baseMap.LockBits(new Rectangle(0, 0, baseMap.Width, baseMap.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
    //        BitmapData bmSrc = bSrc.LockBits(new Rectangle(0, 0, bSrc.Width, bSrc.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

    //        int scanline = bitmapData.Stride;

    //        IntPtr Scan0 = bitmapData.Scan0;
    //        IntPtr SrcScan0 = bmSrc.Scan0;

    //        unsafe
    //        {
    //            byte* p = (byte*)(void*)Scan0;
    //            byte* pSrc = (byte*)(void*)SrcScan0;

    //            int nOffset = bitmapData.Stride - baseMap.Width * 3;

    //            int xOffset, yOffset;

    //            for (int y = 0; y < nHeight; ++y)
    //            {
    //                for (int x = 0; x < nWidth; ++x)
    //                {
    //                    xOffset = pt[x, y].X;
    //                    yOffset = pt[x, y].Y;

    //                    if (yOffset >= 0 && yOffset < nHeight && xOffset >= 0 && xOffset < nWidth)
    //                    {
    //                        p[0] = pSrc[(yOffset * scanline) + (xOffset * 3)];
    //                        p[1] = pSrc[(yOffset * scanline) + (xOffset * 3) + 1];
    //                        p[2] = pSrc[(yOffset * scanline) + (xOffset * 3) + 2];
    //                    }

    //                    p += 3;
    //                }
    //                p += nOffset;
    //            }
    //        }

    //        baseMap.UnlockBits(bitmapData);
    //        bSrc.UnlockBits(bmSrc);
    //        bSrc.Dispose();
    //    }

    //}

    public static Image GenerateCaptchaImage(int width, int height, string captchaCode)
    {
        var rand = new Random();
        width -= 15;
        height -= 10;

        var baseMap = new Image<Rgba32>(width, height);
        baseMap.Mutate(ctx => ctx.Clear(GetRandomLightColor(rand)));
        DrawCaptchaCode(baseMap, captchaCode, width, height, rand);

        AdjustRippleEffect(baseMap, rand);

        using var ms = new MemoryStream();
        baseMap.SaveAsPng(ms);
        ms.Seek(0, SeekOrigin.Begin);

        return baseMap;
    }

    private static void DrawCaptchaCode(Image<Rgba32> image, string captchaCode, int width, int height, Random rand)
    {
        var fontCollection = new FontCollection();
        //var font = fontCollection.Add("path_to_font_file.ttf"); // Update with a valid font file path
        var font = fontCollection.Add("wwwroot/fonts/arial.ttf"); // Update with a valid font file path
        var fontSize = GetFontSize(width, captchaCode.Length);
        var textOptions = new TextOptions(font.CreateFont(fontSize))
        {
            HorizontalAlignment = HorizontalAlignment.Left,
            VerticalAlignment = VerticalAlignment.Top
        };

        image.Mutate(ctx =>
        {
            for (int i = 0; i < captchaCode.Length; i++)
            {
                var color = GetRandomDeepColor(rand);
                int shiftPx = fontSize / 6;

                float x = i * fontSize + rand.Next(-shiftPx, shiftPx) + rand.Next(-shiftPx, shiftPx);
                int maxY = height - fontSize;
                if (maxY < 0) maxY = 0;
                float y = rand.Next(0, maxY);

                ctx.DrawText(captchaCode[i].ToString(), textOptions.Font, color, new PointF(x + 13, y + 5));
            }
        });
    }

    private static void AdjustRippleEffect(Image<Rgba32> image, Random rand)
    {
        short nWave = 6;
        int nWidth = image.Width;
        int nHeight = image.Height;

        var original = image.Clone();

        for (int x = 0; x < nWidth; ++x)
        {
            for (int y = 0; y < nHeight; ++y)
            {
                double xo = nWave * Math.Sin(2.0 * Math.PI * y / 125.0);
                double yo = nWave * Math.Cos(2.0 * Math.PI * x / 125.0);

                int newX = (int)(x + xo);
                int newY = (int)(y + yo);

                if (newX >= 0 && newX < nWidth && newY >= 0 && newY < nHeight)
                {
                    image[x, y] = original[newX, newY];
                }
            }
        }
    }

    private static int GetFontSize(int imageWidth, int captchCodeCount)
    {
        var averageSize = imageWidth / captchCodeCount;
        return Convert.ToInt32(averageSize);
    }

    private static Color GetRandomDeepColor(Random rand)
    {
        int redlow = 160, greenLow = 100, blueLow = 160;
        return Color.FromRgb((byte)rand.Next(redlow), (byte)rand.Next(greenLow), (byte)rand.Next(blueLow));
    }

    private static Color GetRandomLightColor(Random rand)
    {
        int low = 180, high = 255;
        int nRend = rand.Next(low, high);
        int nGreen = rand.Next(low, high);
        int nBlue = rand.Next(low, high);
        return Color.FromRgb((byte)nRend, (byte)nGreen, (byte)nBlue);
    }

}
