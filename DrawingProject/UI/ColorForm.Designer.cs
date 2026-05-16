namespace DrawingProject.UI
{
    partial class ColorForm
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
            this.rgbPanel = new System.Windows.Forms.Panel();
            this.rgbLabel = new System.Windows.Forms.Label();
            this.rgbBox = new System.Windows.Forms.TextBox();
            this.exampleRgb = new System.Windows.Forms.Label();
            this.okBtn = new System.Windows.Forms.Button();
            this.hexPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.hexBox = new System.Windows.Forms.TextBox();
            this.hexLabel = new System.Windows.Forms.Label();
            this.hslPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.hslBox = new System.Windows.Forms.TextBox();
            this.hslLabel = new System.Windows.Forms.Label();
            this.borderCurrColPanel = new System.Windows.Forms.Panel();
            this.currColPanel = new System.Windows.Forms.Panel();
            this.rgbPanel.SuspendLayout();
            this.hexPanel.SuspendLayout();
            this.hslPanel.SuspendLayout();
            this.borderCurrColPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // rgbPanel
            // 
            this.rgbPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.rgbPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rgbPanel.Controls.Add(this.exampleRgb);
            this.rgbPanel.Controls.Add(this.rgbBox);
            this.rgbPanel.Controls.Add(this.rgbLabel);
            this.rgbPanel.Location = new System.Drawing.Point(40, 390);
            this.rgbPanel.Name = "rgbPanel";
            this.rgbPanel.Size = new System.Drawing.Size(271, 106);
            this.rgbPanel.TabIndex = 0;
            // 
            // rgbLabel
            // 
            this.rgbLabel.AutoSize = true;
            this.rgbLabel.Location = new System.Drawing.Point(33, 20);
            this.rgbLabel.Name = "rgbLabel";
            this.rgbLabel.Size = new System.Drawing.Size(97, 16);
            this.rgbLabel.TabIndex = 0;
            this.rgbLabel.Text = "Enter rgb color:";
            // 
            // rgbBox
            // 
            this.rgbBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rgbBox.Location = new System.Drawing.Point(36, 39);
            this.rgbBox.Name = "rgbBox";
            this.rgbBox.Size = new System.Drawing.Size(192, 22);
            this.rgbBox.TabIndex = 1;
            // 
            // exampleRgb
            // 
            this.exampleRgb.AutoSize = true;
            this.exampleRgb.ForeColor = System.Drawing.Color.DarkGray;
            this.exampleRgb.Location = new System.Drawing.Point(34, 70);
            this.exampleRgb.Name = "exampleRgb";
            this.exampleRgb.Size = new System.Drawing.Size(121, 16);
            this.exampleRgb.TabIndex = 2;
            this.exampleRgb.Text = "Example: rgb(0,0,0)";
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(668, 671);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(88, 49);
            this.okBtn.TabIndex = 1;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // hexPanel
            // 
            this.hexPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.hexPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hexPanel.Controls.Add(this.label1);
            this.hexPanel.Controls.Add(this.hexBox);
            this.hexPanel.Controls.Add(this.hexLabel);
            this.hexPanel.Location = new System.Drawing.Point(40, 502);
            this.hexPanel.Name = "hexPanel";
            this.hexPanel.Size = new System.Drawing.Size(271, 106);
            this.hexPanel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(34, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Example: #RRGGBB";
            // 
            // hexBox
            // 
            this.hexBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hexBox.Location = new System.Drawing.Point(36, 39);
            this.hexBox.Name = "hexBox";
            this.hexBox.Size = new System.Drawing.Size(192, 22);
            this.hexBox.TabIndex = 1;
            // 
            // hexLabel
            // 
            this.hexLabel.AutoSize = true;
            this.hexLabel.Location = new System.Drawing.Point(33, 20);
            this.hexLabel.Name = "hexLabel";
            this.hexLabel.Size = new System.Drawing.Size(98, 16);
            this.hexLabel.TabIndex = 0;
            this.hexLabel.Text = "Enter hex color:";
            // 
            // hslPanel
            // 
            this.hslPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.hslPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hslPanel.Controls.Add(this.label2);
            this.hslPanel.Controls.Add(this.hslBox);
            this.hslPanel.Controls.Add(this.hslLabel);
            this.hslPanel.Location = new System.Drawing.Point(40, 614);
            this.hslPanel.Name = "hslPanel";
            this.hslPanel.Size = new System.Drawing.Size(271, 106);
            this.hslPanel.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(34, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Example: hsl(360,100%,100%)";
            // 
            // hslBox
            // 
            this.hslBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hslBox.Location = new System.Drawing.Point(36, 39);
            this.hslBox.Name = "hslBox";
            this.hslBox.Size = new System.Drawing.Size(192, 22);
            this.hslBox.TabIndex = 1;
            // 
            // hslLabel
            // 
            this.hslLabel.AutoSize = true;
            this.hslLabel.Location = new System.Drawing.Point(33, 20);
            this.hslLabel.Name = "hslLabel";
            this.hslLabel.Size = new System.Drawing.Size(94, 16);
            this.hslLabel.TabIndex = 0;
            this.hslLabel.Text = "Enter hsl color:";
            // 
            // borderCurrColPanel
            // 
            this.borderCurrColPanel.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.borderCurrColPanel.Controls.Add(this.currColPanel);
            this.borderCurrColPanel.Location = new System.Drawing.Point(439, 390);
            this.borderCurrColPanel.Name = "borderCurrColPanel";
            this.borderCurrColPanel.Size = new System.Drawing.Size(250, 250);
            this.borderCurrColPanel.TabIndex = 5;
            // 
            // currColPanel
            // 
            this.currColPanel.Location = new System.Drawing.Point(31, 27);
            this.currColPanel.Name = "currColPanel";
            this.currColPanel.Size = new System.Drawing.Size(257, 190);
            this.currColPanel.TabIndex = 0;
            // 
            // ColorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(782, 753);
            this.Controls.Add(this.borderCurrColPanel);
            this.Controls.Add(this.hslPanel);
            this.Controls.Add(this.hexPanel);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.rgbPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "ColorForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ColorForm";
            this.rgbPanel.ResumeLayout(false);
            this.rgbPanel.PerformLayout();
            this.hexPanel.ResumeLayout(false);
            this.hexPanel.PerformLayout();
            this.hslPanel.ResumeLayout(false);
            this.hslPanel.PerformLayout();
            this.borderCurrColPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel rgbPanel;
        private System.Windows.Forms.Label rgbLabel;
        private System.Windows.Forms.TextBox rgbBox;
        private System.Windows.Forms.Label exampleRgb;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Panel hexPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hexBox;
        private System.Windows.Forms.Label hexLabel;
        private System.Windows.Forms.Panel hslPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox hslBox;
        private System.Windows.Forms.Label hslLabel;
        private System.Windows.Forms.Panel borderCurrColPanel;
        private System.Windows.Forms.Panel currColPanel;
    }
}