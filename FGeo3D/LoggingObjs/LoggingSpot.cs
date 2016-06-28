﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeoIM.CHIDI.DZ.COM;
using TerraExplorerX;

namespace FGeo3D_TE
{
    class LoggingSpot:LoggingObject
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double H { get; set; }

        

        public LoggingSpot(IObjData dataObj, ref SGWorld66 sgworld) : base(dataObj, ref sgworld)
        {
        }

        public void Draw(ref SGWorld66 sgworld) { }



        public override void Store()
        {
            base.Store();
        }


    }
}
