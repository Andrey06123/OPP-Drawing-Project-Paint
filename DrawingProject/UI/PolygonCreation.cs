using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrawingProject.Models;
using DrawingProject.Commands;

namespace DrawingProject.UI
{
    public partial class PolygonCreation : Form
    {
        private List<IShape> shapes;
        private Polygon currentShape;

        private List<Circle> handlers = new List<Circle>();
        private Point currentPoint;
        private Circle currentHandler;
        private int index;

        const int margin = 50;

        private Point2D[] SquareVertices;
        private Point2D[] PentagonVertices;
        private Point2D[] HexagonVertices;
        private Point2D[] HeptagonVertices;
        private Point2D[] OctagonVertices;
        public PolygonCreation()
        {
            InitializeComponent();

            this.Width = 800;
            this.Height = 600;
            this.Padding = new Padding(10);
            

            this.Load += PolygonCreation_Load;


            PolygonMenuPanelCreation();

            this.button1.Location = new Point(this.ClientSize.Width - this.button1.Width - 20, this.ClientSize.Height - this.button1.Height - 20);

            this.polygonPreviewPanel.Size = new Size(500, 500);
            this.polygonPreviewPanel.Location = new Point((this.ClientSize.Width / 2) - (this.polygonPreviewPanel.Width / 2) - (this.polygonMenuPanel.Width / 2), this.ClientSize.Height / 2 - this.polygonPreviewPanel.Height / 2);

            this.polygonPreviewPanel.Paint += PolygonPreviewPanel_Paint;

            typeof(Panel).InvokeMember("DoubleBuffered",
            BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
            null, polygonPreviewPanel, new object[] { true });
        }
        public PolygonCreation(List<IShape> mainShapes) : this()
        {
              this.shapes = mainShapes;
        }
        private void polygonPreviewPanel_MouseDown(object sender, MouseEventArgs e)
        {
            for(int i = 0; i < handlers.Count; i++)
            {
                if (handlers[i].Contains(new Point2D(e.Location.X, e.Location.Y)))
                {
                    currentPoint = e.Location;
                    currentHandler = handlers[i];
                    index = i;
                    Cursor.Current = Cursors.Hand;
                    break;
                }
            }
        }

        private void polygonPreviewPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (currentHandler == null)
                return;
            currentHandler.Move(e.Location.X - currentPoint.X, e.Location.Y - currentPoint.Y);
            currentShape.Vertices[index] = new Point2D(currentShape.Vertices[index].X + (e.Location.X - currentPoint.X), currentShape.Vertices[index].Y + (e.Location.Y - currentPoint.Y));

            this.currentPoint = e.Location;
            this.currentShape.Color = "Gray";
            this.polygonPreviewPanel.Invalidate();
        }

        private void polygonPreviewPanel_MouseUp(object sender, MouseEventArgs e)
        {
            currentHandler = null;
            this.currentShape.Color = "Black";

            this.polygonPreviewPanel.Invalidate();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            currentShape.PolygonBoxBoundies(currentShape.Vertices);
            var normalizedVertices = currentShape.Vertices.Select(v => new Point2D((v.X - currentShape.Position.X) / (float)this.currentShape.Width, (v.Y - currentShape.Position.Y) / (float)this.currentShape.Height)).ToArray();

            this.Hide();
            Scene scene = new Scene(shapes, normalizedVertices);
            
            scene.ShowDialog();
            this.Close();
        }
        private void PolygonMenuPanelCreation()
        {
            int shapePanelSize = 100;
            this.polygonMenuPanel.Size = new Size(shapePanelSize * 2, shapePanelSize * 4);
            this.polygonMenuPanel.Location = new Point(this.ClientSize.Width - this.polygonMenuPanel.Width, this.ClientSize.Height / 2 - this.polygonMenuPanel.Height / 2);
        }
        
        private void SetCurrentShape(Polygon polygon)
        {
            currentShape = polygon;
            this.polygonPreviewPanel.Invalidate();
        }

        private void squarePicBox_Click(object sender, EventArgs e)
        {
            SetCurrentShape(new Square(SquareVertices));
        }

        private void pentagonPicBox_Click(object sender, EventArgs e)
        {
            SetCurrentShape(new Pentagon(PentagonVertices));
        }

        private void hexagonPicBox_Click(object sender, EventArgs e)
        {
            SetCurrentShape(new Hexagon(HexagonVertices));
        }
        private void heptagonPicBox_Click(object sender, EventArgs e)
        {
            SetCurrentShape(new Heptagon(HeptagonVertices));
        }

        private void octagonPicBox_Click(object sender, EventArgs e)
        {
            SetCurrentShape(new Octagon(OctagonVertices));
        }

        private void PolygonPreviewPanel_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.LightGray, 1))
            {
                for (int j = 0; j < this.polygonPreviewPanel.Height; j += 50)
                {
                    for (int i = 0; i < this.polygonPreviewPanel.Width; i += 50)
                    {
                        e.Graphics.DrawLine(pen, i, 0, i, this.polygonPreviewPanel.Height);
                        e.Graphics.DrawLine(pen, 0, j, this.polygonPreviewPanel.Width, j);
                    }
                }
            }

            if (currentShape != null)
            {
                handlers.Clear();

                e.Graphics.DrawPolygon(new Pen(Color.FromName(currentShape.Color), currentShape.Thickness), currentShape.Vertices.Select(v => new PointF(v.X, v.Y)).ToArray());
                int resizeHandleSize = 20;
                for (int i = 0; i < currentShape.Vertices.Length; i++)
                {
                    Circle handler = new Circle(resizeHandleSize / 2,new Point2D(currentShape.Vertices[i].X, currentShape.Vertices[i].Y));
                    using (SolidBrush brush = new SolidBrush(Color.Red))
                    {
                        e.Graphics.FillEllipse(brush, handler.Position.X - handler.Radius, handler.Position.Y - handler.Radius, handler.Radius * 2, handler.Radius * 2);
                    }
                    handlers.Add(handler);
                }
            }

        }

        private void PolygonCreation_Load(object sender, EventArgs e)
        {
            SquareVertices = new Point2D[]
            {
                new Point2D(margin, margin),
                new Point2D(this.polygonPreviewPanel.Width - margin, margin),
                new Point2D(this.polygonPreviewPanel.Width - margin, this.polygonPreviewPanel.Height - margin),
                new Point2D(margin, this.polygonPreviewPanel.Height - margin)
            };

            PentagonVertices = new Point2D[]
             {
                new Point2D(this.polygonPreviewPanel.Width / 2, margin),
                new Point2D(this.polygonPreviewPanel.Width - margin, this.polygonPreviewPanel.Height * 2 / 5),
                new Point2D(this.polygonPreviewPanel.Width - margin * 2, this.polygonPreviewPanel.Height - margin),
                new Point2D(margin * 2, this.polygonPreviewPanel.Height - margin),
                new Point2D(margin, this.polygonPreviewPanel.Height * 2 / 5)
             };
            
            HexagonVertices = new Point2D[]
            {
                new Point2D(this.polygonPreviewPanel.Width / 2, margin),
                new Point2D(this.polygonPreviewPanel.Width - margin, this.polygonPreviewPanel.Height / 3),
                new Point2D(this.polygonPreviewPanel.Width - margin, this.polygonPreviewPanel.Height * 2 / 3),
                new Point2D(this.polygonPreviewPanel.Width / 2, this.polygonPreviewPanel.Height - margin),
                new Point2D(margin, this.polygonPreviewPanel.Height * 2 / 3),
                new Point2D(margin, this.polygonPreviewPanel.Height / 3)
             };
             HeptagonVertices = new Point2D[]
             {
                new Point2D(this.polygonPreviewPanel.Width / 2, margin),
                new Point2D(this.polygonPreviewPanel.Width * 3 / 4, margin + (this.polygonPreviewPanel.Height / 6)),
                new Point2D(this.polygonPreviewPanel.Width - margin, this.polygonPreviewPanel.Height / 2),
                new Point2D(this.polygonPreviewPanel.Width * 3 / 4, this.polygonPreviewPanel.Height - margin),
                new Point2D(this.polygonPreviewPanel.Width / 4, this.polygonPreviewPanel.Height - margin),
                new Point2D(margin, this.polygonPreviewPanel.Height / 2),
                new Point2D(this.polygonPreviewPanel.Width / 4, margin + (this.polygonPreviewPanel.Height / 6))
             };
             OctagonVertices = new Point2D[]
             {
                new Point2D(this.polygonPreviewPanel.Width / 3, margin),
                new Point2D(this.polygonPreviewPanel.Width * 2 / 3, margin),
                new Point2D(this.polygonPreviewPanel.Width - margin, this.polygonPreviewPanel.Height / 3),
                new Point2D(this.polygonPreviewPanel.Width - margin, this.polygonPreviewPanel.Height * 2 / 3),
                new Point2D(this.polygonPreviewPanel.Width * 2 / 3, this.polygonPreviewPanel.Height - margin),
                new Point2D(this.polygonPreviewPanel.Width / 3, this.polygonPreviewPanel.Height - margin),
                new Point2D(margin, this.polygonPreviewPanel.Height * 2 / 3),
                new Point2D(margin, this.polygonPreviewPanel.Height / 3)
             };

        }

    }
}
