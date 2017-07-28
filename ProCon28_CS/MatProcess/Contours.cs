using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;

namespace ProCon28_CS.MatProcess
{
    class Contours : WindowProcessBase
    {
        ContoursProcess.Sanitizer Sanitizer = new ContoursProcess.Sanitizer();

        public enum OutputImage
        {
            Gray = 0, Binary = 1, Contours = 2
        }

        private Window window;

        public double Threshold { get; set; } = 0;

        public double MaxValue { get; set; } = 255;

        public override bool UseRawMat { get; } = false;

        public OutputImage OutputMode { get; set; } = OutputImage.Contours;

        protected override string BeginProcess()
        {
            return "Contours";
        }

        protected override void EndProcess()
        {
        }

        protected override Mat MatChanged(Mat Mat)
        {
            Mat gb = new Mat();

            Cv2.CvtColor(Mat, gb, ColorConversionCodes.BGR2GRAY);
            if (OutputMode == OutputImage.Gray)
                return gb;

            Cv2.Threshold(gb, gb, Threshold, MaxValue, ThresholdTypes.Tozero);
            Cv2.Threshold(gb, gb, 0, 255, ThresholdTypes.Binary | ThresholdTypes.Otsu);
            if (OutputMode == OutputImage.Binary)
                return gb;

            Cv2.FindContours(gb, out Point[][] contours, out HierarchyIndex[] hierarchy, RetrievalModes.External, ContourApproximationModes.ApproxTC89L1);

            ContoursInfo sanitized = Sanitizer.Process(new ContoursInfo(contours, hierarchy));
            int length = sanitized.Length;
            for(int i = 0; length > i; i++)
            {
                Cv2.DrawContours(Mat, sanitized.Contours, i, Scalar.Red, 2, LineTypes.Link8, sanitized.Hierarchy);
            }

            gb.Dispose();
            return Mat;
        }
    }
}
