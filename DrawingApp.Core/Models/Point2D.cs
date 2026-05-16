using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingProject.Models
{
    public class Point2D
    {
        public float X { get; set; }
        public float Y { get; set; }

        public Point2D(float x, float y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
