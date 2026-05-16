using DrawingProject.Commands;
using DrawingProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using static DrawingProject.Models.Shape;


namespace DrawingProject.UI
{
    public partial class Scene : Form
    {
        private List<IShape> shapes = new List<IShape>();
        private List<Shape> selectedShapes = new List<Shape>();
        private Shape selectedShape;

        private bool IsSelected;
        private Shape selecterShape;
        Shape.ResizeDirection resizeDirection;
        Shape.ShapeType shapeType;
        private Point lastMousePosition;
        private bool reverseResize = false;

        Point2D originalPosition;
        float originalWidth;
        float originalHeight;

        private Point startingPoint;
        private Point endPoint;
        private Shape previewShape;
        private bool isDragging = false;

        private Stack<ICommand> UndoStack = new Stack<ICommand>();
        private Stack<ICommand> RedoStack = new Stack<ICommand>();

        Graphics g;
        Bitmap canvas;
        private string currentFilepath = "";

        bool brush = false;
        private Color currentColor = Color.Black;
        private int thickness;
        Point2D[] normalize;
        public Scene()
        {
            InitializeComponent();


            this.Width = Screen.PrimaryScreen.Bounds.Width - Screen.PrimaryScreen.Bounds.Width / 3 + 50;
            this.Height = Screen.PrimaryScreen.Bounds.Height - Screen.PrimaryScreen.Bounds.Height / 3;

            CreatePalette();
            CreateShapeMenuItem();
            CreateToolMenuItem();

            thicknessTextBox.Text = "10";
            thickness = int.Parse(thicknessTextBox.Text);
            thicknessTextBox.TextChanged += thicknessTextBoxChanged;

            canvas = new Bitmap(DrawingPicBox.Width, DrawingPicBox.Height);
            g = Graphics.FromImage(canvas);
            g.Clear(Color.White);

            DrawingPicBox.Image = canvas;
            this.mainPanel.Height += this.moreColorsBtn.Height - 10;

            int lockHeight = this.mainPanel.Height;
            this.colorMainPanel.Height = lockHeight;
            this.shapesPanel.Height = lockHeight;
            this.selectPanel.Height = lockHeight;

            this.KeyPreview = true;
            this.KeyDown += Scene_KeyDown;

            this.DrawingPicBox.Paint += DrawingPicBox_Paint;

            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint |
                          ControlStyles.OptimizedDoubleBuffer, true);
            this.UpdateStyles();
        }
        public Scene(List<IShape> loadedShapes, Point2D[] polygonVertices) : this()
        {
            this.shapes = loadedShapes;
            this.normalize = polygonVertices;
            this.shapeType = Shape.ShapeType.Polygon;
            this.DrawingPicBox.Invalidate();
        }
        private void DrawingPicBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics gCanvas = e.Graphics;
            gCanvas.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            foreach (IShape shape in shapes)
                DrawShape(gCanvas, shape);

            if (selectedShape != null)
                DrawSelectedShapeBorder(gCanvas, selectedShape);

            if (selecterShape != null)
                DrawShape(gCanvas, selecterShape);

            if (previewShape != null)
                DrawShape(gCanvas, previewShape);
        }
        public void UnselectAll()
        {
            selectedShape = null as Shape;
            selectedShapes.Clear();
            this.DrawingPicBox.Invalidate();
        }
        public void Scene_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back && selectedShape != null as Shape)
            {
                DeleteShapeAction(selectedShape, shapes);
            }
            if (e.Control && e.KeyCode == Keys.Z)
                {
                    Undo();
                }
            else if (e.Control && e.KeyCode == Keys.Y)
            {
                    Redo();
            }

            if (e.Control && e.KeyCode == Keys.S)
            {
                    QuickSave();
            }
        }
        public void thicknessTextBoxChanged(object sender, EventArgs e)
        {
            if(int.TryParse(thicknessTextBox.Text, out int newThickness))
            {
                if(newThickness< 1) newThickness = 1;
                if(newThickness > 50) newThickness = 50;

                thickness = newThickness;
                thicknessTextBox.Text = thickness.ToString();
            }
            else
            {
                thicknessTextBox.Text = thickness.ToString();
            }

        }

        public void Scene_MouseDown(object sender, MouseEventArgs e)
        {
            if (selectedShape == null as Shape)
            {
                selectedShape = shapes.Any(s => s.Contains(new Point2D(e.Location.X, e.Location.Y))) ?
                                shapes.Last(s => s.Contains(new Point2D(e.Location.X, e.Location.Y))) as Shape 
                                : null as Shape;
            }

            if (selectedShape != null as Shape && selectedShape.Contains(new Point2D(e.Location.X, e.Location.Y)))
            {
                Cursor = Cursors.SizeAll;
                isDragging = true;

                originalPosition = selectedShape.Position;
                lastMousePosition = e.Location;
                resizeDirection = Shape.ResizeDirection.None;
            }
            else if (selectedShape != null as Shape && selectedShape.ResizeContains(new Point2D(e.Location.X, e.Location.Y)) != Shape.ResizeDirection.None)
            {
                originalPosition = selectedShape.Position;
                originalWidth = selectedShape.Width;
                originalHeight = selectedShape.Height;

                isDragging = true;
                lastMousePosition = e.Location;
                resizeDirection = selectedShape.ResizeContains(new Point2D(e.Location.X, e.Location.Y));


            }
            else
            {
                Cursor = Cursors.Default;
                selectedShape = null as Shape;
            }


            if (!IsSelected && e.Button == MouseButtons.Left && shapeType == Shape.ShapeType.Select)
            {
                startingPoint = e.Location;
                isDragging = true;
                return;
            }


            if (e.Button == MouseButtons.Left)
            {
                startingPoint = e.Location;
                isDragging = true;
            }
            this.DrawingPicBox.Invalidate();
        }

        private void Scene_MouseMove(object sender, MouseEventArgs e)
        {

            if (selectedShape != null as Shape && selectedShape.ResizeContains(new Point2D(e.Location.X, e.Location.Y)) != Shape.ResizeDirection.None)
                Cursor = GetCursorForResizeHandle(selectedShape.ResizeContains(new Point2D(e.Location.X, e.Location.Y)));
            else
                Cursor = Cursors.Default;

            if (isDragging)
            {
                if (selectedShape != null)
                {
                    if (resizeDirection != Shape.ResizeDirection.None)
                    {
                        int additionalX = e.Location.X - lastMousePosition.X;
                        int additionalY = e.Location.Y - lastMousePosition.Y;

                        ResizeAction(selectedShape, resizeDirection, additionalX, additionalY);

                        if ((selectedShape.Width < 1 || selectedShape.Height < 1) && !reverseResize)
                        {
                            resizeDirection = selectedShape.ReverseDirection(resizeDirection);
                            reverseResize = true;
                        }
                        else if (selectedShape.Width < 1 && selectedShape.Height < 1 && reverseResize)
                        {
                            resizeDirection = selectedShape.ReverseDirection(resizeDirection);
                            reverseResize = false;
                        }

                        lastMousePosition = e.Location;
                        
                    }
                    else
                    {
                        MoveAction(selectedShape, e.X - lastMousePosition.X, e.Y - lastMousePosition.Y);
                        Cursor = Cursors.SizeAll;
                        lastMousePosition = e.Location;
                    }
                    this.DrawingPicBox.Invalidate();
                    return;
                }

                if (shapeType != Shape.ShapeType.Select)
                {
                    endPoint = e.Location;
                    previewShape = ShapeFactory.Create(shapeType,
                                                        e.Location.X - startingPoint.X,
                                                        e.Location.Y - startingPoint.Y,
                                                        new Point2D(startingPoint.X, startingPoint.Y),
                                                        new Point2D(endPoint.X, endPoint.Y),
                                                        normalize);
                    previewShape.Color = "Gray";
                }
                else
                {
                    endPoint = e.Location;
                    selecterShape = ShapeFactory.Create(shapeType,
                                                        e.Location.X - startingPoint.X,
                                                        e.Location.Y - startingPoint.Y,
                                                        new Point2D(startingPoint.X, startingPoint.Y),
                                                        new Point2D(endPoint.X, endPoint.Y),
                                                        normalize);
                    selecterShape.Color = "Black";
                }
                this.DrawingPicBox.Invalidate();
            }
        }

        private void Scene_MouseUp(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                if (selectedShape != null as Shape && isDragging && resizeDirection == Shape.ResizeDirection.None)
                {
                    ICommand moveCommand = new MoveShapeCommand(selectedShape,
                                                                (int)(selectedShape.Position.X - originalPosition.X),
                                                                (int)(selectedShape.Position.Y - originalPosition.Y));
                    UndoStack.Push(moveCommand);
                    RedoStack.Clear();
                }

                if (selectedShape != null as Shape && isDragging && resizeDirection != Shape.ResizeDirection.None)
                {
                    ICommand resizeCommand = new ResizeShapeCommand(selectedShape, resizeDirection,
                                                                    selectedShape.Width - originalWidth,
                                                                    selectedShape.Height - originalHeight,
                                                                    new Point2D(originalPosition.X, originalPosition.Y), originalWidth, originalHeight);
                    UndoStack.Push(resizeCommand);
                    RedoStack.Clear();
                }

                if (shapeType != Shape.ShapeType.Select && selectedShape == null as Shape)
                {
                    endPoint = e.Location;
                    //int width = e.Location.X - startingPoint.X;
                    //int height = e.Location.Y - startingPoint.Y;

                    CreateShapeAction(shapeType, e.Location.X - startingPoint.X, e.Location.Y - startingPoint.Y, new Point2D(startingPoint.X, startingPoint.Y), new Point2D(endPoint.X, endPoint.Y), normalize);
                }

                reverseResize = false;
                previewShape = null;
                isDragging = false;
                this.DrawingPicBox.Invalidate();
            }
        }
        private void circlePicBox_MouseClick(object sender, MouseEventArgs e)
        {
            shapeType = Shape.ShapeType.Circle;

            circlePanel.BackColor = Color.AliceBlue;
            rectPanel.BackColor = Color.Transparent;
            triangPanel.BackColor = Color.Transparent;
            polygonPanel.BackColor = Color.Transparent;
        }

        private void rectPicBox_Click(object sender, EventArgs e)
        {
            shapeType = Shape.ShapeType.Rectangle;

            circlePanel.BackColor = Color.Transparent;
            rectPanel.BackColor = Color.AliceBlue;
            triangPanel.BackColor = Color.Transparent;
            polygonPanel.BackColor = Color.Transparent;
        }

        private void trianglePicBox_Click(object sender, MouseEventArgs e)
        {
            shapeType = Shape.ShapeType.Triangle;

            circlePanel.BackColor = Color.Transparent;
            rectPanel.BackColor = Color.Transparent;
            triangPanel.BackColor = Color.AliceBlue;
            polygonPanel.BackColor = Color.Transparent;
        }
        private void polygonPicBox_Click(object sender, EventArgs e)
        {

            shapeType = Shape.ShapeType.Polygon;

            circlePanel.BackColor = Color.Transparent;
            rectPanel.BackColor = Color.Transparent;
            triangPanel.BackColor = Color.Transparent;
            polygonPanel.BackColor = Color.AliceBlue;

            this.Hide();

            Form polygonForm = new PolygonCreation(shapes);
            polygonForm.ShowDialog();
            this.Close();
        }

        private void pictureBox1_MouseClick_1(object sender, MouseEventArgs e)
        {
            shapeType = Shape.ShapeType.Select;
        }

        private void SaveAsImage()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Drawing|*.json|PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp";
                saveFileDialog.Title = "Save the drawing";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    string extension = Path.GetExtension(filePath).ToLower();

                    if (extension == ".json")
                    {
                        var settings = new JsonSerializerSettings
                        {
                            TypeNameHandling = TypeNameHandling.All,
                            Formatting = Formatting.Indented
                        };

                        string json = JsonConvert.SerializeObject(shapes, settings);
                        File.WriteAllText(filePath, json); 
                    }
                    else
                    {
                        canvas.Save(filePath); 
                    }

                    currentFilepath = filePath;
                    toolStripLabel1.Text = filePath;
                    MessageBox.Show("Saved successfully as " + extension.ToUpper());
                }
            }
        }
        private void QuickSave()
        {
            if (!string.IsNullOrEmpty(currentFilepath))
            {
                string extension = Path.GetExtension(currentFilepath).ToLower();
                if(extension == ".json")
                {
                    var settings = new JsonSerializerSettings
                    {
                       TypeNameHandling = TypeNameHandling.All,
                       Formatting = Formatting.Indented
                    };
                    string json = JsonConvert.SerializeObject(shapes, settings);
                    File.WriteAllText(currentFilepath, json);
                }
                else
                    canvas.Save(currentFilepath);
            }
            else
            {
                SaveAsImage();
            }
        }

        private void OpenImage()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "All supported files|*.json;*.png;*.jpg;*.bmp|Drawing|*.json|Image files|*.png;*.jpg;*.bmp";
                

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    string extension = Path.GetExtension(filePath).ToLower();

                    if (extension == ".json")
                    {
                        string jsonString = File.ReadAllText(openFileDialog.FileName);

                        if (string.IsNullOrWhiteSpace(jsonString))
                        {
                            MessageBox.Show("The selected file is empty.");
                            return;
                        }

                        var settings = new JsonSerializerSettings
                        {
                            TypeNameHandling = TypeNameHandling.All,
                        };
                        shapes = JsonConvert.DeserializeObject<List<IShape>>(jsonString, settings);
                        g.Clear(Color.White);
                       
                    }
                    else
                    {
                        using (Bitmap temp = new Bitmap(openFileDialog.FileName))
                        {
                            g.Dispose();
                            canvas.Dispose();

                            canvas = new Bitmap(temp, DrawingPicBox.Width, DrawingPicBox.Height);

                            g = Graphics.FromImage(canvas);
                        }
                        shapes.Clear();
                    }
                    toolStripLabel1.Text = openFileDialog.FileName;
                    currentFilepath = openFileDialog.FileName;
                    DrawingPicBox.Image = canvas;

                    UndoStack.Clear();
                    RedoStack.Clear();

                    this.DrawingPicBox.Invalidate();
                    MessageBox.Show("Loaded successfully");
                }
            }
        }
        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAsImage();
            UnselectAll();
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuickSave();
            UnselectAll();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenImage();
            UnselectAll();
        }

        private void DoAction(ICommand command)
        {
            command.Execute();
            this.DrawingPicBox.Invalidate();
            if (command is MoveShapeCommand ||
                command is ResizeShapeCommand)
            {
                return;
            }
            UnselectAll();
            UndoStack.Push(command);
            RedoStack.Clear();
        }
        private void MoveAction(Shape selectedShape, float x, float y)
        {
            ICommand moveCommand = new MoveShapeCommand(selectedShape, (int)x, (int)y);
            DoAction(moveCommand);
        }

        private void ResizeAction(Shape selectedShape, Shape.ResizeDirection direction, float x, float y)
        {
            ICommand resizeCommand = new ResizeShapeCommand(selectedShape, direction, x, y);
            DoAction(resizeCommand);
        }

        private void DeleteShapeAction(Shape selectedShape, List<IShape> selectedShapes)
        {
            ICommand createCommand = new DeleteShapeCommand(selectedShape, selectedShapes);
            DoAction(createCommand);
        }

        private void CreateShapeAction(Shape.ShapeType shapeType, float width, float height, Point2D location, Point2D endPoint, Point2D[] vertices)
        {
            Shape newShape = ShapeFactory.Create(shapeType, width, height, new Point2D(location.X, location.Y), new Point2D(endPoint.X, endPoint.Y), vertices);
            newShape.Color = currentColor.Name;
            newShape.Thickness = thickness;
           
            ICommand createCommand = new CreateShapeCommand(newShape, shapes);
            DoAction(createCommand);
        }
        private void Undo()
        {
            if (UndoStack.Count > 0)
            {
                ICommand cmd = UndoStack.Pop();
                cmd.Undo();
                RedoStack.Push(cmd);
                this.DrawingPicBox.Invalidate();
            }
        }

        private void Redo()
        {
            if (RedoStack.Count > 0)
            {
                ICommand cmd = RedoStack.Pop();
                cmd.Execute();
                UndoStack.Push(cmd);
                this.DrawingPicBox.Invalidate();
            }
        }
        private void undoBtn_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void redoBtn_Click(object sender, EventArgs e)
        {
            Redo();
        }

        private void circlePicBox_Click(object sender, EventArgs e)
        {

        }

        private void CreatePalette()
        {
            int squaresSize = 25;
            palette.Width = 8 * squaresSize + 2;
            palette.Padding = new Padding(0);
            palette.Margin = new Padding(0);
            palette.Height = colorMainPanel.Height - 20;
            palette.Location = new Point(10, 10);
            Color[] colors = new Color[]
            {
                Color.Black, Color.Maroon, Color.Olive, Color.DarkGreen, Color.Teal, Color.Navy, Color.Indigo, Color.DarkSlateGray,
                Color.DimGray, Color.Brown, Color.OliveDrab, Color.Green, Color.LightSeaGreen, Color.MediumBlue, Color.Purple, Color.SlateGray,
                Color.Gray, Color.IndianRed, Color.YellowGreen, Color.LimeGreen, Color.MediumTurquoise, Color.RoyalBlue, Color.MediumOrchid, Color.LightSlateGray,
                Color.LightGray, Color.LightCoral, Color.Khaki, Color.LightGreen, Color.PaleTurquoise, Color.LightSkyBlue, Color.Plum, Color.WhiteSmoke
            };

            palette.Controls.Clear();
            foreach (Color color in colors)
            {
                Panel colorPanel = new Panel
                {
                    BackColor = color,
                    Width = squaresSize,
                    Height = squaresSize,
                    Margin = new Padding(0),
                    Padding = new Padding(0)
                };

                colorPanel.Click += colorPanel_Click;
                palette.Controls.Add(colorPanel);
            }
            int borderSize = 16;

            colorMainPanel.Width = palette.Location.X + palette.Width + squaresSize * 2 + borderCurrColPanel.Width;

            currentColorPanel.BackColor = currentColor;
            currentColorPanel.Location = new Point(borderSize / 2, borderSize / 2);
            currentColorPanel.Width = squaresSize * 2;
            currentColorPanel.Height = squaresSize * 2;

            borderCurrColPanel.Location = new Point(palette.Location.X + palette.Width + squaresSize, colorMainPanel.Height / 4);
            borderCurrColPanel.Width = currentColorPanel.Width + borderSize;
            borderCurrColPanel.Height = currentColorPanel.Height + borderSize;

            moreColorsBtn.Location = new Point(palette.Left, palette.Bottom - 5);
            moreColorsBtn.Width = palette.Width;
        }
        private void colorPanel_Click(object sender, EventArgs e)
        {
            Panel p = sender as Panel;
            currentColorPanel.BackColor = p.BackColor;
            currentColor = p.BackColor;
        }

        private void moreColorsBtn_Click(object sender, EventArgs e)
        {
            using (ColorForm colorPalette = new ColorForm())
            {
                if (colorPalette.ShowDialog() == DialogResult.OK)
                {
                    currentColor = colorPalette.GetColor();
                    currentColorPanel.BackColor = currentColor;
                }
            }
        }
        private void CreateShapeMenuItem()
        {
            int centerY = this.shapesPanel.Height / 2;
            int spacing = 10;
            triangPanel.Location = new Point(spacing, centerY - triangPanel.Height / 2);
            circlePanel.Location = new Point(spacing * 2 + triangPanel.Width, centerY - circlePanel.Height / 2);
            rectPanel.Location = new Point(spacing * 3 + triangPanel.Width + circlePanel.Width, centerY - rectPanel.Height / 2);
            polygonPanel.Location = new Point(spacing * 4 + triangPanel.Width + circlePanel.Width + rectPanel.Width, centerY - polygonPanel.Height / 2);

            this.shapesPanel.Width = rectPanel.Width + circlePanel.Width + triangPanel.Width + polygonPanel.Width + spacing * 5;
        }
        private void CreateToolMenuItem()
        {
            this.toolPanel.Height = 150;
            this.toolPanel.Width =  this.selectPanel.Width * 3 + 60;

            penPanel.BackColor = Color.AliceBlue;
            penPanel.Location = new Point(penPanel.Location.X, 23);
            brushPanel.Location = new Point(brushPanel.Location.X, 23);
        }
        public void DrawShape(Graphics g, IShape shape)
        {
            using (Pen pen = new Pen(Color.FromName(((Shape)shape).Color), ((Shape)shape).Thickness))
            {
                switch (shape)
                {
                    case Circle circle:
                        g.DrawEllipse(pen, circle.Position.X - circle.GetRadiusX(), circle.Position.Y - circle.GetRadiusY(), circle.GetRadiusX() * 2, circle.GetRadiusY() * 2);
                        break;
                    case Models.Rectangle rect:
                        g.DrawRectangle(pen, rect.Position.X, rect.Position.Y, rect.Width, rect.Height);
                        break;
                    case Triangle triangle:
                        Point[] points = triangle.GetVertices().Select(v => new Point((int)v.X, (int)v.Y)).ToArray();
                        g.DrawPolygon(pen, points);
                        break;
                    case Polygon polygon:
                        Point[] polyPoints = polygon.Vertices.Select(v => new Point((int)v.X, (int)v.Y)).ToArray();
                        g.DrawPolygon(pen, polyPoints);
                        break;
                }
            }
               
        }
        
        public void DrawSelectedShapeBorder(Graphics g, Shape shape)
        {
            Color borderColor = Color.LightGray;
            Shape border = shape.GetBounds();
            g.DrawRectangle(new Pen(borderColor, 2),
                            border.Position.X,
                            border.Position.Y,
                            border.Width,
                            border.Height);

            DrawResizeHadlers(g, shape);
        }
        public void DrawResizeHadlers(Graphics g, Shape shape) 
        {
            Models.Rectangle[] handlers = shape.GetHadlers(shape);
            foreach (Models.Rectangle handler in handlers)
            {
                using(SolidBrush brush = new SolidBrush(Color.LightGray))
                {
                    g.FillRectangle(brush, handler.Position.X, handler.Position.Y, handler.Width, handler.Height);
                }
            }
        }
        public Cursor GetCursorForResizeHandle(ResizeDirection handle)
        {
            switch (handle)
            {
                case ResizeDirection.TopLeft:
                case ResizeDirection.BottomRight:
                    return Cursors.SizeNWSE;
                case ResizeDirection.TopRight:
                case ResizeDirection.BottomLeft:
                    return Cursors.SizeNESW;
                case ResizeDirection.Left:
                case ResizeDirection.Right:
                    return Cursors.SizeWE;
                case ResizeDirection.Top:
                case ResizeDirection.Bottom:
                    return Cursors.SizeNS;
                default:
                    return Cursors.Default;
            }
        }

        private void penPicBox_Click(object sender, EventArgs e)
        {
            this.penPicBox.BackColor = Color.AliceBlue;
            this.brushPicBox.BackColor = Color.Transparent;
            brush = false;
        }

        private void brushPicBox_Click(object sender, EventArgs e)
        {
            this.penPicBox.BackColor = Color.Transparent;
            this.brushPicBox.BackColor = Color.AliceBlue;
            brush = true;
        }
    }
}
