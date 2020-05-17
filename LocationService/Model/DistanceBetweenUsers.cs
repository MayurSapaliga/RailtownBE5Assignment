using System;
using System.Collections.Generic;
using System.Text;

namespace LocationService.Model
{
    public class DistanceBetweenUsers
    {
        public double Distance { get; set; }
        public int UserId1 { get; set; }
        public int UserId2 { get; set; }
    }
}
