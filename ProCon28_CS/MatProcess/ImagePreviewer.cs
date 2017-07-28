using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;

namespace ProCon28_CS.MatProcess
{
    class ImagePreviewer : WindowProcessBase
    {
        public override bool UseRawMat { get; } = true;

        public bool ConvertColor { get; set; } = false;

        public ColorConversionCodes ColorConversionCode { get; set; } = ColorConversionCodes.BGR2GRAY;

        protected override string BeginProcess()
        {
            return "Preview_" + (ConvertColor ? ColorConversionCode.ToString() : "Raw Image");
        }

        protected override void EndProcess()
        {
        }

        protected override Mat MatChanged(Mat Mat)
        {
            if (ConvertColor)
            {
                Mat cvt = new Mat();
                Cv2.CvtColor(Mat, cvt, ColorConversionCode);
                return cvt;
            }
            else
            {
                return Mat;
            }
        }
    }
}
