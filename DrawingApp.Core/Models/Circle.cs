using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DrawingProject.Models
{
    public class Circle : Shape
    {
        public float Radius { get; set; }
        private float RadiusX { get; set; }
        private float RadiusY { get; set; }
        [JsonConstructor]
        public Circle(float radius, Point2D position, float width, float height, string color, int thickness)
        {
            Radius = radius;
            Position = position;
            Width = width;
            Height = height;
            RadiusX = width / 2;
            RadiusY = height / 2;
            Color = color; 
            Thickness = thickness;
        }

        public Circle(float radius, Point2D startPoint, Point2D endPoint)
        {
            this.RadiusY = this.RadiusX = this.Radius = radius;

            this.Width = radius * 2;
            this.Height = radius * 2;
            SetPosition(startPoint, endPoint);
        }
        public Circle() { }
        public Circle(float radius, Point2D center)
        {
            this.Radius = radius;
            this.RadiusX = radius;
            this.RadiusY = radius;
            this.Width = radius * 2;
            this.Height = radius * 2;
            this.Position = center;
        }

        public override float CalculateArea()
        {
            return (float)(Math.PI * Math.Pow(Radius, 2));
        }

        public override bool Contains(Point2D point)
        {
            float dx = point.X - this.Position.X;
            float dy = point.Y - this.Position.Y;

            return (dx * dx + dy * dy) <= (Radius * Radius);
        }
        public int GetRadiusX()
        {
            return (int)this.RadiusX;
        }
        public int GetRadiusY()
        {
            return (int)this.RadiusY;
        }
        public override Shape GetBounds()
        {
            float width = this.Width + 2 * this.Thickness;
            float height = this.Height + 2 * this.Thickness;
            Point2D position = new Point2D(this.Position.X - this.RadiusX - this.Thickness, this.Position.Y - this.RadiusY - this.Thickness);
            return new Rectangle(width, height, position, new Point2D(position.X + width, position.Y + height));
        }

        public override Rectangle[] GetHadlers(Shape shape)
        {
            int size = 10;
            float left = shape.Position.X - ((Circle)shape).GetRadiusX() - shape.Thickness;
            float right = shape.Position.X + ((Circle)shape).GetRadiusX() + shape.Thickness;
            float top = shape.Position.Y - ((Circle)shape).GetRadiusY() - shape.Thickness;
            float bottom = shape.Position.Y + ((Circle)shape).GetRadiusY() + shape.Thickness;
            float centerX = shape.Position.X;
            float centerY = shape.Position.Y;

            Rectangle[] handlers = new Rectangle[] {
                new Rectangle(size, size, new Point2D(left - size / 2, top - size / 2), new Point2D(left + size / 2, top + size / 2)),
                new Rectangle(size, size, new Point2D(right - size / 2, top - size / 2), new Point2D(right + size / 2, top + size / 2)),
                new Rectangle(size, size, new Point2D(left - size / 2, bottom - size / 2), new Point2D(left + size / 2, bottom + size / 2)),
                new Rectangle(size, size, new Point2D(right - size / 2, bottom - size / 2), new Point2D(right + size / 2, bottom + size / 2)),
                new Rectangle(size, size, new Point2D(centerX - size / 2, top - size / 2), new Point2D(centerX + size / 2, top + size / 2)),
                new Rectangle(size, size, new Point2D(left - size / 2, centerY - size / 2), new Point2D(left + size / 2, centerY + size / 2)),
                new Rectangle(size, size, new Point2D(centerX - size / 2, bottom - size / 2), new Point2D(centerX + size / 2, bottom + size / 2)),
                new Rectangle(size, size, new Point2D(right - size / 2, centerY - size / 2), new Point2D(right + size / 2, centerY + size / 2))
            };

            return handlers;
        }

        public override void Resize(ResizeDirection direction, float deltaX, float deltaY)
        {
            float addition = Math.Max(deltaX, deltaY);
            switch (direction)
            {
                case ResizeDirection.TopLeft:
                    this.RadiusX += addition / 2;
                    this.RadiusY += addition / 2;
                    this.Position = new Point2D(this.Position.X - addition / 2, this.Position.Y - addition / 2);
                    break;
                case ResizeDirection.TopRight:
                    this.RadiusX += addition / 2;
                    this.RadiusY += addition / 2;
                    this.Position = new Point2D(this.Position.X - addition / 2, this.Position.Y - addition / 2);
                    break;
                case ResizeDirection.BottomLeft:
                    this.RadiusX += addition / 2;
                    this.RadiusY += addition / 2;
                    this.Position = new Point2D(this.Position.X - addition / 2, this.Position.Y - addition / 2);
                    break;
                case ResizeDirection.BottomRight:
                    this.RadiusX += addition / 2;
                    this.RadiusY += addition / 2;
                    this.Position = new Point2D(this.Position.X - addition / 2, this.Position.Y - addition / 2);
                    break;
                case ResizeDirection.Left:
                case ResizeDirection.Right:
                    RadiusX += deltaX / 2;
                    this.Position = new Point2D(this.Position.X + deltaX / 2, this.Position.Y);
                    break;
                case ResizeDirection.Top:
                case ResizeDirection.Bottom:
                    RadiusY += deltaY / 2;
                    this.Position = new Point2D(this.Position.X, this.Position.Y - deltaY / 2);
                    break;
            }


            this.Width = RadiusX * 2;
            this.Height = RadiusY * 2;
        }

        public override ResizeDirection ResizeContains(Point2D point)
        {
            int buffer = 6;

           

            float left = this.Position.X - RadiusX - this.Thickness;
            float right = this.Position.X - RadiusX + Width + this.Thickness;
            float top = this.Position.Y - RadiusY - this.Thickness;
            float bottom = this.Position.Y - RadiusY + Height + this.Thickness;

            float centerX = (left + right) / 2;
            float centerY = (top + bottom) / 2;

            if (point.X >= right - buffer && point.X <= right + buffer &&
               point.Y >= bottom - buffer && point.Y <= bottom + buffer)
            {
                return ResizeDirection.BottomRight;
            }
            else if (point.X <= left + buffer && point.X >= left - buffer &&
                    point.Y >= bottom - buffer && point.Y <= bottom + buffer)
            {
                return ResizeDirection.BottomLeft;
            }
            else if (point.X >= right - buffer && point.X <= right + buffer &&
                    point.Y <= top + buffer && point.Y >= top - buffer)
            {
                return ResizeDirection.TopRight;
            }
            else if (point.X <= left + buffer && point.X >= left - buffer &&
                    point.Y <= top + buffer && point.Y >= top - buffer)
            {
                return ResizeDirection.TopLeft;
            }
            else if (point.X <= centerX + buffer && point.X >= centerX - buffer &&
                    point.Y <= top + buffer && point.Y >= top - buffer)
            {
                return ResizeDirection.Top;
            }
            else if (point.Y <= centerY + buffer && point.Y >= centerY - buffer &&
                      point.X <= left + buffer && point.X >= left - buffer)
            {
                return ResizeDirection.Left;
            }
            else if (point.X <= centerX + buffer && point.X >= centerX - buffer
                      && point.Y <= bottom + buffer && point.Y >= bottom - buffer)
            {
                return ResizeDirection.Bottom;
            }
            else if (point.X <= right + buffer && point.X >= right - buffer
                      && point.Y <= centerY + buffer && point.Y >= centerY - buffer)
            {

                return ResizeDirection.Right;
            }

            return ResizeDirection.None;
        }
    }
}
