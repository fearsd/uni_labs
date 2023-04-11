using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_2
{
    public class Drawing
    {
        public int[] origin;
        public int sideSize;
        public Drawing(int[] origin, int sideSize)
        {
            this.origin = origin;
            this.sideSize = sideSize;
        }
        public void DrawPie(Graphics g, DataElement[] elems, float elemCoef, int elemNum)
        {
            float x = origin[0];
            float y = origin[1];
            float startAngle = 0;
            for (int i = 0; i < elemNum; i++)
            {
                DataElement elem = elems[i];

                float sweepAngle = elemCoef * elem.weight;
                g.FillPie(elem.brush, x, y, sideSize, sideSize, startAngle, sweepAngle);
                startAngle += sweepAngle;
                //g.FillRectangle(elem.brush, rect);

                //float x_string = x0;
                //float y_string = elem.height <= 0 ? y0 + height : y0 - 20;
                //Font font = new Font("Arial", 7);
                //Brush brush = new SolidBrush(Color.Black);
                //RectangleF drawRect = new RectangleF(x_string, y_string, width, 20);
                //StringFormat drawFormat = new StringFormat();
                //drawFormat.Alignment = StringAlignment.Center;
                //g.DrawString(elem.height.ToString(), font, brush, drawRect, drawFormat);
            }
        }
    }
}
