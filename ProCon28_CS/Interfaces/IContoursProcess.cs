﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;

namespace ProCon28_CS
{
    interface IContoursProcess
    {
        ContoursInfo Process(ContoursInfo Info);
    }
}
