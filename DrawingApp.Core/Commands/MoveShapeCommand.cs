using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using DrawingProject.Models;

namespace DrawingProject.Commands
{
    public class MoveShapeCommand : ICommand
    {
        private Shape shape;
        private int deltaX;
        private int deltaY;

        public MoveShapeCommand(Shape shape, int deltaX, int deltaY)
        {
            this.shape = shape;
            this.deltaX = deltaX;
            this.deltaY = deltaY;
        }

        public void Execute()
        {
            shape.Move(deltaX, deltaY);
        }

        public void Undo()
        {
            shape.Move(-deltaX, -deltaY);
        }
    }
}
