﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TerraExplorerX;


namespace FGeo3D_TE
{
    static class GeoHelper
    {
        public static string CreateGroup(string groupName, ref SGWorld66 sgworld)
        {
            var gid = sgworld.ProjectTree.FindItem(groupName);
            if (!string.IsNullOrEmpty(gid))
            {
                return gid;
            }
            return sgworld.ProjectTree.CreateGroup(groupName);
        }

        /// <summary>
        /// 根据ID，在数据库中返回相应的地质对象基本信息。
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static GeoObject GetObject(string id)
        {


            GeoObject result = new GeoObject();
            //
            return result;
        }

        /// <summary>
        /// 通过三维散点集生成回归平面，用过平面的三维点集表示
        /// </summary>
        /// <param name="inGeoPoints">三维散点集</param>
        /// <returns></returns>
        public static List<GeoPoint> FitPlane(List<GeoPoint> inGeoPoints)
        {
            var result = new List<GeoPoint>();


            return result;
        }
    }
}
