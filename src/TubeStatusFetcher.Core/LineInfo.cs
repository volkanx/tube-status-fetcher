﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TubeStatusFetcher.Core
{
    public class LineInfo
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int StatusSeverity { get; set; }
        public string StatusSeverityDescription { get; set; }
        public string Reason { get; set; }
        public RGB LineColour
        {
            get
            {
                return TubeColourHelper.GetRGBColour(this.Id);
            }
        }
    }
}
