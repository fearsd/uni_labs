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
            }
        }
    }
}
