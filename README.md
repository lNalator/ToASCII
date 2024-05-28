# MediaToASCII
MediaToASCII is a C# application that converts various types of media (images, videos, and live camera feeds) into ASCII art. This project utilizes the Emgu CV library for handling video and live feed processing.

## Features
Image to ASCII: Convert static images to ASCII art.
Video to ASCII: Transform video frames into ASCII art.
Live Camera Feed to ASCII: Real-time conversion of live camera feed into ASCII art.

## Prerequisites
.NET Framework
Emgu CV library

## Installation
Clone the repository:

1. **Clone the repository:**
```sh
git clone https://github.com/yourusername/MediaToASCII.git
```

2. **Restore the dependencies:**
```sh
dotnet restore
```

4. **Build the project:**
```sh
dotnet build
```

## Usage
**Image Conversion:**

Place the image file in the Image folder.
Run the application and type 'image' into the console.
Then when asked, type the full name of the image file you wish to convert example :
```sh
cat.png
```

**Video Conversion:**
Place the video file in the Video folder.
Run the application and type 'live' into the console.
Then when asked, type the full name of the video file you wish to convert example :
```sh
dvd.mp4
```

**Live Camera Feed:**
Ensure your camera is connected.
Run the application and type 'live' into the console.







