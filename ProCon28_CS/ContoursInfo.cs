using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;

namespace ProCon28_CS
{
    class ContoursInfo
    {
        public ContoursInfo(Point[][] Contours, HierarchyIndex[] Hierarchy)
        {
            this.Contours = Contours;
            this.Hierarchy = Hierarchy;
        }

        public Point[][] Contours { get; set; }

        public HierarchyIndex[] Hierarchy { get; set; }

        public int Length
        {
            get
            {
                int len = Contours.Length;
                if (len == Hierarchy.Length)
                    return len;
                else
                    throw new Exception("輪郭情報とヒエラルキーが一致していません");
            }
        }
    }
}
