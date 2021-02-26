using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColorModels
{
    class ColorConverter
    {
        /**
         * sRGB to XYZ conversion matrix
         */
        public double[,] M;

        /**
         * XYZ to sRGB conversion matrix
         */
        public double[,] Mi;

        public ColorConverter()
        {
            M = new double[,] {{0.4124, 0.3576,  0.1805},
                             {0.2126, 0.7152,  0.0722},
                             {0.0193, 0.1192,  0.9505}};

            Mi = new double[,] {{ 3.2406, -1.5372, -0.4986},
                             {-0.9689,  1.8758,  0.0415},
                             { 0.0557, -0.2040,  1.0570}};
        }

        public double[] RGBtoXYZ(int R, int G, int B)
        {
            double[] result = new double[3];

            // convert 0..255 into 0..1
            double r = R / 255.0;
            double g = G / 255.0;
            double b = B / 255.0;

            // assume sRGB
            if (r <= 0.04045)
            {
                r = r / 12.92;
            }
            else
            {
                r = Math.Pow(((r + 0.055) / 1.055), 2.4);
            }
            if (g <= 0.04045)
            {
                g = g / 12.92;
            }
            else
            {
                g = Math.Pow(((g + 0.055) / 1.055), 2.4);
            }
            if (b <= 0.04045)
            {
                b = b / 12.92;
            }
            else
            {
                b = Math.Pow(((b + 0.055) / 1.055), 2.4);
            }

            r *= 100.0;
            g *= 100.0;
            b *= 100.0;

            // [X Y Z] = [r g b][M]
            result[0] = (r * M[0,0]) + (g * M[0,1]) + (b * M[0,2]);
            result[1] = (r * M[1,0]) + (g * M[1,1]) + (b * M[1,2]);
            result[2] = (r * M[2,0]) + (g * M[2,1]) + (b * M[2,2]);

            return result;
        }

        /**
         * Convert RGB to XYZ
         * @param RGB
         * @return XYZ in double array.
         */
        public double[] RGBtoXYZ(int[] RGB)
        {
            return RGBtoXYZ(RGB[0], RGB[1], RGB[2]);
        }

        /**
         * Convert XYZ to RGB.
         * @param X
         * @param Y
         * @param Z
         * @return RGB in int array.
         */
        public int[] XYZtoRGB(double X, double Y, double Z)
        {
            int[] result = new int[3];

            double x = X / 100.0;
            double y = Y / 100.0;
            double z = Z / 100.0;

            // [r g b] = [X Y Z][Mi]
            double r = (x * Mi[0,0]) + (y * Mi[0,1]) + (z * Mi[0,2]);
            double g = (x * Mi[1,0]) + (y * Mi[1,1]) + (z * Mi[1,2]);
            double b = (x * Mi[2,0]) + (y * Mi[2,1]) + (z * Mi[2,2]);

            // assume sRGB
            if (r > 0.0031308)
            {
                r = ((1.055 * Math.Pow(r, 1.0 / 2.4)) - 0.055);
            }
            else
            {
                r = (r * 12.92);
            }
            if (g > 0.0031308)
            {
                g = ((1.055 * Math.Pow(g, 1.0 / 2.4)) - 0.055);
            }
            else
            {
                g = (g * 12.92);
            }
            if (b > 0.0031308)
            {
                b = ((1.055 * Math.Pow(b, 1.0 / 2.4)) - 0.055);
            }
            else
            {
                b = (b * 12.92);
            }

            r = (r < 0) ? 0 : r;
            g = (g < 0) ? 0 : g;
            b = (b < 0) ? 0 : b;

            // convert 0..1 into 0..255
            result[0] = (int)Math.Round(r * 255);
            result[1] = (int)Math.Round(g * 255);
            result[2] = (int)Math.Round(b * 255);

            return result;
        }

        /**
         * Convert XYZ to RGB
         * @param XYZ in a double array.
         * @return RGB in int array.
         */
        public int[] XYZtoRGB(double[] XYZ)
        {
            return XYZtoRGB(XYZ[0], XYZ[1], XYZ[2]);
        }


    }
}
