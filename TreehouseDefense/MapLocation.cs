﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreehouseDefense
{
    class MapLocation : Point
    {
        
        public MapLocation (int x, int y, Map map) : base (x, y)
        {
            if (!map.OnMap(this))
            {
                throw new Exception(x + "," + y + " is outside of the boundaries of the map.");
            }
        }
        public bool InRangeOf(MapLocation location, int range)
        {
            return DistanceTo(location) <= range;
        }
    }
}
