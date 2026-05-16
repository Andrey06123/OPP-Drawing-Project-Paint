namespace DrawingProject.UI
{
    partial class Scene
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scene));
            this.shapesPanel = new System.Windows.Forms.Panel();
            this.polygonPanel = new System.Windows.Forms.Panel();
            this.polygonPicBox = new System.Windows.Forms.PictureBox();
            this.circlePanel = new System.Windows.Forms.Panel();
            this.circlePicBox = new System.Windows.Forms.PictureBox();
            this.rectPanel = new System.Windows.Forms.Panel();
            this.rectPicBox = new System.Windows.Forms.PictureBox();
            this.triangPanel = new System.Windows.Forms.Panel();
            this.trianglePicBox = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.отвориToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запазиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запазиКатоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoBtn = new System.Windows.Forms.ToolStripButton();
            this.redoBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.selectPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorMainPanel = new System.Windows.Forms.Panel();
            this.palette = new System.Windows.Forms.FlowLayoutPanel();
            this.borderCurrColPanel = new System.Windows.Forms.Panel();
            this.currentColorPanel = new System.Windows.Forms.Panel();
            this.moreColorsBtn = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.toolPanel = new System.Windows.Forms.Panel();
            this.thicknessTextBox = new System.Windows.Forms.TextBox();
            this.thicLabel = new System.Windows.Forms.Label();
            this.brushPanel = new System.Windows.Forms.Panel();
            this.brushPicBox = new System.Windows.Forms.PictureBox();
            this.penPanel = new System.Windows.Forms.Panel();
            this.penPicBox = new System.Windows.Forms.PictureBox();
            this.DrawingPicBox = new System.Windows.Forms.PictureBox();
            this.shapesPanel.SuspendLayout();
            this.polygonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.polygonPicBox)).BeginInit();
            this.circlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circlePicBox)).BeginInit();
            this.rectPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rectPicBox)).BeginInit();
            this.triangPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trianglePicBox)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.selectPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.colorMainPanel.SuspendLayout();
            this.borderCurrColPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.toolPanel.SuspendLayout();
            this.brushPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.brushPicBox)).BeginInit();
            this.penPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.penPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrawingPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // shapesPanel
            // 
            this.shapesPanel.BackColor = System.Drawing.Color.SeaShell;
            this.shapesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.shapesPanel.Controls.Add(this.polygonPanel);
            this.shapesPanel.Controls.Add(this.circlePanel);
            this.shapesPanel.Controls.Add(this.rectPanel);
            this.shapesPanel.Controls.Add(this.triangPanel);
            this.shapesPanel.Location = new System.Drawing.Point(105, 0);
            this.shapesPanel.Margin = new System.Windows.Forms.Padding(0);
            this.shapesPanel.Name = "shapesPanel";
            this.shapesPanel.Size = new System.Drawing.Size(487, 147);
            this.shapesPanel.TabIndex = 5;
            // 
            // polygonPanel
            // 
            this.polygonPanel.BackColor = System.Drawing.Color.SeaShell;
            this.polygonPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.polygonPanel.Controls.Add(this.polygonPicBox);
            this.polygonPanel.Location = new System.Drawing.Point(339, 23);
            this.polygonPanel.Name = "polygonPanel";
            this.polygonPanel.Size = new System.Drawing.Size(92, 88);
            this.polygonPanel.TabIndex = 4;
            // 
            // polygonPicBox
            // 
            this.polygonPicBox.BackColor = System.Drawing.Color.Transparent;
            this.polygonPicBox.Image = global::DrawingProject.Properties.Resources.polygon;
            this.polygonPicBox.ImageLocation = "";
            this.polygonPicBox.Location = new System.Drawing.Point(10, 10);
            this.polygonPicBox.Name = "polygonPicBox";
            this.polygonPicBox.Size = new System.Drawing.Size(72, 68);
            this.polygonPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.polygonPicBox.TabIndex = 0;
            this.polygonPicBox.TabStop = false;
            this.polygonPicBox.Click += new System.EventHandler(this.polygonPicBox_Click);
            // 
            // circlePanel
            // 
            this.circlePanel.BackColor = System.Drawing.Color.SeaShell;
            this.circlePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.circlePanel.Controls.Add(this.circlePicBox);
            this.circlePanel.Location = new System.Drawing.Point(241, 23);
            this.circlePanel.Name = "circlePanel";
            this.circlePanel.Size = new System.Drawing.Size(92, 88);
            this.circlePanel.TabIndex = 3;
            // 
            // circlePicBox
            // 
            this.circlePicBox.BackColor = System.Drawing.Color.Transparent;
            this.circlePicBox.Image = global::DrawingProject.Properties.Resources.dry_clean;
            this.circlePicBox.ImageLocation = "";
            this.circlePicBox.Location = new System.Drawing.Point(10, 10);
            this.circlePicBox.Name = "circlePicBox";
            this.circlePicBox.Size = new System.Drawing.Size(72, 68);
            this.circlePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.circlePicBox.TabIndex = 0;
            this.circlePicBox.TabStop = false;
            this.circlePicBox.Click += new System.EventHandler(this.circlePicBox_Click);
            this.circlePicBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.circlePicBox_MouseClick);
            // 
            // rectPanel
            // 
            this.rectPanel.BackColor = System.Drawing.Color.SeaShell;
            this.rectPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rectPanel.Controls.Add(this.rectPicBox);
            this.rectPanel.Location = new System.Drawing.Point(109, 23);
            this.rectPanel.Name = "rectPanel";
            this.rectPanel.Size = new System.Drawing.Size(126, 88);
            this.rectPanel.TabIndex = 2;
            // 
            // rectPicBox
            // 
            this.rectPicBox.BackColor = System.Drawing.Color.Transparent;
            this.rectPicBox.ErrorImage = global::DrawingProject.Properties.Resources.rectangle1;
            this.rectPicBox.Image = global::DrawingProject.Properties.Resources.rectangle1;
            this.rectPicBox.ImageLocation = "";
            this.rectPicBox.InitialImage = global::DrawingProject.Properties.Resources.rectangle__1_;
            this.rectPicBox.Location = new System.Drawing.Point(10, 10);
            this.rectPicBox.Name = "rectPicBox";
            this.rectPicBox.Size = new System.Drawing.Size(106, 68);
            this.rectPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rectPicBox.TabIndex = 0;
            this.rectPicBox.TabStop = false;
            this.rectPicBox.Click += new System.EventHandler(this.rectPicBox_Click);
            // 
            // triangPanel
            // 
            this.triangPanel.BackColor = System.Drawing.Color.SeaShell;
            this.triangPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.triangPanel.Controls.Add(this.trianglePicBox);
            this.triangPanel.Location = new System.Drawing.Point(15, 23);
            this.triangPanel.Name = "triangPanel";
            this.triangPanel.Size = new System.Drawing.Size(88, 88);
            this.triangPanel.TabIndex = 1;
            // 
            // trianglePicBox
            // 
            this.trianglePicBox.BackColor = System.Drawing.Color.Transparent;
            this.trianglePicBox.ErrorImage = global::DrawingProject.Properties.Resources.triangle;
            this.trianglePicBox.Image = global::DrawingProject.Properties.Resources.triangle;
            this.trianglePicBox.ImageLocation = "";
            this.trianglePicBox.InitialImage = global::DrawingProject.Properties.Resources.triangle;
            this.trianglePicBox.Location = new System.Drawing.Point(7, 7);
            this.trianglePicBox.Name = "trianglePicBox";
            this.trianglePicBox.Size = new System.Drawing.Size(71, 74);
            this.trianglePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.trianglePicBox.TabIndex = 0;
            this.trianglePicBox.TabStop = false;
            this.trianglePicBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.trianglePicBox_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.undoBtn,
            this.redoBtn,
            this.toolStripSeparator1,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1468, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отвориToolStripMenuItem,
            this.запазиToolStripMenuItem,
            this.запазиКатоToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(59, 24);
            this.toolStripDropDownButton1.Text = "Файл";
            // 
            // отвориToolStripMenuItem
            // 
            this.отвориToolStripMenuItem.Name = "отвориToolStripMenuItem";
            this.отвориToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.отвориToolStripMenuItem.Text = "Отвори";
            this.отвориToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // запазиToolStripMenuItem
            // 
            this.запазиToolStripMenuItem.Name = "запазиToolStripMenuItem";
            this.запазиToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.запазиToolStripMenuItem.Text = "Запази";
            this.запазиToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // запазиКатоToolStripMenuItem
            // 
            this.запазиКатоToolStripMenuItem.Name = "запазиКатоToolStripMenuItem";
            this.запазиКатоToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.запазиКатоToolStripMenuItem.Text = "Запази като..";
            this.запазиКатоToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // undoBtn
            // 
            this.undoBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.undoBtn.Image = ((System.Drawing.Image)(resources.GetObject("undoBtn.Image")));
            this.undoBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.undoBtn.Name = "undoBtn";
            this.undoBtn.Size = new System.Drawing.Size(49, 24);
            this.undoBtn.Text = "Undo";
            this.undoBtn.Click += new System.EventHandler(this.undoBtn_Click);
            // 
            // redoBtn
            // 
            this.redoBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.redoBtn.Image = ((System.Drawing.Image)(resources.GetObject("redoBtn.Image")));
            this.redoBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.redoBtn.Name = "redoBtn";
            this.redoBtn.Size = new System.Drawing.Size(48, 24);
            this.redoBtn.Text = "Redo";
            this.redoBtn.Click += new System.EventHandler(this.redoBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(73, 24);
            this.toolStripLabel1.Text = "File name";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // selectPanel
            // 
            this.selectPanel.BackColor = System.Drawing.Color.SeaShell;
            this.selectPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectPanel.Controls.Add(this.pictureBox1);
            this.selectPanel.Location = new System.Drawing.Point(0, 0);
            this.selectPanel.Margin = new System.Windows.Forms.Padding(0);
            this.selectPanel.Name = "selectPanel";
            this.selectPanel.Size = new System.Drawing.Size(105, 147);
            this.selectPanel.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DrawingProject.Properties.Resources.select;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(10, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick_1);
            // 
            // colorMainPanel
            // 
            this.colorMainPanel.BackColor = System.Drawing.Color.SeaShell;
            this.colorMainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorMainPanel.Controls.Add(this.palette);
            this.colorMainPanel.Controls.Add(this.borderCurrColPanel);
            this.colorMainPanel.Controls.Add(this.moreColorsBtn);
            this.colorMainPanel.Location = new System.Drawing.Point(592, 0);
            this.colorMainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.colorMainPanel.Name = "colorMainPanel";
            this.colorMainPanel.Size = new System.Drawing.Size(447, 147);
            this.colorMainPanel.TabIndex = 7;
            // 
            // palette
            // 
            this.palette.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.palette.Location = new System.Drawing.Point(10, 10);
            this.palette.Name = "palette";
            this.palette.Size = new System.Drawing.Size(220, 127);
            this.palette.TabIndex = 0;
            // 
            // borderCurrColPanel
            // 
            this.borderCurrColPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.borderCurrColPanel.Controls.Add(this.currentColorPanel);
            this.borderCurrColPanel.Location = new System.Drawing.Point(273, 25);
            this.borderCurrColPanel.Name = "borderCurrColPanel";
            this.borderCurrColPanel.Size = new System.Drawing.Size(89, 95);
            this.borderCurrColPanel.TabIndex = 2;
            // 
            // currentColorPanel
            // 
            this.currentColorPanel.Location = new System.Drawing.Point(6, 10);
            this.currentColorPanel.Name = "currentColorPanel";
            this.currentColorPanel.Size = new System.Drawing.Size(80, 80);
            this.currentColorPanel.TabIndex = 1;
            // 
            // moreColorsBtn
            // 
            this.moreColorsBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.moreColorsBtn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.moreColorsBtn.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moreColorsBtn.Location = new System.Drawing.Point(268, 107);
            this.moreColorsBtn.Name = "moreColorsBtn";
            this.moreColorsBtn.Size = new System.Drawing.Size(94, 30);
            this.moreColorsBtn.TabIndex = 8;
            this.moreColorsBtn.Text = "More colors";
            this.moreColorsBtn.UseVisualStyleBackColor = false;
            this.moreColorsBtn.Click += new System.EventHandler(this.moreColorsBtn_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Controls.Add(this.selectPanel);
            this.mainPanel.Controls.Add(this.shapesPanel);
            this.mainPanel.Controls.Add(this.colorMainPanel);
            this.mainPanel.Controls.Add(this.toolPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainPanel.Location = new System.Drawing.Point(0, 27);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1468, 155);
            this.mainPanel.TabIndex = 8;
            // 
            // toolPanel
            // 
            this.toolPanel.BackColor = System.Drawing.Color.SeaShell;
            this.toolPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolPanel.Controls.Add(this.thicknessTextBox);
            this.toolPanel.Controls.Add(this.thicLabel);
            this.toolPanel.Controls.Add(this.brushPanel);
            this.toolPanel.Controls.Add(this.penPanel);
            this.toolPanel.Location = new System.Drawing.Point(1039, 0);
            this.toolPanel.Margin = new System.Windows.Forms.Padding(0);
            this.toolPanel.Name = "toolPanel";
            this.toolPanel.Size = new System.Drawing.Size(375, 138);
            this.toolPanel.TabIndex = 9;
            // 
            // thicknessTextBox
            // 
            this.thicknessTextBox.Location = new System.Drawing.Point(266, 58);
            this.thicknessTextBox.Name = "thicknessTextBox";
            this.thicknessTextBox.Size = new System.Drawing.Size(51, 22);
            this.thicknessTextBox.TabIndex = 7;
            // 
            // thicLabel
            // 
            this.thicLabel.AutoSize = true;
            this.thicLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thicLabel.Location = new System.Drawing.Point(247, 35);
            this.thicLabel.Name = "thicLabel";
            this.thicLabel.Size = new System.Drawing.Size(90, 20);
            this.thicLabel.TabIndex = 6;
            this.thicLabel.Text = "Thickness:";
            // 
            // brushPanel
            // 
            this.brushPanel.BackColor = System.Drawing.Color.SeaShell;
            this.brushPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.brushPanel.Controls.Add(this.brushPicBox);
            this.brushPanel.Location = new System.Drawing.Point(139, 23);
            this.brushPanel.Name = "brushPanel";
            this.brushPanel.Size = new System.Drawing.Size(92, 88);
            this.brushPanel.TabIndex = 5;
            // 
            // brushPicBox
            // 
            this.brushPicBox.BackColor = System.Drawing.Color.Transparent;
            this.brushPicBox.Image = global::DrawingProject.Properties.Resources.paintbrush;
            this.brushPicBox.ImageLocation = "";
            this.brushPicBox.Location = new System.Drawing.Point(10, 10);
            this.brushPicBox.Name = "brushPicBox";
            this.brushPicBox.Size = new System.Drawing.Size(72, 68);
            this.brushPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.brushPicBox.TabIndex = 0;
            this.brushPicBox.TabStop = false;
            this.brushPicBox.Click += new System.EventHandler(this.brushPicBox_Click);
            // 
            // penPanel
            // 
            this.penPanel.BackColor = System.Drawing.Color.SeaShell;
            this.penPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.penPanel.Controls.Add(this.penPicBox);
            this.penPanel.Location = new System.Drawing.Point(29, 23);
            this.penPanel.Name = "penPanel";
            this.penPanel.Size = new System.Drawing.Size(92, 88);
            this.penPanel.TabIndex = 5;
            // 
            // penPicBox
            // 
            this.penPicBox.BackColor = System.Drawing.Color.Transparent;
            this.penPicBox.Image = global::DrawingProject.Properties.Resources.pen;
            this.penPicBox.ImageLocation = "";
            this.penPicBox.Location = new System.Drawing.Point(10, 10);
            this.penPicBox.Name = "penPicBox";
            this.penPicBox.Size = new System.Drawing.Size(72, 68);
            this.penPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.penPicBox.TabIndex = 0;
            this.penPicBox.TabStop = false;
            this.penPicBox.Click += new System.EventHandler(this.penPicBox_Click);
            // 
            // DrawingPicBox
            // 
            this.DrawingPicBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DrawingPicBox.Location = new System.Drawing.Point(0, 0);
            this.DrawingPicBox.Name = "DrawingPicBox";
            this.DrawingPicBox.Size = new System.Drawing.Size(1468, 601);
            this.DrawingPicBox.TabIndex = 2;
            this.DrawingPicBox.TabStop = false;
            this.DrawingPicBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Scene_MouseDown);
            this.DrawingPicBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Scene_MouseMove);
            this.DrawingPicBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Scene_MouseUp);
            // 
            // Scene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1468, 601);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.DrawingPicBox);
            this.Name = "Scene";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Scene_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Scene_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Scene_MouseUp);
            this.shapesPanel.ResumeLayout(false);
            this.polygonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.polygonPicBox)).EndInit();
            this.circlePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.circlePicBox)).EndInit();
            this.rectPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rectPicBox)).EndInit();
            this.triangPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trianglePicBox)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.selectPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.colorMainPanel.ResumeLayout(false);
            this.borderCurrColPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.toolPanel.ResumeLayout(false);
            this.toolPanel.PerformLayout();
            this.brushPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.brushPicBox)).EndInit();
            this.penPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.penPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DrawingPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox trianglePicBox;
        private System.Windows.Forms.PictureBox rectPicBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem отвориToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запазиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запазиКатоToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.PictureBox DrawingPicBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripButton undoBtn;
        private System.Windows.Forms.ToolStripButton redoBtn;
        private System.Windows.Forms.Panel shapesPanel;
        private System.Windows.Forms.Panel selectPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel triangPanel;
        private System.Windows.Forms.Panel rectPanel;
        private System.Windows.Forms.PictureBox circlePicBox;
        private System.Windows.Forms.Panel circlePanel;
        private System.Windows.Forms.Panel colorMainPanel;
        private System.Windows.Forms.FlowLayoutPanel palette;
        private System.Windows.Forms.Panel currentColorPanel;
        private System.Windows.Forms.Panel borderCurrColPanel;
        private System.Windows.Forms.Button moreColorsBtn;
        private System.Windows.Forms.FlowLayoutPanel mainPanel;
        private System.Windows.Forms.Panel polygonPanel;
        private System.Windows.Forms.PictureBox polygonPicBox;
        private System.Windows.Forms.Panel toolPanel;
        private System.Windows.Forms.Panel brushPanel;
        private System.Windows.Forms.PictureBox brushPicBox;
        private System.Windows.Forms.Panel penPanel;
        private System.Windows.Forms.PictureBox penPicBox;
        private System.Windows.Forms.Label thicLabel;
        private System.Windows.Forms.TextBox thicknessTextBox;
    }
}

