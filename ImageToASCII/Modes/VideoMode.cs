using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Mat = Emgu.CV.Mat;
using VideoCapture = Emgu.CV.VideoCapture;


namespace ImageToASCII.Modes
{
    internal class VideoMode
    {
        public VideoMode(bool isLive)
        {
            string asciiChars = "  .,:ilwW#$%&@@";
            string path = string.Empty;

            if (!isLive)
            {
                string sImageDir = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
                Console.WriteLine("Enter the name of the image located in your Video folder you want to convert to ASCII: ");
                string videoName = Console.ReadLine();
                

                path = sImageDir + "/" + videoName;

            }
            var capture = isLive ? new VideoCapture(0) : new VideoCapture(path);
            var mat = new Mat();

            StringBuilder sb = new();
            while (capture.IsOpened)
            {
                capture.Read(mat);
                if (mat.Cols == 0) break;
                var img = mat.ToBitmap();

                var divideBy = img.Width / 150;
                var resized = new System.Drawing.Size(img.Width / divideBy, img.Height / divideBy);

                img = new(img, resized);

                for (int y = 0; y < img.Height; y++)
                {
                    for (int x = 0; x < img.Width; x++)
                    {
                        var pixel = img.GetPixel(x, y);
                        int brightness = (int)(pixel.GetBrightness() * (asciiChars.Length - 1));
                        sb.Append(asciiChars[brightness]);
                    }
                    sb.AppendLine();
                }
                Console.Write(sb.ToString());
                Console.SetCursorPosition(0, 0);
                sb.Clear();
            }
        }
    }
}
