using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;

namespace ProCon28_CS.ContoursProcess
{
    class Sanitizer : IContoursProcess
    {
        public int UnderLimitation { get; set; } = 0;

        public int MaxLimitation { get; set; } = 200;

        public double MinimumDistance { get; set; } = 0;
        
        public ContoursInfo Process(ContoursInfo Info)
        {
            List<Point[]> points = new List<Point[]>();
            List<HierarchyIndex> hierarchy = new List<HierarchyIndex>();

            int length = Info.Length;
            for(int i = 0;length > i; i++)
            {
                Point[] point = Info.Contours[i];
                HierarchyIndex index = Info.Hierarchy[i];

                int len = point.Length;
                if (len >= UnderLimitation && len <= MaxLimitation)
                {
                    bool use = true;
                    int plen = point.Length;
                    for(int pi = 1;plen > pi; pi++)
                    {
                        Point pb = point[pi - 1];
                        Point cur = point[pi];
                        double distance = Math.Sqrt(Math.Pow(cur.X - pb.X, 2) + Math.Pow(cur.Y - pb.Y, 2));
                        if(distance < MinimumDistance)
                        {
                            use = false;
                            break;
                        }
                    }

                    if (use)
                    {
                        points.Add(point);
                        hierarchy.Add(index);
                    }
                }
            }

            UpdateHierarchy(hierarchy);
            return new ContoursInfo(points.ToArray(), hierarchy.ToArray());
        }

        void UpdateHierarchy(List<HierarchyIndex> hierarchy)
        {
            int count = hierarchy.Count;
            for(int i = 0;count > i; i++)
            {
                HierarchyIndex cur = hierarchy[i];
                cur.Previous = i - 1;
                cur.Next = i + 1 == count ? -1 : i + 1;
                cur.Parent = -1;
                cur.Child = -1;
            }
        }
    }
}
