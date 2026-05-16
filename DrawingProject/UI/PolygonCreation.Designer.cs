namespace DrawingProject.UI
{
    partial class PolygonCreation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PolygonCreation));
            this.polygonMenuPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.polygonPanel = new System.Windows.Forms.Panel();
            this.squarePicBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pentagonPicBox = new System.Windows.Forms.PictureBox();
            this.polygonPreviewPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.hexagonPicBox = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.heptagonPicBox = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.octagonPicBox = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.polygonMenuPanel.SuspendLayout();
            this.polygonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.squarePicBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pentagonPicBox)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hexagonPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heptagonPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.octagonPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // polygonMenuPanel
            // 
            this.polygonMenuPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.polygonMenuPanel.Controls.Add(this.polygonPanel);
            this.polygonMenuPanel.Controls.Add(this.panel1);
            this.polygonMenuPanel.Controls.Add(this.panel3);
            this.polygonMenuPanel.Controls.Add(this.panel5);
            this.polygonMenuPanel.Controls.Add(this.panel7);
            this.polygonMenuPanel.Location = new System.Drawing.Point(744, 166);
            this.polygonMenuPanel.Name = "polygonMenuPanel";
            this.polygonMenuPanel.Size = new System.Drawing.Size(248, 399);
            this.polygonMenuPanel.TabIndex = 1;
            // 
            // polygonPanel
            // 
            this.polygonPanel.BackColor = System.Drawing.Color.SeaShell;
            this.polygonPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.polygonPanel.Controls.Add(this.squarePicBox);
            this.polygonPanel.Location = new System.Drawing.Point(3, 3);
            this.polygonPanel.Name = "polygonPanel";
            this.polygonPanel.Size = new System.Drawing.Size(92, 88);
            this.polygonPanel.TabIndex = 5;
            // 
            // squarePicBox
            // 
            this.squarePicBox.BackColor = System.Drawing.Color.Transparent;
            this.squarePicBox.Image = global::DrawingProject.Properties.Resources.square;
            this.squarePicBox.ImageLocation = "";
            this.squarePicBox.Location = new System.Drawing.Point(10, 10);
            this.squarePicBox.Name = "squarePicBox";
            this.squarePicBox.Size = new System.Drawing.Size(72, 68);
            this.squarePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.squarePicBox.TabIndex = 0;
            this.squarePicBox.TabStop = false;
            this.squarePicBox.Click += new System.EventHandler(this.squarePicBox_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaShell;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pentagonPicBox);
            this.panel1.Location = new System.Drawing.Point(101, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(92, 88);
            this.panel1.TabIndex = 6;
            // 
            // pentagonPicBox
            // 
            this.pentagonPicBox.BackColor = System.Drawing.Color.Transparent;
            this.pentagonPicBox.Image = global::DrawingProject.Properties.Resources.pentagon_outline_shape;
            this.pentagonPicBox.ImageLocation = "";
            this.pentagonPicBox.Location = new System.Drawing.Point(10, 10);
            this.pentagonPicBox.Name = "pentagonPicBox";
            this.pentagonPicBox.Size = new System.Drawing.Size(72, 68);
            this.pentagonPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pentagonPicBox.TabIndex = 0;
            this.pentagonPicBox.TabStop = false;
            this.pentagonPicBox.Click += new System.EventHandler(this.pentagonPicBox_Click);
            // 
            // polygonPreviewPanel
            // 
            this.polygonPreviewPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.polygonPreviewPanel.Location = new System.Drawing.Point(89, 188);
            this.polygonPreviewPanel.Name = "polygonPreviewPanel";
            this.polygonPreviewPanel.Size = new System.Drawing.Size(543, 342);
            this.polygonPreviewPanel.TabIndex = 2;
            this.polygonPreviewPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.polygonPreviewPanel_MouseDown);
            this.polygonPreviewPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.polygonPreviewPanel_MouseMove);
            this.polygonPreviewPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.polygonPreviewPanel_MouseUp);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(866, 611);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 49);
            this.button1.TabIndex = 3;
            this.button1.Text = "ОК";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SeaShell;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Location = new System.Drawing.Point(3, 97);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(92, 88);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SeaShell;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.hexagonPicBox);
            this.panel4.Location = new System.Drawing.Point(-1, -1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(92, 88);
            this.panel4.TabIndex = 7;
            // 
            // hexagonPicBox
            // 
            this.hexagonPicBox.BackColor = System.Drawing.Color.Transparent;
            this.hexagonPicBox.Image = ((System.Drawing.Image)(resources.GetObject("hexagonPicBox.Image")));
            this.hexagonPicBox.ImageLocation = "";
            this.hexagonPicBox.Location = new System.Drawing.Point(10, 10);
            this.hexagonPicBox.Name = "hexagonPicBox";
            this.hexagonPicBox.Size = new System.Drawing.Size(72, 68);
            this.hexagonPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hexagonPicBox.TabIndex = 0;
            this.hexagonPicBox.TabStop = false;
            this.hexagonPicBox.Click += new System.EventHandler(this.hexagonPicBox_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::DrawingProject.Properties.Resources.pentagon_outline_shape;
            this.pictureBox3.ImageLocation = "";
            this.pictureBox3.Location = new System.Drawing.Point(10, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(72, 68);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SeaShell;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.pictureBox4);
            this.panel5.Location = new System.Drawing.Point(101, 97);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(92, 88);
            this.panel5.TabIndex = 9;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.SeaShell;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.heptagonPicBox);
            this.panel6.Location = new System.Drawing.Point(-1, -1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(92, 88);
            this.panel6.TabIndex = 7;
            // 
            // heptagonPicBox
            // 
            this.heptagonPicBox.BackColor = System.Drawing.Color.Transparent;
            this.heptagonPicBox.Image = ((System.Drawing.Image)(resources.GetObject("heptagonPicBox.Image")));
            this.heptagonPicBox.ImageLocation = "";
            this.heptagonPicBox.Location = new System.Drawing.Point(10, 10);
            this.heptagonPicBox.Name = "heptagonPicBox";
            this.heptagonPicBox.Size = new System.Drawing.Size(72, 68);
            this.heptagonPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.heptagonPicBox.TabIndex = 0;
            this.heptagonPicBox.TabStop = false;
            this.heptagonPicBox.Click += new System.EventHandler(this.heptagonPicBox_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::DrawingProject.Properties.Resources.pentagon_outline_shape;
            this.pictureBox4.ImageLocation = "";
            this.pictureBox4.Location = new System.Drawing.Point(10, 10);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(72, 68);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.SeaShell;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.pictureBox5);
            this.panel7.Location = new System.Drawing.Point(3, 191);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(92, 88);
            this.panel7.TabIndex = 10;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.SeaShell;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.octagonPicBox);
            this.panel8.Location = new System.Drawing.Point(-1, -1);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(92, 88);
            this.panel8.TabIndex = 7;
            // 
            // octagonPicBox
            // 
            this.octagonPicBox.BackColor = System.Drawing.Color.Transparent;
            this.octagonPicBox.Image = ((System.Drawing.Image)(resources.GetObject("octagonPicBox.Image")));
            this.octagonPicBox.ImageLocation = "";
            this.octagonPicBox.Location = new System.Drawing.Point(10, 10);
            this.octagonPicBox.Name = "octagonPicBox";
            this.octagonPicBox.Size = new System.Drawing.Size(72, 68);
            this.octagonPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.octagonPicBox.TabIndex = 0;
            this.octagonPicBox.TabStop = false;
            this.octagonPicBox.Click += new System.EventHandler(this.octagonPicBox_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::DrawingProject.Properties.Resources.pentagon_outline_shape;
            this.pictureBox5.ImageLocation = "";
            this.pictureBox5.Location = new System.Drawing.Point(10, 10);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(72, 68);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // PolygonCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.polygonPreviewPanel);
            this.Controls.Add(this.polygonMenuPanel);
            this.Name = "PolygonCreation";
            this.Text = "PolygonCreation";
            this.Load += new System.EventHandler(this.PolygonCreation_Load);
            this.polygonMenuPanel.ResumeLayout(false);
            this.polygonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.squarePicBox)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pentagonPicBox)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hexagonPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.heptagonPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.octagonPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel polygonMenuPanel;
        private System.Windows.Forms.Panel polygonPreviewPanel;
        private System.Windows.Forms.Panel polygonPanel;
        private System.Windows.Forms.PictureBox squarePicBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pentagonPicBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox hexagonPicBox;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox heptagonPicBox;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox octagonPicBox;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}