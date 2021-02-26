using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ColorModels
{
    public partial class RGBCubeControl : Panel
    {
        byte[] RGB = new byte[3];
        bool showModel;
        int alpha;                     // angel at which R axis is set // 0-90
        int size;

        int shortCathetus;
        int longCathetus;

        Point TopFarLeft;
        Point TopFarRight;
        Point TopCloseLeft;
        Point TopCloseRight;
        Point BottomFarLeft;
        Point BottomFarRight;
        Point BottomCloseLeft;
        Point BottomCloseRight;

        protected int findShortCathetus(int alpha, int size)
        {
            //return size / 2;
            return (int)Math.Round(Math.Sin(90+alpha) * size);

        }
        protected int findLongCathetus(int alpha, int size)
        {
            //return (int)Math.Round(size * Math.Sqrt(3) / 2);
            return (int)Math.Round(Math.Cos(alpha) * size); // i think if we won't round it casting to int will only cut off the decimal part
        }

        // since we draw in 2D red coordinant have to be transposed to green and blue
        protected int[] RtoGB(int[] RGB)
        {
            int[] GB = new int[2];
            GB[0] = shortCathetus + RGB[1] - findShortCathetus(alpha, RGB[0]);
            GB[1] = RGB[2] + findLongCathetus(alpha, RGB[0]);
            return GB;
        }

        // casting regular RGB to panel RGB
        protected Point RGBtoPanelRGB(int[] RGB)
        {
            //int[] paneRGB = new int[3];
            //for (int i = 0; i < 3; i++)                paneRGB[i] = (int)RGB[i];
                //paneRGB[i] = (int)Math.Round((double)RGB[i]/size);                      
            int [] p = RtoGB(RGB);
            return new Point(p[0],p[1]);
        }

        protected Bitmap FillRegularRGB(byte targetR, byte targetG, byte targetB)
        {
            
            Bitmap n = new Bitmap(size + shortCathetus+1, size + longCathetus);
            byte r, g, b;
            // 0,0,255 - 0,255,255
            // 255,0,255 - 255,255,255
            b = targetB;
            for (r = 0; r < targetR; r++)
                for (g = 0; g < targetG; g++)
                {
                    Point xy = RGBtoPanelRGB(new int[] { r, g, 0 });
                    n.SetPixel(xy.X, xy.Y, Color.FromArgb(r, g, b));
                }
            
            // 255,0,255 - 255,255,255
            // 255,0,0 - 255,255,0
            r = targetR;
            for (g = 0; g < targetG; g++)
                for (b = 0; b < targetB; b++)                
                {
                    Point xy = RGBtoPanelRGB(new int[] { r, g, b });
                    n.SetPixel(xy.X, xy.Y, Color.FromArgb(r, g, 255 -b));
                }

       
            // 0,255,255 - 0,255,0
            // 255,0,0 - 255,255,0
            g = targetG;
            for (b = 0; b < targetB; b++)
                for (r = 0; r < targetR; r++)
                {
                    Point xy = RGBtoPanelRGB(new int[] { r, g, b });
                    n.SetPixel(xy.X, xy.Y, Color.FromArgb(r, g, 255-b));
                }
       
            /*
            for (byte r = 0; r < 255; r++)
                for (byte g = 0; g < 255; g++)
                    for (byte b = 0; b < 255; b++)
            */  
            return n;

        }



        public RGBCubeControl()
        {
            InitializeComponent();
            for (int i = 0; i < 3; i++)
                RGB[i] = 0;
            showModel = true;
            alpha = 30;            
            size = 255;
            shortCathetus = findShortCathetus(alpha, size);
            longCathetus = findLongCathetus(alpha, size); 

            TopFarLeft          = new Point(shortCathetus, 0); 
            TopFarRight         = new Point(shortCathetus + size, 0); 
            TopCloseLeft        = new Point(0, longCathetus);    
            TopCloseRight       = new Point(size, longCathetus); 
            BottomFarLeft       = new Point(shortCathetus, size);
            BottomFarRight      = new Point(shortCathetus + size, size);
            BottomCloseLeft     = new Point(0, size + longCathetus);
            BottomCloseRight    = new Point(size, size + longCathetus);

        }


        protected override void OnPaint(PaintEventArgs paintEvnt)
        {
            // Get the graphics object
            Graphics gfx = paintEvnt.Graphics;
            // Create a new pen that we shall use for drawing the line
            Pen myPen = new Pen(Color.FromArgb(0,0,0));
            // Drawing borders
            gfx.DrawLine(myPen, TopFarLeft, TopFarRight);
            gfx.DrawLine(myPen, TopFarLeft, TopCloseLeft);
            gfx.DrawLine(myPen, TopFarLeft, BottomFarLeft);

            gfx.DrawLine(myPen, BottomCloseLeft, BottomFarLeft);
            gfx.DrawLine(myPen, BottomCloseLeft, TopCloseLeft);
            gfx.DrawLine(myPen, BottomCloseLeft, BottomCloseRight);
            
            gfx.DrawLine(myPen, TopCloseRight, TopCloseLeft);
            gfx.DrawLine(myPen, TopCloseRight, TopFarRight);
            gfx.DrawLine(myPen, TopCloseRight, BottomCloseRight);
            
            gfx.DrawLine(myPen, BottomFarRight, TopFarRight);
            gfx.DrawLine(myPen, BottomFarRight, BottomFarLeft);
            gfx.DrawLine(myPen, BottomFarRight, BottomCloseRight);
            gfx.DrawImage(FillRegularRGB(255,10,10), 0, 0);
        }
    }
}
