using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;

namespace ProCon28_CS.MatProcess
{
    abstract class WindowProcessBase : IMatProcess
    {
        private Window window;

        public abstract bool UseRawMat { get; }

        protected abstract string BeginProcess();
        protected abstract void EndProcess();
        protected abstract Mat MatChanged(Mat Mat);

        private bool SaveMat = false;
        private string fname = null;

        public void SaveCurrentMat(string Filename)
        {
            fname = Filename;
            SaveMat = true;
        }

        public void Begin()
        {
            window = new Window(BeginProcess());
        }

        public void End()
        {
            window.Dispose();
            window = null;
            EndProcess();
        }

        public void OnMatChanged(Mat Mat)
        {
            Mat mat = MatChanged(Mat);
            window.ShowImage(mat);

            if (SaveMat)
            {
                mat.SaveImage(fname);
                SaveMat = false;
                fname = null;
            }

            mat.Dispose();
        }
    }
}
