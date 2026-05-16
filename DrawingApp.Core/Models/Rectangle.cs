using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DrawingProject.Models
{
    public class Rectangle : Shape
    {
        [JsonConstructor]
        public Rectangle(float width, float height, Point2D position, string color, int thickness)
        {
            this.Position = position;
            this.Width = width;
            this.Height = height;
            this.Color = color;
            this.Thickness = thickness;
        }
        public Rectangle(float width, float height, Point2D startPoint, Point2D endPoint)
        {
            SetPosition(startPoint, endPoint);
            this.Width = width;
            this.Height = height;
        }
        public Rectangle() { }
        public override float CalculateArea()
        {
            return Width * Height;
        }

    }
}
