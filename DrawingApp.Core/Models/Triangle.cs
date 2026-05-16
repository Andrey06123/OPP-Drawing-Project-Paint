using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingProject.Models
{
    public class Triangle : Shape
    {
        private Point2D[] triangleVertices = new Point2D[3];
        [JsonConstructor]
        public Triangle(float width, float height, Point2D position, string color, int thickness) 
        {
            this.Width = width;
            this.Height = height;
            this.Position = position;
            this.Color = color;
            this.Thickness = thickness;

            triangleVertices[0] = new Point2D(Position.X + (Width / 2), Position.Y);
            triangleVertices[1] = new Point2D(Position.X, Position.Y + Height);
            triangleVertices[2] = new Point2D(Position.X + Width, Position.Y + Height);
        }
        public Triangle(float width, float height, Point2D startPoint, Point2D endPoint)
        {
            
            SetPosition(startPoint, endPoint);
            
            this.Width = width;
            this.Height = height;

            triangleVertices[0] = new Point2D(Position.X + (Width / 2), Position.Y);
            triangleVertices[1] = new Point2D(Position.X, Position.Y + Height);
            triangleVertices[2] = new Point2D(Position.X + Width, Position.Y + Height);
        }
        public Triangle() { }
        public override void Move(float x, float y)
        {
            for (int i = 0; i < triangleVertices.Length; i++)
                triangleVertices[i] = new Point2D(triangleVertices[i].X + (int)x, triangleVertices[i].Y + (int)y);

            base.Move(x, y);
        }
        public override void Resize(ResizeDirection activeHandle, float width, float height)
        {
            base.Resize(activeHandle, width, height);
            UpdateVertices();
        }
        private void UpdateVertices()
        {
            triangleVertices[0] = new Point2D(Position.X + (Width / 2), Position.Y);
            triangleVertices[1] = new Point2D(Position.X, Position.Y + Height);
            triangleVertices[2] = new Point2D(Position.X + Width, Position.Y + Height);
        }
        public override float CalculateArea()
        {
            return (Width * Height) / 2;
        }
        public Point2D[] GetVertices()
        {
            return triangleVertices;
        }
    }
}
