using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_1
{
    public class Drawing
    {
        public int[] origin;
        public int[] axisSizes;
        public Drawing(int[] origin, int[] axisSizes)
        {
            this.origin = origin;
            this.axisSizes = axisSizes;
        }
        public void DrawBaseLines(Graphics g)
        {
            int x1_abscissa = origin[0] + axisSizes[0];
            int y0_ordinate = origin[1] - axisSizes[1];
            int y1_ordinate = origin[1] + axisSizes[1];
            g.DrawLine(new Pen(Color.Gray, 0.1f), origin[0], origin[1], x1_abscissa, origin[1]);
            g.DrawLine(new Pen(Color.Gray, 0.1f), origin[0], y0_ordinate, origin[0], y1_ordinate);
            Font font = new Font("Arial", 11);
            Brush brush = new SolidBrush(Color.Black);
            g.DrawString("100", font, brush, origin[0] - 11*3, y0_ordinate);
            g.DrawString("-100", font, brush, origin[0] - 11 * 3, y1_ordinate);
        }
        public void DrawColumns(Graphics g, DataElement[] elems, float elemWidth, float heightCoef, int elemNum)
        {
            for(int i = 0; i < elemNum; i++)
            {
                DataElement elem = elems[i];
                float x0 = origin[0] + elemWidth * i * 2;
                float y0 = elem.height <= 0 ? origin[1] : origin[1] - elem.height * heightCoef;
                float height = Math.Abs(elem.height) * heightCoef;
                float width = elemWidth;
                RectangleF rect = new RectangleF(x0, y0, width, height);
                g.FillRectangle(elem.brush, rect);

                float x_string = x0;
                float y_string = elem.height <= 0 ? y0 + height : y0 - 20;
                Font font = new Font("Arial", 7);
                Brush brush = new SolidBrush(Color.Black);
                RectangleF drawRect = new RectangleF(x_string, y_string, width, 20);
                StringFormat drawFormat = new StringFormat();
                drawFormat.Alignment = StringAlignment.Center;
                g.DrawString(elem.height.ToString(), font, brush, drawRect, drawFormat);
            }
        }
    }
}
