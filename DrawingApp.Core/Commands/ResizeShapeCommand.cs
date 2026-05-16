using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using DrawingProject.Models;

namespace DrawingProject.Commands
{
    public class ResizeShapeCommand : ICommand
    {
        private Shape shape;
        private Shape.ResizeDirection direction;
        private float deltaX;
        private float deltaY;
        private Point2D newPosition;
        private float newWidth;
        private float newHeight;

        private float originalWidth;
        private float originalHeight;
        private Point2D originalPosition;

        public ResizeShapeCommand(Shape shape, Shape.ResizeDirection direction, float deltaX, float deltaY)
        {
            this.shape = shape;
            this.direction = direction;
            this.deltaX = deltaX;
            this.deltaY = deltaY;
        }
        public ResizeShapeCommand(Shape shape, Shape.ResizeDirection direction, float deltaX, float deltaY, Point2D originalPosition, float originalWidth, float originalHeight)
        {
            this.shape = shape;
            this.direction = direction;
            this.deltaX = deltaX;
            this.deltaY = deltaY;

            newPosition = shape.Position;
            newWidth = shape.Width;
            newHeight = shape.Height;

            this.originalPosition = originalPosition;
            this.originalWidth = originalWidth;
            this.originalHeight = originalHeight;
        }

        public void Execute()
        {
           if (newPosition != null)
            {
                shape.MoveTo(newPosition);
                shape.SetSize(newWidth, newHeight);
                return;
            }
            shape.Resize(direction, deltaX, deltaY);
        }

        public void Undo()
        {
            shape.MoveTo(originalPosition);
            shape.SetSize(originalWidth, originalHeight);
        }
    }
}
