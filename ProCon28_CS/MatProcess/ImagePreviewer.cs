using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;

namespace ProCon28_CS.MatProcess
{
    class ImagePreviewer : IMatProcess
    {
        private Window window;

        public bool UseRawMat { get; } = true;

        public bool ConvertColor { get; set; } = false;

        public ColorConversionCodes ColorConversionCode { get; set; } = ColorConversionCodes.BGR2GRAY;

        public void Begin()
        {
            window = new Window("Preview_" + (ConvertColor ? ColorConversionCode.ToString() : "Raw Image"));
        }

        public void End()
        {
            window.Dispose();
            window = null;
        }

        public void OnMatChanged(Mat Mat)
        {
            if (ConvertColor)
            {
                using (Mat cvt = new Mat())
                {
                    Cv2.CvtColor(Mat, cvt, ColorConversionCode);
                    window.ShowImage(cvt);
                }
            }
            else
            {
                window.ShowImage(Mat);
            }
        }
    }
}
