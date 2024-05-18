using Emgu.CV;
using System;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;

namespace ImageToASCII.Modes
{
    internal class ImageMode
    {
        public ImageMode()
        {
            Console.WriteLine("Enter the name of the image located in your Image folder you want to convert to ASCII: ");
            string imageName = Console.ReadLine();

            string asciiChars = "  .,:ilwW#$%&@";
            string sImageDir = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            Bitmap img = new(sImageDir + "/" + imageName);

            var outputWidth = img.Width / 2;
            var widthStep = img.Width / outputWidth;
            var outputHeight = (int)Math.Ceiling((double)img.Height * outputWidth / img.Width);
            var heightStep = img.Height / outputHeight;


            var resized = new System.Drawing.Size(outputWidth, outputHeight);
            Console.WriteLine(resized);
            img = new(img, resized);

            for (int y = 0; y < img.Height; y+= widthStep)
            {
                for (int x = 0; x < img.Width; x+= heightStep)
                {
                    Color pixelColor = img.GetPixel(x, y);
                    int brightness = (int)(pixelColor.GetBrightness() * (asciiChars.Length - 1));
                    Console.Write(asciiChars[brightness]);
                }
                Console.WriteLine();
            }
        }
    }
}
