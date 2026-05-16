using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DrawingProject.Models
{
    public class Polygon : Shape
    {
        public Point2D[] Vertices { get; set; }
        private int margin;
        [JsonConstructor]
        public Polygon(Point2D[] vertices, Point2D position, float width, float height, string color, int thickness)
        {
            this.Vertices = vertices;
            this.Position = position;
            this.Width = width;
            this.Height = height;
            this.Color = color;
            this.Thickness = thickness;
            this.Color = "Black";
            this.Thickness = 5;
        }

        public Polygon(Point2D[] verticals)
        {
            this.Vertices = verticals;

            int minX = int.MaxValue;
            int minY = int.MaxValue;
            int maxX = int.MinValue;
            int maxY = int.MinValue;

            foreach (var vertex in Vertices)
            {
                if (vertex.X < minX) minX = (int)vertex.X;
                if (vertex.Y < minY) minY = (int)vertex.Y;
                if (vertex.X > maxX) maxX = (int)vertex.X;
                if (vertex.Y > maxY) maxY = (int)vertex.Y;
            }

            this.Width = maxX - minX;
            this.Height = maxY - minY;
            this.Position = new Point2D(minX, minY);

            this.Color = "Black";
            this.Thickness = 5;
        }
        public Polygon()
        {

        }

        public void PolygonBoxBoundies(Point2D[] vertices)
        {
            int minX = int.MaxValue;
            int minY = int.MaxValue;
            int maxX = int.MinValue;
            int maxY = int.MinValue;
            foreach (var vertex in Vertices)
            {
                if (vertex.X < minX) minX = (int)vertex.X;
                if (vertex.Y < minY) minY = (int)vertex.Y;
                if (vertex.X > maxX) maxX = (int)vertex.X;
                if (vertex.Y > maxY) maxY = (int)vertex.Y;
            }
            for (int i = 0; i < Vertices.Length; i++)
                Vertices[i] = new Point2D(Vertices[i].X - minX, Vertices[i].Y - minY);

            this.Position = new Point2D(minX, minY);
            this.Width = maxX - minX;
            this.Height = maxY - minY;
        }
        
        public override float CalculateArea()
        {
            return 0;
        }
        public override void Move(float x, float y)
        {
            for (int i = 0; i < Vertices.Length; i++)
                Vertices[i] = new Point2D(Vertices[i].X + (int)x, Vertices[i].Y + (int)y);

            base.Move(x, y);
        }
        public override void Resize(ResizeDirection activeHandle, float scaleX, float scaleY)
        {
            return;
        }

    }
        public class Square : Polygon
        {
            public Square(Point2D[] vertices) : base(vertices)
            {
                this.Vertices = vertices;
            }
            public override float CalculateArea()
            {
                return Width * Height;
            }
        }

        public class Pentagon : Polygon
        {
            public Pentagon(Point2D[] vertices)
                : base(vertices)
            {
                this.Vertices = vertices;
            }
            public override float CalculateArea()
            {
                return 0;
            }
        }

        public class Hexagon : Polygon
        {
            public Hexagon(Point2D[] vertices)
                : base(vertices)
            {
                this.Vertices = vertices;
            }
            public override float CalculateArea()
            {
                return 0;
            }
        }

    public class Heptagon : Polygon 
    {
        public Heptagon(Point2D[] vertices)
               : base(vertices)
        {
            this.Vertices = vertices;
        }
        public override float CalculateArea()
        {
            return 0;
        }
    }

    public class Octagon : Polygon 
    {
        public Octagon(Point2D[] vertices)
               : base(vertices)
        {
            this.Vertices = vertices;
        }
        public override float CalculateArea()
        {
            return 0;
        }
    }

    
}
