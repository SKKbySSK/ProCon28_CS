using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;

namespace ProCon28_CS.MatProcess
{
    class Contours : IMatProcess
    {
        public enum OutputImage
        {
            Gray = 0, Binary = 1, Contours = 2
        }

        private Window window;

        public double Threshold { get; set; } = 0;

        public double MaxValue { get; set; } = 255;

        public bool UseRawMat { get; } = false;

        public OutputImage OutputMode { get; set; } = OutputImage.Contours;

        public void Begin()
        {
            window = new Window("Contours");
        }

        public void End()
        {
            window.Dispose();
            window = null;
        }

        public void OnMatChanged(Mat Mat)
        {
            Mat gb = new Mat();

            Cv2.CvtColor(Mat, gb, ColorConversionCodes.BGR2GRAY);
            if (OutputMode == OutputImage.Gray)
                window.ShowImage(gb);

            Cv2.Threshold(gb, gb, Threshold, MaxValue, ThresholdTypes.Tozero);
            Cv2.Threshold(gb, gb, 0, 255, ThresholdTypes.Binary | ThresholdTypes.Otsu);
            if (OutputMode == OutputImage.Binary)
                window.ShowImage(gb);

            Cv2.FindContours(gb, out Point[][] contrours, out HierarchyIndex[] hierarchy, RetrievalModes.External, ContourApproximationModes.ApproxTC89L1);

            int length = contrours.Length;
            for(int i = 0; length > i; i++)
            {
                Cv2.DrawContours(Mat, contrours, i, Scalar.Red, 2, LineTypes.Link8, hierarchy);
            }

            if (OutputMode == OutputImage.Contours)
                window.ShowImage(Mat);

            gb.Dispose();

        }
    }
}
