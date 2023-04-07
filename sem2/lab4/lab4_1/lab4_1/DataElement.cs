using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_1
{
    public class DataElement
    {
        public int height;
        public int red;
        public int green;
        public int blue;
        public Brush brush;

        public DataElement(int height, int red, int green, int blue)
        {
            this.height = height;
            this.red = red;
            this.green = green;
            this.blue = blue;
            brush = new SolidBrush(Color.FromArgb(red, green, blue));
        }
    }
}
