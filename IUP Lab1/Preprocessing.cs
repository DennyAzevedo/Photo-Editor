using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenCvSharp;

namespace IUP_Lab1
{
    class Preprocessing
    {
        public IplImage src;
        public IplImage gray;
        public IplImage negative;
        public IplImage thresh;

        public void LoadOriginal()
        {
            src = Cv.LoadImage("apples.jpg", LoadMode.Color);
            Cv.SaveImage("savedOriginalImage.jpg", src);
        }

        public void LoadOriginal(String fileName)
        {
            src = Cv.LoadImage(fileName, LoadMode.Color);
            Cv.SaveImage("savedOriginalImage.jpg", src);
        }

        public void LoadGrayImage()
        {
            ToGrayscale();
            gray = Cv.LoadImage("savedGrayImage.jpg", LoadMode.GrayScale);
        }

        public void ToGrayscale()
        {
            //U8 because unsigned
            //channels is 1 because we have black and white. If RGB, channel is 3
            gray = Cv.CreateImage(src.Size, BitDepth.U8, 1);
            Cv.CvtColor(src, gray, ColorConversion.RgbToGray);
            Cv.SaveImage("savedGrayImage.jpg", gray);
        }

        public void ToNegative()
        {
            negative = Cv.CreateImage(src.Size, BitDepth.U8, 3);
            Cv.Not(src, negative);
            Cv.SaveImage("savedNegativeImage.jpg", negative);
        }

        public void ToGrayNegative()
        {
            LoadGrayImage();
            negative = Cv.CreateImage(gray.Size, BitDepth.U8, 1);
            Cv.Not(gray, negative);
            Cv.SaveImage("savedNegativeImage.jpg", negative);
        }

        public void ToThreshold()
        {
            LoadGrayImage();
            thresh = Cv.CreateImage(gray.Size, BitDepth.U8, 1);
            Cv.Threshold(gray, thresh, 128, 255, ThresholdType.Binary);
            Cv.SaveImage("savedThresholdImage.jpg", thresh);
        }

        public void dynamicThreshold(int threshv)
        {
            LoadGrayImage();
            thresh = Cv.CreateImage(gray.Size, BitDepth.U8, 1);
            Cv.Threshold(gray, thresh, threshv, 255, ThresholdType.Binary);
            Cv.SaveImage("savedThresholdImage.jpg", thresh);
        }
    }
}
