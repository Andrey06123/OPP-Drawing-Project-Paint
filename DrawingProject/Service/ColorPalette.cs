using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingProject.Service
{
    public static class ColorPalette
    {
        public static Color[] moreColorsPalette = new Color[]
        {
            Color.Black, Color.Maroon, Color.DarkRed, Color.SaddleBrown, Color.Olive, Color.DarkGreen, Color.Teal, Color.DarkCyan,
            Color.Navy, Color.DarkBlue, Color.Indigo, Color.Purple, Color.DarkMagenta, Color.DarkSlateGray, Color.DarkOliveGreen, Color.FromArgb(32,32,32),

            Color.DimGray, Color.Brown, Color.Firebrick, Color.Sienna, Color.OliveDrab, Color.Green, Color.LightSeaGreen, Color.MediumTurquoise,
            Color.MediumBlue, Color.RoyalBlue, Color.MediumSlateBlue, Color.MediumPurple, Color.MediumVioletRed, Color.SlateGray, Color.OliveDrab, Color.FromArgb(64,64,64),

            Color.Gray, Color.IndianRed, Color.Red, Color.Peru, Color.YellowGreen, Color.LimeGreen, Color.Turquoise, Color.Cyan,
            Color.Blue, Color.DodgerBlue, Color.SlateBlue, Color.Orchid, Color.DeepPink, Color.LightSlateGray, Color.YellowGreen, Color.FromArgb(96,96,96),

            Color.DarkGray, Color.LightCoral, Color.OrangeRed, Color.SandyBrown, Color.Khaki, Color.Lime, Color.Aquamarine, Color.PaleTurquoise,
            Color.DeepSkyBlue, Color.SkyBlue, Color.LightSteelBlue, Color.Plum, Color.HotPink, Color.Silver, Color.Khaki, Color.FromArgb(128,128,128),

            Color.Silver, Color.MistyRose, Color.Orange, Color.PeachPuff, Color.LightYellow, Color.LightGreen, Color.LightCyan, Color.Azure,
            Color.LightBlue, Color.LightSkyBlue, Color.PowderBlue, Color.Thistle, Color.Pink, Color.Gainsboro, Color.LightYellow, Color.FromArgb(160,160,160),

            Color.LightGray, Color.LavenderBlush, Color.Gold, Color.Bisque, Color.LemonChiffon, Color.PaleGreen, Color.Honeydew, Color.AliceBlue,
            Color.LightSteelBlue, Color.PowderBlue, Color.AliceBlue, Color.Lavender, Color.LightPink, Color.WhiteSmoke, Color.LemonChiffon, Color.FromArgb(192,192,192),

            Color.Gainsboro, Color.SeaShell, Color.Yellow, Color.Cornsilk, Color.Ivory, Color.MintCream, Color.GhostWhite, Color.FloralWhite,
            Color.AliceBlue, Color.Azure, Color.GhostWhite, Color.FloralWhite, Color.MistyRose, Color.WhiteSmoke, Color.Ivory, Color.FromArgb(224,224,224),

            Color.WhiteSmoke, Color.White, Color.LightYellow, Color.OldLace, Color.Ivory, Color.Honeydew, Color.Azure, Color.White,
            Color.White, Color.White, Color.White, Color.White, Color.White, Color.White, Color.Ivory, Color.White
        };

        public static Color RGBReader(string rgb)
        {
            if (!rgb.Contains("(") || !rgb.Contains(")"))
                throw new ArgumentException("Input must be in the format 'RGB(r, g, b)'");

            string[] parts = rgb.Split('(');
            string[] colorValues = parts[1].TrimEnd(')').Split(',');
            if (colorValues.Length != 3)
                throw new ArgumentException("Input must contain three color values for R, G, B.");
            int r = int.Parse(colorValues[0]);
            int g = int.Parse(colorValues[1]);
            int b = int.Parse(colorValues[2]);

            if (r < 0 || r > 255 || g < 0 || g > 255 || b < 0 || b > 255)
                throw new ArgumentException("RGB values must be between 0 and 255.");

            Color color = Color.FromArgb(r, g, b);

            return color;
        }

        public static Color HEXReader(string colorName)
        {
            if (!colorName.Contains("#") || colorName.Length != 7)
                throw new ArgumentException("Input must be in the format '#RRGGBB'");

            return ColorTranslator.FromHtml(colorName);
        }

        public static Color HSLReader(string colorName)
        {
            if (!colorName.Contains("(") || !colorName.Contains(")"))
                throw new ArgumentException("Input must be in the format 'HSL(h, s, l)'");

            string[] parts = colorName.Split('(');
            string[] colors = parts[1].TrimEnd(')').Split(',');

            if (colors.Length != 3)
                throw new ArgumentException("Input must contain three color values for H, S, L.");

            double h = int.Parse(colors[0]);
            double s = int.Parse(colors[1]);
            double l = int.Parse(colors[2]);

            if(h < 0 || h > 360 || s < 0 || s > 100 || l < 0 || l> 100 )
                throw new ArgumentException("HSL values must be within the valid range: H (0-360), S (0-100), L (0-100)");

            h /= 360.0;
            s /= 100.0;
            l /= 100.0;

            double r, g, b;

            if (s == 0)
            {
                r = g = b = l;
            }
            else
            {
                double q = l < 0.5
                    ? l * (1 + s)
                    : l + s - l * s;

                double p = 2 * l - q;

                r = HueToRGB(p, q, h + 1.0 / 3);
                g = HueToRGB(p, q, h);
                b = HueToRGB(p, q, h - 1.0 / 3);
            }

            return Color.FromArgb(
                (int)(r * 255),
                (int)(g * 255),
                (int)(b * 255));
        }
        static double HueToRGB(double p, double q, double t)
        {
            if (t < 0) t += 1;
            if (t > 1) t -= 1;

            if (t < 1.0 / 6)
                return p + (q - p) * 6 * t;

            if (t < 1.0 / 2)
                return q;

            if (t < 2.0 / 3)
                return p + (q - p) * (2.0 / 3 - t) * 6;

            return p;
        }
    }
}
