using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;

namespace ProCon28_CS.MatProcess
{
    class HarrisCorner : WindowProcessBase
    {
        public override bool UseRawMat { get; } = true;

        public bool UseHarris { get; set; } = true;

        public double Threshold { get; set; } = 0;

        public double QualityLevel { get; set; } = 0.01;

        public int BlockSize { get; set; } = 10;

        protected override string BeginProcess()
        {
            return "Harris Corner";
        }

        protected override void EndProcess()
        {
        }

        protected override Mat MatChanged(Mat Mat)
        {
            Mat cvt = new Mat();
            Cv2.CvtColor(Mat, cvt, ColorConversionCodes.BGR2GRAY);
            Cv2.Threshold(cvt, cvt, Threshold, 255, ThresholdTypes.Tozero);
            Cv2.Threshold(cvt, cvt, 0, 255, ThresholdTypes.Binary | ThresholdTypes.Otsu);
            Point2f[] corners = Cv2.GoodFeaturesToTrack(cvt, 400, QualityLevel, 20, null, BlockSize, true, 10);
            cvt.Dispose();
            foreach(Point2f p in corners)
            {
                Cv2.Circle(Mat, p, 5, Scalar.Red);
            }
            return Mat;
        }
    }
}
