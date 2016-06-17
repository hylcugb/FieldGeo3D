﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeoIM.CHIDI.DZ.COM;
using TerraExplorerX;

namespace FGeo3D_TE
{
    class LoggingWell:LoggingObject
    {
        public LoggingWell(IObjData dataObj) : base(dataObj)
        {
        }

        public List<GeoMarkPoint> Marks { get; set; }


        public void Draw(ref SGWorld66 sgworld) { }


    }
}
