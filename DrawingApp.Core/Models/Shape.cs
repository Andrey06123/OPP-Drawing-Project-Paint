using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DrawingProject.Models
{
    public abstract class Shape : IShape
    {
        public Point2D Position { get; protected set; }
        public float Width { get; protected set; }
        public float Height { get; protected set; }
        public string Color { get; set; }
        public int Thickness { get; set; } = 10;   


        public enum ResizeDirection
        {
            None,
            TopLeft,
            TopRight,
            BottomLeft,
            Left,
            Right,
            Top,
            Bottom,
            BottomRight
        }
        public enum ShapeType
        {
            Rectangle,
            Circle,
            Triangle,
            Polygon,
            Select,
        }
        public abstract float CalculateArea();
        protected virtual void SetPosition(Point2D startPoint, Point2D endPoint)
        {
            this.Position = new Point2D(Math.Min(startPoint.X, endPoint.X), Math.Min(startPoint.Y, endPoint.Y));
        }
        public virtual bool Contains(Point2D point)
        {
            return point.X >= this.Position.X && point.X <= this.Position.X + Width
                && point.Y >= this.Position.Y && point.Y <= this.Position.Y + Height;
        }
        public virtual ResizeDirection ResizeContains(Point2D point)
        {
            int buffer = 6;
            //float offset = this.Thickness / 2;

            float left = this.Position.X - this.Thickness;
            float right = this.Position.X + Width + this.Thickness;
            float top = this.Position.Y - this.Thickness;
            float bottom = this.Position.Y + Height + this.Thickness;

            float centerX = (left + right) / 2;
            float centerY = (top + bottom) / 2;

            if (point.X >= right - buffer && point.X <= right + buffer &&
               point.Y >= bottom - buffer && point.Y <= bottom + buffer)
            {
                return ResizeDirection.BottomRight;
            }
            else if(point.X <= left + buffer && point.X >= left - buffer &&
                    point.Y >= bottom - buffer && point.Y <= bottom + buffer)
            {
                return ResizeDirection.BottomLeft;
            }
            else if(point.X >= right - buffer && point.X <= right + buffer &&
                    point.Y <= top + buffer && point.Y >= top - buffer)
            {
                return ResizeDirection.TopRight;
            }
            else if(point.X <= left + buffer && point.X >= left - buffer &&
                    point.Y <= top + buffer && point.Y >= top - buffer)
            {
                return ResizeDirection.TopLeft;
            } else if(point.X <= centerX + buffer && point.X >= centerX - buffer&&
                    point.Y <= top + buffer && point.Y >= top - buffer)
            {
                return ResizeDirection.Top;
            } else if(point.Y <= centerY + buffer && point.Y >= centerY - buffer &&
                      point.X <= left + buffer && point.X >= left - buffer)
            {
                return ResizeDirection.Left;
            } else if(point.X <= centerX + buffer && point.X >= centerX - buffer
                      && point.Y <= bottom + buffer && point.Y >= bottom - buffer)
            {
                return ResizeDirection.Bottom;
            } else if(point.X <= right + buffer && point.X >= right - buffer
                      && point.Y <= centerY + buffer && point.Y >= centerY - buffer)
            {
                
                return ResizeDirection.Right;
            }

                return ResizeDirection.None;
        }
        public virtual void Resize(ResizeDirection activeHandle,float width, float height)
        {
            if (activeHandle == ResizeDirection.TopLeft ||
               activeHandle == ResizeDirection.Left ||
               activeHandle == ResizeDirection.BottomLeft)
            {
                this.Width -= width;
                this.Position = new Point2D(Position.X + width, Position.Y);
            }
            if (activeHandle == ResizeDirection.TopLeft ||
               activeHandle == ResizeDirection.Top ||
               activeHandle == ResizeDirection.TopRight)
            {
                this.Position = new Point2D(Position.X, Position.Y + height);
                this.Height -= height;
            }

            if (activeHandle == ResizeDirection.TopRight ||
                activeHandle == ResizeDirection.Right ||
                activeHandle == ResizeDirection.BottomRight)
                this.Width += width;

            if (activeHandle == ResizeDirection.BottomLeft ||
               activeHandle == ResizeDirection.Bottom ||
               activeHandle == ResizeDirection.BottomRight)
                this.Height += height;


            if (this.Width < 1) this.Width = Math.Abs(this.Width);
            if (this.Height < 1) this.Height = Math.Abs(this.Height);
        }
        public virtual ResizeDirection ReverseDirection(ResizeDirection direction)
        {
            switch (direction)
            {
                case ResizeDirection.TopLeft:
                    return ResizeDirection.BottomRight;
                case ResizeDirection.TopRight:
                    return ResizeDirection.BottomLeft;
                case ResizeDirection.BottomLeft:
                    return ResizeDirection.TopRight;
                case ResizeDirection.BottomRight:
                    return ResizeDirection.TopLeft;
                case ResizeDirection.Left:
                    return ResizeDirection.Right;
                case ResizeDirection.Right:
                    return ResizeDirection.Left;
                case ResizeDirection.Top:
                    return ResizeDirection.Bottom;
                case ResizeDirection.Bottom:
                    return ResizeDirection.Top;
                default:
                    return ResizeDirection.None;
            }
        }
        public virtual void Move(float x, float y)
        {
            this.Position = new Point2D(this.Position.X + x, this.Position.Y + y);
        }
        public virtual void MoveTo(Point2D newPosition)
        {
            this.Position = newPosition;
        }
        public virtual void SetSize(float width, float height)
        {
            this.Width = width;
            this.Height = height;
        }

        public virtual Shape GetBounds()
        {
            float width = this.Width + 2 * this.Thickness;
            float height = this.Height + 2 * this.Thickness;
            Point2D position = new Point2D(this.Position.X - this.Thickness, this.Position.Y - this.Thickness);
            return new Rectangle(width, height, position, new Point2D(position.X + width, position.Y + height));
        }

        public virtual Rectangle[] GetHadlers(Shape shape)
        {
            int size = 10;
            float left = shape.Position.X - shape.Thickness;
            float right = shape.Position.X + shape.Width + shape.Thickness;
            float top = shape.Position.Y - shape.Thickness;
            float bottom = shape.Position.Y + shape.Height + shape.Thickness;
            float centerX = shape.Position.X + shape.Width / 2;
            float centerY = shape.Position.Y + shape.Height / 2;

            Rectangle[] handlers = new Rectangle[]
            {
                new Rectangle(size, size, new Point2D(left - size/2, top - size/2), new Point2D(left + size/2, top + size/2)),
                new Rectangle(size, size, new Point2D(right - size/2, top - size/2), new Point2D(right + size/2, top + size/2)),
                new Rectangle(size, size, new Point2D(left - size/2, bottom - size/2), new Point2D(left + size/2, bottom + size/2)),
                new Rectangle(size, size, new Point2D(right - size/2, bottom - size/2), new Point2D(right + size/2, bottom + size/2)),
                new Rectangle(size, size, new Point2D(centerX - size/2, top - size/2), new Point2D(centerX + size/2, top + size/2)),
                new Rectangle(size, size, new Point2D(left - size/2, centerY - size/2), new Point2D(left + size/2, centerY + size/2)),
                new Rectangle(size, size, new Point2D(centerX - size/2, bottom - size/2), new Point2D(centerX + size/2, bottom + size/2)),
                new Rectangle(size, size, new Point2D(right - size/2, centerY - size/2), new Point2D(right + size/2, centerY + size/2))
            };

            return handlers;
        }

    }
}
