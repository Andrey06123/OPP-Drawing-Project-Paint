using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrawingProject.Models;

namespace DrawingProject.Commands
{
    public class CreateShapeCommand : ICommand
    {
        private Shape shape;
        private List<IShape> shapes;

        public CreateShapeCommand(Shape newShape, List<IShape> shapes)
        {
            this.shape = newShape;
            this.shapes = shapes;
        }
        public void Execute()
        {
            shapes.Add(shape);
        }
        public void Undo()
        {
            shapes.Remove(shape);
        }
    }
    public static class ShapeFactory 
    {
        public static Shape Create(Shape.ShapeType shapeType, float width, float height, Point2D location, Point2D endPoint, Point2D[] vertices)
        {
            switch (shapeType)
            {
                case Shape.ShapeType.Circle:
                    return new Circle(width, location, endPoint);
                case Shape.ShapeType.Triangle:
                    return new Triangle(width, height, location, endPoint);
                case Shape.ShapeType.Rectangle:
                    if (width == height)
                        width *= 2;
                    return new Models.Rectangle(width, height, location, endPoint);
                case Shape.ShapeType.Polygon:
                    var scaledVertices = vertices.Select(v => new Point2D(location.X + v.X * width, location.Y + v.Y * height)).ToArray();
                    return new Polygon(scaledVertices);
                case Shape.ShapeType.Select:
                    return new Models.Rectangle(width, height, location, endPoint);
                    
                default:
                    throw new ArgumentException("Invalid shape type");
            }
        }
    }

}
