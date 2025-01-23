using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex021
{
    internal struct Point
    {

        public double x; public double y;

        public override string ToString()
        {
            return ($"({this.x}, {this.y})");
        }

    }
}
