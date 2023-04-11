using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_2
{
    public class DataElement
    {
        public int weight;
        public int red;
        public int green;
        public int blue;
        public Brush brush;

        public DataElement(int weight, int red, int green, int blue)
        {
            this.weight = weight;
            this.red = red;
            this.green = green;
            this.blue = blue;
            brush = new SolidBrush(Color.FromArgb(red, green, blue));
        }
    }
}
