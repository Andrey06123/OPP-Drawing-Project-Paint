using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrawingProject.Models;
using DrawingProject.Commands;
using DrawingProject.Service;

namespace DrawingProject.UI
{
    public partial class ColorForm : Form
    {
        private Color color;
        private int borderSize = 30;
        public ColorForm()
        {
            InitializeComponent();
            this.ClientSize = new Size(600,600);
            this.Padding = new Padding((this.ClientSize.Width / 2)/10);
            this.okBtn.Location = new Point(this.ClientSize.Width - this.okBtn.Width - this.Padding.Right, this.ClientSize.Height - this.okBtn.Height - this.Padding.Bottom);

            this.KeyPreview = true;
            this.KeyDown += ColorForm_KeyDown;

            
            this.Load += colorPaletteCreation;
        }
        public Color GetColor()
        {
            return this.color;
        }
        private void colorPaletteCreation(object sender, EventArgs e)
        {
            FlowLayoutPanel palette = new FlowLayoutPanel();
            int halfWidth = this.ClientSize.Width / 2;
            palette.Size = new Size(halfWidth + halfWidth / 2 + halfWidth /3 , this.ClientSize.Width);
            palette.Location = new Point(halfWidth / 10, halfWidth / 10);

            


            foreach (Color color in Service.ColorPalette.moreColorsPalette)
            {
                Panel colorPanel = new Panel();
                colorPanel.BackColor = color;
                colorPanel.Size = new Size(palette.Width /16, palette.Width / 16);
                colorPanel.Click += colorPanel_Click;
                colorPanel.Padding = new Padding(0);
                colorPanel.Margin = new Padding(0); 
                palette.Controls.Add(colorPanel);
            }
            borderCurrColPanel.Size = new Size(200,200);

            currColPanel.Location = new Point(borderSize/2 , borderSize/2);
            currColPanel.Size = new Size(borderCurrColPanel.Width - borderSize, borderCurrColPanel.Height - borderSize);

            this.Controls.Add(palette);
        }
        private void colorPanel_Click(object sender, EventArgs e)
        {
            Panel clickedPanel = sender as Panel;
            if (clickedPanel != null)
            {
                this.color = clickedPanel.BackColor;
                currColPanel.BackColor = this.color;
            }
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void ColorForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                KeyEnter_Click(sender, e);
                e.Handled = true; 
            }
        }

        private void KeyEnter_Click(object sender, EventArgs e) 
        {
            if ((!string.IsNullOrEmpty(rgbBox.Text) && !string.IsNullOrEmpty(hexBox.Text)) ||
                (!string.IsNullOrEmpty(rgbBox.Text) && !string.IsNullOrEmpty(hslBox.Text)) ||
                (!string.IsNullOrEmpty(hslBox.Text) && !string.IsNullOrEmpty(hexBox.Text)))
            {
                MessageBox.Show("You must enter only one of those color types and press Enter.");
                rgbBox.Text = string.Empty;
                hexBox.Text = string.Empty;
                hslBox.Text = string.Empty;
            }

            if (!string.IsNullOrEmpty(rgbBox.Text)) { 
                this.color = Service.ColorPalette.RGBReader(rgbBox.Text);
                currColPanel.BackColor = this.color;
                rgbBox.Text = "";
                return;
            }

            if(!string.IsNullOrEmpty(hexBox.Text))
            {
                this.color = Service.ColorPalette.HEXReader(hexBox.Text);
                currColPanel.BackColor = this.color;
                hexBox.Text = "";
                return;
            }

            if (!string.IsNullOrEmpty(hslBox.Text))
            {
                this.color = Service.ColorPalette.HSLReader(hslBox.Text);
                currColPanel.BackColor = this.color;
                hslBox.Text = "";
                return;
            }
        }
    }
}
