using System;
using System.Drawing;
using ImageToASCII.Modes;

Console.WriteLine("Modes : Image, Video, Live");
Console.WriteLine("Enter the conversion mode :");

CHOOSE:
switch (Console.ReadLine().ToLower())
{
    case "image":
        new ImageMode();
        break;
    case "video":
        new VideoMode(false);
        break;
    case "live":
        new VideoMode(true);
        break;
    default:
        Console.WriteLine("Invalid mode");
        goto CHOOSE;
        break;
}
