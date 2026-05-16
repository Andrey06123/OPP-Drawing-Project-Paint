using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingProject.Models
{
    public interface IShape
    {
        float CalculateArea();
        bool Contains(Point2D point);
        void Move(float x, float y);
    }
}
