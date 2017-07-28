using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProCon28_CS
{
    static class ProcessManager
    {
        public static MatProcess.Contours Contours { get; } = new MatProcess.Contours();
        public static MatProcess.HarrisCorner Corner { get; } = new MatProcess.HarrisCorner();
    }
}
