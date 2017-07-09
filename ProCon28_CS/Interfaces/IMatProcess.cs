using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCon28_CS
{
    public interface IMatProcess
    {
        bool UseRawMat { get; }
        void Begin();
        void End();
        void OnMatChanged(OpenCvSharp.Mat Mat);
    }
}
