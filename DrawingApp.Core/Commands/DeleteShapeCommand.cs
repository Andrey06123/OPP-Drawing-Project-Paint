using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrawingProject.Models;

namespace DrawingProject.Commands
{
    public class DeleteShapeCommand : ICommand
    {
        private List<IShape> shapes;
        private Shape shape;
        public DeleteShapeCommand(Shape shape, List<IShape> shapes) 
        { 
            this.shape = shape;
            this.shapes = shapes;
        }

        public void Execute() {
            shapes.Remove(shape);
        }
        public void Undo() 
        { 
            shapes.Add(shape);
        }
    }
}
