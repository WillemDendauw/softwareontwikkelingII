﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coderingen.Pattern
{
    public class BasisCodering : ICodering
    {
        public string Codeer(string zin)
        {
            return zin;
        }
    }
}
